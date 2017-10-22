using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private Graphics graph;

        private IList<InputDataDto> inputData;
        public MainForm()
        {
            InitializeComponent();
            inputData = new List<InputDataDto>();
            graph = regressionPictureBox.CreateGraphics();
            graph.Clear(Color.White);
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            bool isSuccessfull = TryUploadData();
            showDataButton.Visible = isSuccessfull;

            if (isSuccessfull)
            {
                ProcessData();
            }
            else
            {
                corellationDataGridView.Visible = false;
                corellationMatrixLabel.Visible = false;
                regressionPictureBox.Visible = false;
                regression_label.Visible = false;
                regressionPictureBox.Refresh();
            }
        }

        private void showDataButton_Click(object sender, EventArgs e)
        {
            using (DataGridForm grid = new DataGridForm(inputData))
            {
                grid.ShowDialog();
            }
        }
        private string GetParentDirectory(string path, int parentCount)
        {
            if (string.IsNullOrEmpty(path) || parentCount < 1)
            {
                return path;
            }
            string parent = System.IO.Path.GetDirectoryName(path);

            if (--parentCount > 0)
            {
                return GetParentDirectory(parent, parentCount);
            }

            return parent;
        }
        private bool TryUploadData()
        {
            openFileDialog.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = GetParentDirectory(Application.StartupPath, 2);
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
            UpdateCorellationGrid(corellationData);

            DrawRegressionGraphPoints(inputData.Select(x => x.Y).ToArray(), inputData.Select(x => x.X1).ToArray(), Color.Black);
        }

        private void UpdateCorellationGrid(float[,] corellationData)
        {
            corellationDataGridView.Columns.Clear();
            corellationDataGridView.Rows.Clear();
            
            corellationDataGridView.Columns.Add("Y", "Y");
            corellationDataGridView.Columns.Add("X1", "X1");
            corellationDataGridView.Columns.Add("X2", "X2");

            for (int i = 0; i < corellationData.GetLength(0); i++)
            {
                corellationDataGridView.Rows.Add();
                for (int j = 0; j < corellationData.GetLength(1); j++)
                {
                    corellationDataGridView.Rows[i].Cells[j].Value = corellationData[i, j];
                }
            }

            corellationDataGridView.Refresh();
            corellationDataGridView.Visible = true;
            corellationMatrixLabel.Visible = true;
        }

        private void DrawRegressionGraphPoints(float[] ys, float[] xs, Color color)
        {
            regressionPictureBox.Visible = true;
            regression_label.Visible = true;
            regressionPictureBox.Refresh();

            Font font = new Font("Arial", 7);
            Pen pen = new Pen(Color.Blue, 1);
            Brush brush = new SolidBrush(Color.Blue);
            Brush brush_points = new SolidBrush(color);
       
            pen.EndCap = LineCap.ArrowAnchor;

            graph.DrawLine(pen, new Point(2, regressionPictureBox.Size.Height - 2), new Point(regressionPictureBox.Size.Width, regressionPictureBox.Size.Height-2)); //Y line
            graph.DrawLine(pen, new Point(2,  regressionPictureBox.Size.Height - 2), new Point(2, 0)); //X line

            graph.DrawString("Y", font, brush, regressionPictureBox.Size.Width - 10, regressionPictureBox.Size.Height - 15);
            graph.DrawString("X", font, brush, 4,0);




            float divider = 2; //Zoom
            if (ys.Length != xs.Length)
            {
                return;
            }
            for (int i = 0; i < ys.Length; i++)
            {
                graph.FillRectangle(brush_points, ys[i]/divider, regressionPictureBox.Height -(xs[i]), 4, 4);
            }
            var regressionParams = RegressionProcessor.FitPoints(xs, ys);
            var b = regressionParams.Item1;
        }
    }
}