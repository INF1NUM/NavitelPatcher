using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavitelPatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            patcher = new FilePatcher();
            bwAnalyser = new BackgroundWorker();
            bwAnalyser.WorkerReportsProgress = true;
            bwAnalyser.DoWork += BwAnalyser_DoWork;
            bwAnalyser.ProgressChanged += BwAnalyser_ProgressChanged;
            bwAnalyser.RunWorkerCompleted += BwAnalyser_RunWorkerCompleted;
        }
        
        FilePatcher patcher;
        private BackgroundWorker bwAnalyser;
        private NavitelCOMPort foundedPort;

        private void BwAnalyser_DoWork(object sender, DoWorkEventArgs e)
        {
            bwAnalyser.ReportProgress(0, "Чтение файла...");
            patcher.ReadFile(e.Argument as string);

            var comPorts = NavitelCOMPort.GetPortList();
            List<NavitelCOMPort> foundedPorts = new List<NavitelCOMPort>();
            foreach (var port in comPorts)
            {
                bwAnalyser.ReportProgress(port.PortNumber * 10, "Поиск порта COM" + port.PortNumber + "...");
                List<int> comOffsets = patcher.GetOffsets(port.Signature);
                foreach (var entrines in comOffsets)
                {
                    port.OffsetInFile = entrines;
                    foundedPorts.Add(port);
                }
            }

            e.Result = foundedPorts;
        }
        
        private void BwAnalyser_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            labelProgress.Text = e.UserState as string;
        }

        private void BwAnalyser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var comPorts = e.Result as List<NavitelCOMPort>;
            if (comPorts.Count == 1)
            {
                progressBar1.Value = 100;
                labelProgress.Text = "Готово";
                pictureBoxPort.Image = Properties.Resources.iconOk;
                labelPort.Text = "Найден порт COM" + comPorts[0].PortNumber;
                wizardPage2Analyse.AllowNext = true;
                foundedPort = comPorts[0];
            }
            else
            {
                if (comPorts.Count < 1)
                {
                    progressBar1.Value = 100;
                    labelProgress.Text = "Готово";
                    pictureBoxPort.Image = Properties.Resources.iconError;
                    labelPort.Text = "COM порты не найдены";
                }
                else
                {
                    progressBar1.Value = 100;
                    labelProgress.Text = "Готово";
                    pictureBoxPort.Image = Properties.Resources.iconError;
                    labelPort.Text = "Найдено более одного вхождения. Применения патча может вызвать ошибку в приложении.";
                }

            }
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
                bwAnalyser.RunWorkerAsync(labelFilePath.Text);
        }
    }
}
