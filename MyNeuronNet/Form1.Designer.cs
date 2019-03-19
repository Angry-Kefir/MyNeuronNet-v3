namespace MyNeuronNet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.processLearn = new System.Windows.Forms.TextBox();
            this.identify = new System.Windows.Forms.Button();
            this.identifyResult = new System.Windows.Forms.TextBox();
            this.saveWeights = new System.Windows.Forms.Button();
            this.trueIdentify = new System.Windows.Forms.Label();
            this.totalIdentify = new System.Windows.Forms.Label();
            this.numToIdentify = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.catalogPath = new System.Windows.Forms.TextBox();
            this.chooseCatalog = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadWeights = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.neuronsInNet = new System.Windows.Forms.TextBox();
            this.learnButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numEpochs = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numExx = new System.Windows.Forms.NumericUpDown();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numToIdentify)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEpochs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExx)).BeginInit();
            this.SuspendLayout();
            // 
            // processLearn
            // 
            this.processLearn.Location = new System.Drawing.Point(12, 29);
            this.processLearn.Multiline = true;
            this.processLearn.Name = "processLearn";
            this.processLearn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.processLearn.Size = new System.Drawing.Size(365, 310);
            this.processLearn.TabIndex = 0;
            // 
            // identify
            // 
            this.identify.Location = new System.Drawing.Point(114, 76);
            this.identify.Name = "identify";
            this.identify.Size = new System.Drawing.Size(82, 29);
            this.identify.TabIndex = 1;
            this.identify.Text = "Распознать";
            this.identify.UseVisualStyleBackColor = true;
            this.identify.Click += new System.EventHandler(this.identifyClick);
            // 
            // identifyResult
            // 
            this.identifyResult.Location = new System.Drawing.Point(383, 29);
            this.identifyResult.Multiline = true;
            this.identifyResult.Name = "identifyResult";
            this.identifyResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.identifyResult.Size = new System.Drawing.Size(414, 310);
            this.identifyResult.TabIndex = 2;
            // 
            // saveWeights
            // 
            this.saveWeights.Location = new System.Drawing.Point(202, 76);
            this.saveWeights.Name = "saveWeights";
            this.saveWeights.Size = new System.Drawing.Size(96, 29);
            this.saveWeights.TabIndex = 3;
            this.saveWeights.Text = "Сохранить веса";
            this.saveWeights.UseVisualStyleBackColor = true;
            this.saveWeights.Click += new System.EventHandler(this.saveWeightsClick);
            // 
            // trueIdentify
            // 
            this.trueIdentify.AutoSize = true;
            this.trueIdentify.Location = new System.Drawing.Point(216, 16);
            this.trueIdentify.Name = "trueIdentify";
            this.trueIdentify.Size = new System.Drawing.Size(57, 13);
            this.trueIdentify.TabIndex = 4;
            this.trueIdentify.Text = "Верных  0";
            // 
            // totalIdentify
            // 
            this.totalIdentify.AutoSize = true;
            this.totalIdentify.Location = new System.Drawing.Point(312, 16);
            this.totalIdentify.Name = "totalIdentify";
            this.totalIdentify.Size = new System.Drawing.Size(31, 13);
            this.totalIdentify.TabIndex = 5;
            this.totalIdentify.Text = "из  0";
            // 
            // numToIdentify
            // 
            this.numToIdentify.Location = new System.Drawing.Point(83, 12);
            this.numToIdentify.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numToIdentify.Name = "numToIdentify";
            this.numToIdentify.Size = new System.Drawing.Size(70, 20);
            this.numToIdentify.TabIndex = 6;
            this.numToIdentify.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Распознать:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ход обучения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Результат распознавания:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "шт.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Каталог:";
            // 
            // catalogPath
            // 
            this.catalogPath.Location = new System.Drawing.Point(64, 44);
            this.catalogPath.Name = "catalogPath";
            this.catalogPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.catalogPath.Size = new System.Drawing.Size(336, 20);
            this.catalogPath.TabIndex = 12;
            this.catalogPath.Text = "myImagesForNN\\forIdentify\\sobel\\";
            // 
            // chooseCatalog
            // 
            this.chooseCatalog.Location = new System.Drawing.Point(10, 76);
            this.chooseCatalog.Name = "chooseCatalog";
            this.chooseCatalog.Size = new System.Drawing.Size(98, 29);
            this.chooseCatalog.TabIndex = 13;
            this.chooseCatalog.Text = "Выбор каталога";
            this.chooseCatalog.UseVisualStyleBackColor = true;
            this.chooseCatalog.Click += new System.EventHandler(this.chooseCatalog_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.loadWeights);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.catalogPath);
            this.panel1.Controls.Add(this.chooseCatalog);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.saveWeights);
            this.panel1.Controls.Add(this.numToIdentify);
            this.panel1.Controls.Add(this.trueIdentify);
            this.panel1.Controls.Add(this.identify);
            this.panel1.Controls.Add(this.totalIdentify);
            this.panel1.Location = new System.Drawing.Point(383, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 120);
            this.panel1.TabIndex = 14;
            // 
            // loadWeights
            // 
            this.loadWeights.Location = new System.Drawing.Point(304, 76);
            this.loadWeights.Name = "loadWeights";
            this.loadWeights.Size = new System.Drawing.Size(98, 29);
            this.loadWeights.TabIndex = 14;
            this.loadWeights.Text = "Загрузить веса";
            this.loadWeights.UseVisualStyleBackColor = true;
            this.loadWeights.Click += new System.EventHandler(this.loadWeights_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.resetButton);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.neuronsInNet);
            this.panel2.Controls.Add(this.learnButton);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.numEpochs);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.numExx);
            this.panel2.Location = new System.Drawing.Point(12, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 120);
            this.panel2.TabIndex = 15;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(266, 76);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(85, 29);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Сброс";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Параметры сети";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(178, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Число нейронов в слоях:";
            // 
            // neuronsInNet
            // 
            this.neuronsInNet.Location = new System.Drawing.Point(178, 34);
            this.neuronsInNet.Multiline = true;
            this.neuronsInNet.Name = "neuronsInNet";
            this.neuronsInNet.Size = new System.Drawing.Size(173, 36);
            this.neuronsInNet.TabIndex = 5;
            this.neuronsInNet.Text = "625 3";
            // 
            // learnButton
            // 
            this.learnButton.Location = new System.Drawing.Point(178, 76);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(85, 29);
            this.learnButton.TabIndex = 4;
            this.learnButton.Text = "Обучить";
            this.learnButton.UseVisualStyleBackColor = true;
            this.learnButton.Click += new System.EventHandler(this.learnButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Число эпох:";
            // 
            // numEpochs
            // 
            this.numEpochs.Location = new System.Drawing.Point(102, 82);
            this.numEpochs.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numEpochs.Name = "numEpochs";
            this.numEpochs.Size = new System.Drawing.Size(58, 20);
            this.numEpochs.TabIndex = 2;
            this.numEpochs.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Число примеров:";
            // 
            // numExx
            // 
            this.numExx.Location = new System.Drawing.Point(102, 56);
            this.numExx.Name = "numExx";
            this.numExx.Size = new System.Drawing.Size(58, 20);
            this.numExx.TabIndex = 0;
            this.numExx.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 473);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.identifyResult);
            this.Controls.Add(this.processLearn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numToIdentify)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEpochs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox processLearn;
        private System.Windows.Forms.Button identify;
        private System.Windows.Forms.TextBox identifyResult;
        private System.Windows.Forms.Button saveWeights;
        private System.Windows.Forms.Label trueIdentify;
        private System.Windows.Forms.Label totalIdentify;
        private System.Windows.Forms.NumericUpDown numToIdentify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox catalogPath;
        private System.Windows.Forms.Button chooseCatalog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button learnButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numEpochs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numExx;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox neuronsInNet;
        private System.Windows.Forms.Button loadWeights;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

