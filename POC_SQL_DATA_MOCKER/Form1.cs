using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace POC_SQL_DATA_MOCKER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Interface_Inputs_Are_Valid()
        {
            bool AllValid = true;
            Color ErrorColor = Color.Red;

            if (!FormatFilePathIsValid())
            {
                AllValid = false;
                richTextBox1.SelectionColor= ErrorColor;
                richTextBox1.AppendText("Format file path is invalid.\r\n");
                // richTextBox1.ForeColor = curColor;
            }

            if (!OutputFileNameIsValid())
            {
                AllValid = false;
                richTextBox1.SelectionColor = ErrorColor;
                richTextBox1.AppendText("Output file name is invalid.\r\n");
                
            }

            if (!RowsToOutputIsValid())
            {
                AllValid = false;
                richTextBox1.SelectionColor = ErrorColor;
                richTextBox1.AppendText("Rows to output is invalid.\r\n");
                
            }

            if (!DelimiterIsValid())
            {
                AllValid = false;
                richTextBox1.SelectionColor = ErrorColor;
                richTextBox1.AppendText("Delimiter is invalid.\r\n");
                
            }

            richTextBox1.AppendText("\r\n");
            return AllValid;
        }

        private bool FormatFilePathIsValid()
        {
            bool isValid = false;

            if (textBox_FormatFilePath.Text.ToString().Trim().Length>0)
            {
                if (File.Exists(textBox_FormatFilePath.ToString()))
                {
                    isValid = true;
                }
            }

            return isValid;
        }

        private bool OutputFileNameIsValid()
        {
            bool isValid = false;

            if (textBox_OutFileName.Text.ToString().Trim().Length>0)
            {
                isValid = true;
            }
            return isValid;
        }

        private bool RowsToOutputIsValid()
        {
            bool isValid = false;
            long rowCount = 0;
                                 
            isValid = long.TryParse(textBox_RowsOut.Text.ToString(), out rowCount);

            return isValid;
        }

        private bool DelimiterIsValid()
        {
            bool isValid = false;

            if (textBox_Delimiter.Text.ToString().Trim().Length>0)
            {
                isValid = true;
            }
            return isValid;
        }

        private void btn_GenMockData_Click(object sender, EventArgs e)
        {
            if (Interface_Inputs_Are_Valid())
            {

            }
        }

        private void btn_ReadFormat_Click(object sender, EventArgs e)
        {
            textBox_FormatFilePath.Text = openFileDialog1.ToString();
        }

        private void btn_PickOutFolder_Click(object sender, EventArgs e)
        {
            textBox_OutFileName.Text = folderBrowserDialog1.ToString() + "DataMock.csv";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.SelectedText = "Sometext\r\n";
            richTextBox1.AppendText("Moretext\r\n");
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.AppendText("Next\r\n");
        }
    }
}
