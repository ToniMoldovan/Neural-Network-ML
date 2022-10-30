namespace Proiect_3
{
    partial class MainForm
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
            this.btnReadCSV = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNormalize = new System.Windows.Forms.Button();
            this.btnTrainingData = new System.Windows.Forms.Button();
            this.btnTestingData = new System.Windows.Forms.Button();
            this.btnTrainData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadCSV
            // 
            this.btnReadCSV.AutoSize = true;
            this.btnReadCSV.Location = new System.Drawing.Point(12, 67);
            this.btnReadCSV.Name = "btnReadCSV";
            this.btnReadCSV.Size = new System.Drawing.Size(188, 30);
            this.btnReadCSV.TabIndex = 0;
            this.btnReadCSV.Text = "Read From CSV";
            this.btnReadCSV.UseVisualStyleBackColor = true;
            this.btnReadCSV.Click += new System.EventHandler(this.btnReadCSV_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(206, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(1139, 490);
            this.dgv.TabIndex = 1;
            this.dgv.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 352);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status: ";
            this.lblStatus.Visible = false;
            // 
            // btnNormalize
            // 
            this.btnNormalize.AutoSize = true;
            this.btnNormalize.Enabled = false;
            this.btnNormalize.Location = new System.Drawing.Point(12, 122);
            this.btnNormalize.Name = "btnNormalize";
            this.btnNormalize.Size = new System.Drawing.Size(188, 30);
            this.btnNormalize.TabIndex = 3;
            this.btnNormalize.Text = "Normalize Data";
            this.btnNormalize.UseVisualStyleBackColor = true;
            this.btnNormalize.Click += new System.EventHandler(this.btnNormalize_Click);
            // 
            // btnTrainingData
            // 
            this.btnTrainingData.AutoSize = true;
            this.btnTrainingData.Enabled = false;
            this.btnTrainingData.Location = new System.Drawing.Point(12, 167);
            this.btnTrainingData.Name = "btnTrainingData";
            this.btnTrainingData.Size = new System.Drawing.Size(188, 30);
            this.btnTrainingData.TabIndex = 4;
            this.btnTrainingData.Text = "Training Data";
            this.btnTrainingData.UseVisualStyleBackColor = true;
            this.btnTrainingData.Click += new System.EventHandler(this.btnTrainingData_Click);
            // 
            // btnTestingData
            // 
            this.btnTestingData.AutoSize = true;
            this.btnTestingData.Enabled = false;
            this.btnTestingData.Location = new System.Drawing.Point(12, 213);
            this.btnTestingData.Name = "btnTestingData";
            this.btnTestingData.Size = new System.Drawing.Size(188, 30);
            this.btnTestingData.TabIndex = 5;
            this.btnTestingData.Text = "Testing Data";
            this.btnTestingData.UseVisualStyleBackColor = true;
            this.btnTestingData.Click += new System.EventHandler(this.btnTestingData_Click);
            // 
            // btnTrainData
            // 
            this.btnTrainData.AutoSize = true;
            this.btnTrainData.BackColor = System.Drawing.Color.White;
            this.btnTrainData.Enabled = false;
            this.btnTrainData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainData.ForeColor = System.Drawing.Color.Lime;
            this.btnTrainData.Location = new System.Drawing.Point(12, 287);
            this.btnTrainData.Name = "btnTrainData";
            this.btnTrainData.Size = new System.Drawing.Size(188, 30);
            this.btnTrainData.TabIndex = 6;
            this.btnTrainData.Text = "TRAIN DATA";
            this.btnTrainData.UseVisualStyleBackColor = false;
            this.btnTrainData.Click += new System.EventHandler(this.btnTrainData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1357, 514);
            this.Controls.Add(this.btnTrainData);
            this.Controls.Add(this.btnTestingData);
            this.Controls.Add(this.btnTrainingData);
            this.Controls.Add(this.btnNormalize);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnReadCSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadCSV;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnNormalize;
        private System.Windows.Forms.Button btnTrainingData;
        private System.Windows.Forms.Button btnTestingData;
        private System.Windows.Forms.Button btnTrainData;
    }
}

