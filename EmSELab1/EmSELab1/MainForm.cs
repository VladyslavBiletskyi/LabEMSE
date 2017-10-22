using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using EmSELab1.DTOs;
using EmSELab1.Processors;

namespace EmSELab1
{
    public partial class MainForm : Form
    {
        private const string ImportSuccessfullState = "Imported successfull";
        private const string ImportFailedState = "Imported failed";
        private const string ImportAburtedState = "Imported aborted";

        private IList<InputDataDto> inputData;
        public MainForm()
        {
            InitializeComponent();
            inputData = new List<InputDataDto>();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            bool isSuccessfull = TryUploadData();
            showDataButton.Visible = isSuccessfull;
            if (isSuccessfull)
            {               
                ProcessData();
            }
        }

        private void showDataButton_Click(object sender, EventArgs e)
        {
            using (DataGridForm grid = new DataGridForm(inputData))
            {
                grid.ShowDialog();
            }
        }

        private bool TryUploadData()
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                dataUploadStateLabel.Text = ImportAburtedState;
                return false;
            }
            try
            {
                using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        string line;
                        while (!String.IsNullOrEmpty(line = reader.ReadLine()))
                        {
                            var values = line.Split(',');
                            InputDataDto value =
                                new InputDataDto
                                {
                                    Y = int.Parse(values[0]),
                                    X1 = int.Parse(values[1]),
                                    X2 = int.Parse(values[2])
                                };
                            inputData.Add(value);
                        }
                    }
                }
                dataUploadStateLabel.Text = ImportSuccessfullState;
                return true;
            }
            catch (Exception ex)
            {
                dataUploadStateLabel.Text = ImportFailedState;
                return false;
            }
        }

        private void ProcessData()
        {
            float[,] corellationData = CorellationMatrixProcessor.FindCorrelationMatrix(inputData);
        }
    }
}