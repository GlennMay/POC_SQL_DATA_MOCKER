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
            
            if (!FormatFilePathIsValid())
            {
                AllValid = false;
                
                return AllValid;
            }

            if (!OutputFileNameIsValid())
            {
                AllValid = false;
                return AllValid;
            }

            if (!RowsToOutputIsValid())
            {
                AllValid = false;
                return AllValid;
            }

            if (!DelimiterIsValid())
            {
                AllValid = false;
                return AllValid;
            }

            return AllValid;
        }

        private bool FormatFilePathIsValid()
        {
            bool isValid = false;

            if (textBox_FormatFilePath.ToString().Trim().Length>0)
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

            if (textBox_OutFileName.ToString().Trim().Length>0)
            {
                isValid = true;
            }
            return isValid;
        }

        private bool RowsToOutputIsValid()
        {
            bool isValid = false;
            long rowCount = 0;
                                 
            isValid = long.TryParse(textBox_RowsOut.ToString(), out rowCount);

            return isValid;
        }

        private bool DelimiterIsValid()
        {
            bool isValid = false;

            if (textBox_Delimiter.ToString().Length>0)
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
    }
}
