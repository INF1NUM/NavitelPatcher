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
            _patcher = new FilePatcher();
            bwAnalyser = new BackgroundWorker();
            bwAnalyser.WorkerReportsProgress = true;
            bwAnalyser.DoWork += BwAnalyser_DoWork;
            bwAnalyser.ProgressChanged += BwAnalyser_ProgressChanged;
            bwAnalyser.RunWorkerCompleted += BwAnalyser_RunWorkerCompleted;
        }

        private NavitelCOMPort foundedPort;

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

        private void BwAnalyser_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            labelProgress.Text = e.UserState as string;
        }

        private void BwAnalyser_DoWork(object sender, DoWorkEventArgs e)
        {
            bwAnalyser.ReportProgress(0,"Чтение файла...");
            _patcher.ReadFile(e.Argument as string);

            var comPorts = NavitelCOMPort.GetPortList();
            List<NavitelCOMPort> foundedPorts = new List<NavitelCOMPort>();
            foreach (var port in comPorts)
            {
                bwAnalyser.ReportProgress(port.PortNumber * 10, "Поиск порта COM"+ port.PortNumber + "...");
                List<int> comOffsets = _patcher.GetOffsets(port.Signature);
                foreach (var entrines in comOffsets)
                {
                    port.OffsetInFile = entrines;
                    foundedPorts.Add(port);
                }

                //if (comOffsets.Count == 1)
                //{
                //    port.OffsetInFile = comOffsets[0];
                //    foundedPorts.Add(port);
                //}                    
                //else
                //{
                //    if (comOffsets.Count > 1)
                //    {
                //        bwAnalyser.ReportProgress(100, "Найдено более одного вхождения для сигнатуры порта COM" + port.PortNumber + ". Применение патча невозможно.");
                //        return;
                //    }
                //}
            }

            e.Result = foundedPorts;


            //bwAnalyser.ReportProgress(10, "Поиск COM1...");
            //List<int> com1Entries = _patcher.GetOffsets(NavitelCOMPort.com1);
            //bwAnalyser.ReportProgress(20, "Поиск COM2...");
            //List<int> com2Entries = _patcher.GetOffsets(NavitelCOMPort.com2);
            //bwAnalyser.ReportProgress(30, "Поиск COM3...");
            //List<int> com3Entries = _patcher.GetOffsets(NavitelCOMPort.com3);
            //bwAnalyser.ReportProgress(40, "Поиск COM4...");
            //List<int> com4Entries = _patcher.GetOffsets(NavitelCOMPort.com4);
            //bwAnalyser.ReportProgress(50, "Поиск COM5...");
            //List<int> com5Entries = _patcher.GetOffsets(NavitelCOMPort.com5);
            //bwAnalyser.ReportProgress(60, "Поиск COM6...");
            //List<int> com6Entries = _patcher.GetOffsets(NavitelCOMPort.com6);
            //bwAnalyser.ReportProgress(70, "Поиск COM7...");
            //List<int> com7Entries = _patcher.GetOffsets(NavitelCOMPort.com7);
            //bwAnalyser.ReportProgress(80, "Поиск COM8...");
            //List<int> com8Entries = _patcher.GetOffsets(NavitelCOMPort.com8);
            //bwAnalyser.ReportProgress(90, "Поиск COM9...");
            //List<int> com9Entries = _patcher.GetOffsets(NavitelCOMPort.com9);
            //var comEntries = com1Entries.Union(com2Entries).Union(com3Entries).Union(com4Entries).Union(com5Entries).Union(com6Entries).Union(com7Entries).Union(com8Entries).Union(com9Entries);
            //if (comEntries.Count() == 1)
            //    bwAnalyser.ReportProgress(100, "COM порт найден.");
            //else
            //{
            //    if (comEntries.Count() < 1)
            //    {
            //        bwAnalyser.ReportProgress(100, "COM порт не найден.");
            //        return;
            //    }
            //    else
            //        bwAnalyser.ReportProgress(100, "Найдено более одного вхождения. Применение патча невозможно.");
            //}
        }

        private BackgroundWorker bwAnalyser;

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

        FilePatcher _patcher;

        private void Analyse(string filePath)
        {
            bwAnalyser.RunWorkerAsync(filePath);
        }

        private void wizardControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (wizardControl1.SelectedPage == wizardPage2Analyse)
                    Analyse(labelFilePath.Text);
        }
    }
}
