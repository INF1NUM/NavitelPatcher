namespace NavitelPatcher
{
    partial class FormWizard
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.wizardControl1 = new AeroWizard.WizardControl();
            this.wizardPage1SelectEXE = new AeroWizard.WizardPage();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.buttonBrowseInputFile = new System.Windows.Forms.Button();
            this.wizardPage2Analyse = new AeroWizard.WizardPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxPort = new System.Windows.Forms.PictureBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.pictureBoxSpeed = new System.Windows.Forms.PictureBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.wizardPage3NewParameters = new AeroWizard.WizardPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxNewSpeed = new System.Windows.Forms.ComboBox();
            this.labelCurrentPort = new System.Windows.Forms.Label();
            this.labelCurrentSpeed = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxNewPort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSaveFilePath = new System.Windows.Forms.Label();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardPage1SelectEXE.SuspendLayout();
            this.wizardPage2Analyse.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeed)).BeginInit();
            this.wizardPage3NewParameters.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.BackColor = System.Drawing.Color.White;
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.Add(this.wizardPage1SelectEXE);
            this.wizardControl1.Pages.Add(this.wizardPage2Analyse);
            this.wizardControl1.Pages.Add(this.wizardPage3NewParameters);
            this.wizardControl1.Size = new System.Drawing.Size(689, 450);
            this.wizardControl1.TabIndex = 0;
            this.wizardControl1.Text = "Navitel Patcher";
            this.wizardControl1.Title = "Navitel Patcher";
            this.wizardControl1.SelectedPageChanged += new System.EventHandler(this.wizardControl1_SelectedPageChanged);
            // 
            // wizardPage1SelectEXE
            // 
            this.wizardPage1SelectEXE.AllowNext = false;
            this.wizardPage1SelectEXE.Controls.Add(this.labelFilePath);
            this.wizardPage1SelectEXE.Controls.Add(this.buttonBrowseInputFile);
            this.wizardPage1SelectEXE.Name = "wizardPage1SelectEXE";
            this.wizardPage1SelectEXE.Size = new System.Drawing.Size(642, 296);
            this.wizardPage1SelectEXE.TabIndex = 0;
            this.wizardPage1SelectEXE.Text = "Выберите исполняемый файл (*.exe) Navitel Navigator";
            // 
            // labelFilePath
            // 
            this.labelFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFilePath.Location = new System.Drawing.Point(4, 22);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(554, 23);
            this.labelFilePath.TabIndex = 1;
            this.labelFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonBrowseInputFile
            // 
            this.buttonBrowseInputFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonBrowseInputFile.Location = new System.Drawing.Point(564, 22);
            this.buttonBrowseInputFile.Name = "buttonBrowseInputFile";
            this.buttonBrowseInputFile.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseInputFile.TabIndex = 0;
            this.buttonBrowseInputFile.Text = "Обзор";
            this.buttonBrowseInputFile.UseVisualStyleBackColor = true;
            this.buttonBrowseInputFile.Click += new System.EventHandler(this.buttonBrowseInputFile_Click);
            // 
            // wizardPage2Analyse
            // 
            this.wizardPage2Analyse.AllowNext = false;
            this.wizardPage2Analyse.Controls.Add(this.tableLayoutPanel1);
            this.wizardPage2Analyse.Controls.Add(this.progressBar1);
            this.wizardPage2Analyse.Controls.Add(this.labelProgress);
            this.wizardPage2Analyse.Name = "wizardPage2Analyse";
            this.wizardPage2Analyse.Size = new System.Drawing.Size(642, 296);
            this.wizardPage2Analyse.TabIndex = 1;
            this.wizardPage2Analyse.Text = "Анализ файла...";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxPort, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPort, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxSpeed, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSpeed, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 44);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBoxPort
            // 
            this.pictureBoxPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPort.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPort.Name = "pictureBoxPort";
            this.pictureBoxPort.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxPort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPort.TabIndex = 0;
            this.pictureBoxPort.TabStop = false;
            // 
            // labelPort
            // 
            this.labelPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPort.Location = new System.Drawing.Point(25, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(604, 22);
            this.labelPort.TabIndex = 1;
            this.labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxSpeed
            // 
            this.pictureBoxSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSpeed.Location = new System.Drawing.Point(3, 25);
            this.pictureBoxSpeed.Name = "pictureBoxSpeed";
            this.pictureBoxSpeed.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxSpeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSpeed.TabIndex = 2;
            this.pictureBoxSpeed.TabStop = false;
            // 
            // labelSpeed
            // 
            this.labelSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSpeed.Location = new System.Drawing.Point(25, 22);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(604, 22);
            this.labelSpeed.TabIndex = 3;
            this.labelSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 42);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(629, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // labelProgress
            // 
            this.labelProgress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProgress.Location = new System.Drawing.Point(3, 16);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(636, 23);
            this.labelProgress.TabIndex = 0;
            this.labelProgress.Text = "Анализ...";
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wizardPage3NewParameters
            // 
            this.wizardPage3NewParameters.AllowBack = false;
            this.wizardPage3NewParameters.AllowNext = false;
            this.wizardPage3NewParameters.Controls.Add(this.tableLayoutPanel2);
            this.wizardPage3NewParameters.Controls.Add(this.groupBox1);
            this.wizardPage3NewParameters.Name = "wizardPage3NewParameters";
            this.wizardPage3NewParameters.Size = new System.Drawing.Size(642, 296);
            this.wizardPage3NewParameters.TabIndex = 2;
            this.wizardPage3NewParameters.Text = "Выберите желаемые параметры";
            this.wizardPage3NewParameters.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.wizardPage3NewParameters_Commit);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelCurrentPort, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelCurrentSpeed, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(636, 120);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxNewSpeed);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(321, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 54);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбетите желаемую скорость";
            // 
            // comboBoxNewSpeed
            // 
            this.comboBoxNewSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewSpeed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxNewSpeed.FormattingEnabled = true;
            this.comboBoxNewSpeed.Location = new System.Drawing.Point(6, 22);
            this.comboBoxNewSpeed.Name = "comboBoxNewSpeed";
            this.comboBoxNewSpeed.Size = new System.Drawing.Size(295, 23);
            this.comboBoxNewSpeed.TabIndex = 6;
            // 
            // labelCurrentPort
            // 
            this.labelCurrentPort.Location = new System.Drawing.Point(3, 0);
            this.labelCurrentPort.Name = "labelCurrentPort";
            this.labelCurrentPort.Size = new System.Drawing.Size(312, 44);
            this.labelCurrentPort.TabIndex = 8;
            this.labelCurrentPort.Text = "Текущий порт: ";
            this.labelCurrentPort.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelCurrentSpeed
            // 
            this.labelCurrentSpeed.Location = new System.Drawing.Point(3, 60);
            this.labelCurrentSpeed.Name = "labelCurrentSpeed";
            this.labelCurrentSpeed.Size = new System.Drawing.Size(312, 44);
            this.labelCurrentSpeed.TabIndex = 9;
            this.labelCurrentSpeed.Text = "Текущая скорость:";
            this.labelCurrentSpeed.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxNewPort);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(321, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 54);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите желаемый порт";
            // 
            // comboBoxNewPort
            // 
            this.comboBoxNewPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewPort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxNewPort.FormattingEnabled = true;
            this.comboBoxNewPort.Location = new System.Drawing.Point(6, 22);
            this.comboBoxNewPort.Name = "comboBoxNewPort";
            this.comboBoxNewPort.Size = new System.Drawing.Size(294, 23);
            this.comboBoxNewPort.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSaveFilePath);
            this.groupBox1.Controls.Add(this.buttonSaveFile);
            this.groupBox1.Location = new System.Drawing.Point(6, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 49);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Директория сохранения";
            // 
            // labelSaveFilePath
            // 
            this.labelSaveFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSaveFilePath.Location = new System.Drawing.Point(6, 19);
            this.labelSaveFilePath.Name = "labelSaveFilePath";
            this.labelSaveFilePath.Size = new System.Drawing.Size(540, 23);
            this.labelSaveFilePath.TabIndex = 3;
            this.labelSaveFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSaveFile.Location = new System.Drawing.Point(552, 19);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveFile.TabIndex = 2;
            this.buttonSaveFile.Text = "Обзор";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // FormWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.wizardControl1);
            this.Name = "FormWizard";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardPage1SelectEXE.ResumeLayout(false);
            this.wizardPage2Analyse.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeed)).EndInit();
            this.wizardPage3NewParameters.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl wizardControl1;
        private AeroWizard.WizardPage wizardPage1SelectEXE;
        private AeroWizard.WizardPage wizardPage2Analyse;
        private System.Windows.Forms.Button buttonBrowseInputFile;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelProgress;
        private AeroWizard.WizardPage wizardPage3NewParameters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.PictureBox pictureBoxSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSaveFilePath;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxNewPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxNewSpeed;
        private System.Windows.Forms.Label labelCurrentPort;
        private System.Windows.Forms.Label labelCurrentSpeed;
    }
}

