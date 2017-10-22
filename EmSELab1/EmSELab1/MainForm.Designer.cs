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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showDataButton);
            this.Controls.Add(this.dataUploadStateLabel);
            this.Controls.Add(this.uploadButton);
            this.Name = "MainForm";
            this.Text = "EMSELab1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label dataUploadStateLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button showDataButton;
        private System.Windows.Forms.Label label1;
    }
}

