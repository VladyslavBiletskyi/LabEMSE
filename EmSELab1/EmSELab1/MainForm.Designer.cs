namespace EmSELab1
{
    partial class MainForm
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
            this.uploadButton = new System.Windows.Forms.Button();
            this.dataUploadStateLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.showDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.corellationDataGridView = new System.Windows.Forms.DataGridView();
            this.corellationMatrixLabel = new System.Windows.Forms.Label();
            this.regressionPictureBox = new System.Windows.Forms.PictureBox();
            this.regression_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.corellationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regressionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(12, 12);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(131, 47);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.Text = "Upload data";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // dataUploadStateLabel
            // 
            this.dataUploadStateLabel.AutoSize = true;
            this.dataUploadStateLabel.Location = new System.Drawing.Point(164, 29);
            this.dataUploadStateLabel.Name = "dataUploadStateLabel";
            this.dataUploadStateLabel.Size = new System.Drawing.Size(0, 13);
            this.dataUploadStateLabel.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // showDataButton
            // 
            this.showDataButton.Location = new System.Drawing.Point(355, 12);
            this.showDataButton.Name = "showDataButton";
            this.showDataButton.Size = new System.Drawing.Size(131, 47);
            this.showDataButton.TabIndex = 0;
            this.showDataButton.Text = "Show data";
            this.showDataButton.UseVisualStyleBackColor = true;
            this.showDataButton.Visible = false;
            this.showDataButton.Click += new System.EventHandler(this.showDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // corellationDataGridView
            // 
            this.corellationDataGridView.AllowUserToAddRows = false;
            this.corellationDataGridView.AllowUserToDeleteRows = false;
            this.corellationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.corellationDataGridView.Location = new System.Drawing.Point(89, 80);
            this.corellationDataGridView.Name = "corellationDataGridView";
            this.corellationDataGridView.ReadOnly = true;
            this.corellationDataGridView.Size = new System.Drawing.Size(347, 97);
            this.corellationDataGridView.TabIndex = 2;
            this.corellationDataGridView.Visible = false;
            // 
            // corellationMatrixLabel
            // 
            this.corellationMatrixLabel.AutoSize = true;
            this.corellationMatrixLabel.Location = new System.Drawing.Point(236, 184);
            this.corellationMatrixLabel.Name = "corellationMatrixLabel";
            this.corellationMatrixLabel.Size = new System.Drawing.Size(86, 13);
            this.corellationMatrixLabel.TabIndex = 3;
            this.corellationMatrixLabel.Text = "Corellation matrix";
            this.corellationMatrixLabel.Visible = false;
            // 
            // regressionPictureBox
            // 
            this.regressionPictureBox.BackColor = System.Drawing.Color.White;
            this.regressionPictureBox.Location = new System.Drawing.Point(28, 213);
            this.regressionPictureBox.Name = "regressionPictureBox";
            this.regressionPictureBox.Size = new System.Drawing.Size(494, 202);
            this.regressionPictureBox.TabIndex = 4;
            this.regressionPictureBox.TabStop = false;
            this.regressionPictureBox.Visible = false;
            // 
            // regression_label
            // 
            this.regression_label.AutoSize = true;
            this.regression_label.Location = new System.Drawing.Point(220, 427);
            this.regression_label.Name = "regression_label";
            this.regression_label.Size = new System.Drawing.Size(117, 13);
            this.regression_label.TabIndex = 5;
            this.regression_label.Text = "Linear regression graph";
            this.regression_label.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 575);
            this.Controls.Add(this.regression_label);
            this.Controls.Add(this.regressionPictureBox);
            this.Controls.Add(this.corellationMatrixLabel);
            this.Controls.Add(this.corellationDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showDataButton);
            this.Controls.Add(this.dataUploadStateLabel);
            this.Controls.Add(this.uploadButton);
            this.Name = "MainForm";
            this.Text = "EMSELab1";
            ((System.ComponentModel.ISupportInitialize)(this.corellationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regressionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label dataUploadStateLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button showDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView corellationDataGridView;
        private System.Windows.Forms.Label corellationMatrixLabel;
        private System.Windows.Forms.PictureBox regressionPictureBox;
        private System.Windows.Forms.Label regression_label;
    }
}

