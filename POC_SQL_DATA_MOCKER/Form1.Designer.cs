namespace POC_SQL_DATA_MOCKER
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_ReadFormat = new System.Windows.Forms.Button();
            this.btn_GenMockData = new System.Windows.Forms.Button();
            this.textBox_FormatFilePath = new System.Windows.Forms.TextBox();
            this.textBox_RowsOut = new System.Windows.Forms.TextBox();
            this.textBox_OutFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Delimiter = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_PickOutFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_ReadFormat
            // 
            this.btn_ReadFormat.Location = new System.Drawing.Point(12, 12);
            this.btn_ReadFormat.Name = "btn_ReadFormat";
            this.btn_ReadFormat.Size = new System.Drawing.Size(127, 23);
            this.btn_ReadFormat.TabIndex = 0;
            this.btn_ReadFormat.Text = "Pick Format File";
            this.btn_ReadFormat.UseVisualStyleBackColor = true;
            this.btn_ReadFormat.Click += new System.EventHandler(this.btn_ReadFormat_Click);
            // 
            // btn_GenMockData
            // 
            this.btn_GenMockData.Location = new System.Drawing.Point(12, 157);
            this.btn_GenMockData.Name = "btn_GenMockData";
            this.btn_GenMockData.Size = new System.Drawing.Size(127, 23);
            this.btn_GenMockData.TabIndex = 4;
            this.btn_GenMockData.Text = "Generate Mock Data";
            this.btn_GenMockData.UseVisualStyleBackColor = true;
            this.btn_GenMockData.Click += new System.EventHandler(this.btn_GenMockData_Click);
            // 
            // textBox_FormatFilePath
            // 
            this.textBox_FormatFilePath.Enabled = false;
            this.textBox_FormatFilePath.Location = new System.Drawing.Point(145, 15);
            this.textBox_FormatFilePath.Name = "textBox_FormatFilePath";
            this.textBox_FormatFilePath.Size = new System.Drawing.Size(574, 20);
            this.textBox_FormatFilePath.TabIndex = 2;
            this.textBox_FormatFilePath.TabStop = false;
            // 
            // textBox_RowsOut
            // 
            this.textBox_RowsOut.Location = new System.Drawing.Point(145, 83);
            this.textBox_RowsOut.Name = "textBox_RowsOut";
            this.textBox_RowsOut.Size = new System.Drawing.Size(100, 20);
            this.textBox_RowsOut.TabIndex = 2;
            // 
            // textBox_OutFileName
            // 
            this.textBox_OutFileName.Enabled = false;
            this.textBox_OutFileName.Location = new System.Drawing.Point(145, 50);
            this.textBox_OutFileName.Name = "textBox_OutFileName";
            this.textBox_OutFileName.Size = new System.Drawing.Size(574, 20);
            this.textBox_OutFileName.TabIndex = 4;
            this.textBox_OutFileName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Delimiter for output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rows to output?";
            // 
            // textBox_Delimiter
            // 
            this.textBox_Delimiter.Location = new System.Drawing.Point(146, 116);
            this.textBox_Delimiter.Name = "textBox_Delimiter";
            this.textBox_Delimiter.Size = new System.Drawing.Size(100, 20);
            this.textBox_Delimiter.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(266, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(453, 340);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // btn_PickOutFolder
            // 
            this.btn_PickOutFolder.Location = new System.Drawing.Point(14, 47);
            this.btn_PickOutFolder.Name = "btn_PickOutFolder";
            this.btn_PickOutFolder.Size = new System.Drawing.Size(126, 23);
            this.btn_PickOutFolder.TabIndex = 1;
            this.btn_PickOutFolder.Text = "Pick Output Folder";
            this.btn_PickOutFolder.UseVisualStyleBackColor = true;
            this.btn_PickOutFolder.Click += new System.EventHandler(this.btn_PickOutFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 455);
            this.Controls.Add(this.btn_PickOutFolder);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox_Delimiter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_OutFileName);
            this.Controls.Add(this.textBox_RowsOut);
            this.Controls.Add(this.textBox_FormatFilePath);
            this.Controls.Add(this.btn_GenMockData);
            this.Controls.Add(this.btn_ReadFormat);
            this.Name = "Form1";
            this.Text = "Mock Data Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_ReadFormat;
        private System.Windows.Forms.Button btn_GenMockData;
        private System.Windows.Forms.TextBox textBox_FormatFilePath;
        private System.Windows.Forms.TextBox textBox_RowsOut;
        private System.Windows.Forms.TextBox textBox_OutFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Delimiter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_PickOutFolder;
    }
}

