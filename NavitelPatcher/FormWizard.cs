using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavitelPatcher
{
    public partial class FormWizard : Form
    {
        public FormWizard()
        {
            InitializeComponent();
            patcher = new FilePatcher();
            bwAnalyser = new BackgroundWorker();
            bwAnalyser.WorkerReportsProgress = true;
            bwAnalyser.DoWork += BwAnalyser_DoWork;
            bwAnalyser.ProgressChanged += BwAnalyser_ProgressChanged;
            bwAnalyser.RunWorkerCompleted += BwAnalyser_RunWorkerCompleted;
        }

        private class AnalyseResult
        {
            public AnalyseResult(List<NavitelCOMPort> portList, List<NavitelCOMSpeed> speedList)
            {
                this.Ports = portList;
                this.Speed = speedList;
            }
            public List<NavitelCOMPort> Ports { get; private set; }
            public List<NavitelCOMSpeed> Speed { get; private set; }
        }

        FilePatcher patcher;
        private BackgroundWorker bwAnalyser;
        private NavitelCOMPort foundedPort;
        private NavitelCOMSpeed foundedSpeed;

        private void BwAnalyser_DoWork(object sender, DoWorkEventArgs e)
        {
            int progressCounter = 0;
            bwAnalyser.ReportProgress(0, "Чтение файла...");
            patcher.ReadFile(e.Argument as string);

            var comPorts = NavitelCOMPort.GetPortList();
            List<NavitelCOMPort> foundedPorts = new List<NavitelCOMPort>();
            foreach (var port in comPorts)
            {
                progressCounter += 6;
                bwAnalyser.ReportProgress(progressCounter, "Поиск сигнатуры порта COM" + port.PortNumber + "...");
                List<int> comOffsets = patcher.GetOffsets(port.Signature);
                foreach (var entry in comOffsets)
                {
                    port.OffsetInFile = entry;
                    foundedPorts.Add(port);
                }
            }

            var speedList = NavitelCOMSpeed.GetSpeedList();
            List<NavitelCOMSpeed> foundedSpeeds = new List<NavitelCOMSpeed>();
            foreach(var speed in speedList)
            {
                progressCounter += 6;
                bwAnalyser.ReportProgress(progressCounter, "Поиск сигнатуры скорости порта " + speed.Name + " бит/с...");
                List<int> speedOffsets = patcher.GetOffsets(speed.Signature);
                foreach (var entry in speedOffsets)
                {
                    speed.OffsetInFile = entry;
                    foundedSpeeds.Add(speed);
                }
            }


            e.Result = new AnalyseResult(foundedPorts, foundedSpeeds);
        }
        
        private void BwAnalyser_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            labelProgress.Text = e.UserState as string;
        }

        private void BwAnalyser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var result = e.Result as AnalyseResult;

            if (result.Ports.Count == 1)
            {
                pictureBoxPort.Image = Properties.Resources.iconOk;
                labelPort.Text = "Найдена сигнатура порта COM" + result.Ports[0].PortNumber;
                wizardPage2Analyse.AllowNext = true;
                foundedPort = result.Ports[0];
            }
            else
            {
                if (result.Ports.Count < 1)
                {
                    pictureBoxPort.Image = Properties.Resources.iconError;
                    labelPort.Text = "Сигнатуры COM порта не найдены.";
                }
                else
                {
                    pictureBoxPort.Image = Properties.Resources.iconError;
                    labelPort.Text = "Найдено более одной сигнатуры. Применения патча может вызвать ошибку в приложении.";
                }
            }

            if (result.Speed.Count == 1)
            {
                pictureBoxSpeed.Image = Properties.Resources.iconOk;
                labelSpeed.Text = "Найдена сигнатура скорости порта " + result.Speed[0].Name + " бит/с";
                wizardPage2Analyse.AllowNext = true;
                foundedSpeed = result.Speed[0];
            }
            else
            {
                if (result.Speed.Count < 1)
                {
                    pictureBoxSpeed.Image = Properties.Resources.iconError;
                    labelSpeed.Text = "Сугнатуры скорости порта не найдены.";
                }
                else
                {
                    pictureBoxSpeed.Image = Properties.Resources.iconError;
                    labelSpeed.Text = "Найдено более одной сигнатуры. Применения патча может вызвать ошибку в приложении.";
                }
            }

            labelProgress.Text = "Готово";
            progressBar1.Value = 100;
        }

        private void buttonBrowseInputFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog inFileDialog = new OpenFileDialog())
            {
                if(inFileDialog.ShowDialog() == DialogResult.OK)
                {
                    labelFilePath.Text = inFileDialog.FileName;
                    wizardPage1SelectEXE.AllowNext = true;
                }
            }
        }
                
        private void wizardControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (wizardControl1.SelectedPage == wizardPage2Analyse)
            {
                pictureBoxPort.Image = null;
                pictureBoxSpeed.Image = null;
                labelPort.Text = null;
                labelSpeed.Text = null;
                bwAnalyser.RunWorkerAsync(labelFilePath.Text);
            }
            if (wizardControl1.SelectedPage == wizardPage3NewParameters)
            {
                if (foundedPort != null)
                {
                    labelCurrentPort.Text = "Текущий порт: " + foundedPort.ToString();
                    var portlist = NavitelCOMPort.GetPortList();
                    var portItems = from port in portlist where port.PortNumber != foundedPort.PortNumber select port;
                    comboBoxNewPort.Items.Clear();
                    int portIndex = comboBoxNewPort.Items.Add("Не менять");
                    comboBoxNewPort.SelectedIndex = portIndex;
                    foreach (var item in portItems)
                        comboBoxNewPort.Items.Add(item);
                }
                else
                    labelCurrentPort.Text = "Текущий порт: не найден.";

                if (foundedSpeed != null)
                {
                    labelCurrentSpeed.Text = "Текущая скорость: " + foundedSpeed.ToString();
                    var speedList = NavitelCOMSpeed.GetSpeedList();
                    var speedItems = from speed in speedList where speed.Name != foundedSpeed.Name select speed;
                    comboBoxNewSpeed.Items.Clear();
                    int speedIndex = comboBoxNewSpeed.Items.Add("Не менять");
                    comboBoxNewSpeed.SelectedIndex = speedIndex;
                    foreach (var item in speedItems)
                        comboBoxNewSpeed.Items.Add(item);
                }
                else
                    labelCurrentSpeed.Text = "Текущая скорость: не найдена." + foundedSpeed.ToString();
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfDialog = new SaveFileDialog())
            {
                sfDialog.Filter = "исполняемые файлы (*.exe)|*.exe";
                if (sfDialog.ShowDialog() == DialogResult.OK)
                {
                    labelSaveFilePath.Text = sfDialog.FileName;
                    wizardPage3NewParameters.AllowNext = true;
                }
            }
        }

        private void wizardPage3NewParameters_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            //здесть нужно пропатчить и сохранить файл
        }
    }
}
