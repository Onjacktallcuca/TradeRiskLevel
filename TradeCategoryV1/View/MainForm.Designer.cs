namespace TradeCategory
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.importButton = new System.Windows.Forms.Button();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tradeDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RiskLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portfolioLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(17, 12);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(112, 34);
            this.importButton.TabIndex = 0;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(146, 12);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(112, 34);
            this.buttonProcess.TabIndex = 1;
            this.buttonProcess.Text = "Run output";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // tradeDataGridView
            // 
            this.tradeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tradeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Value,
            this.Sector,
            this.RiskLevel});
            this.tradeDataGridView.Location = new System.Drawing.Point(17, 100);
            this.tradeDataGridView.Name = "tradeDataGridView";
            this.tradeDataGridView.RowHeadersWidth = 62;
            this.tradeDataGridView.RowTemplate.Height = 33;
            this.tradeDataGridView.Size = new System.Drawing.Size(666, 375);
            this.tradeDataGridView.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 150;
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            dataGridViewCellStyle1.Format = "c";
            this.Value.DefaultCellStyle = dataGridViewCellStyle1;
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 8;
            this.Value.Name = "Value";
            this.Value.Width = 150;
            // 
            // Sector
            // 
            this.Sector.DataPropertyName = "Sector";
            this.Sector.HeaderText = "Sector";
            this.Sector.MinimumWidth = 8;
            this.Sector.Name = "Sector";
            this.Sector.Width = 150;
            // 
            // RiskLevel
            // 
            this.RiskLevel.DataPropertyName = "RiskLevel";
            this.RiskLevel.HeaderText = "RiskLevel";
            this.RiskLevel.MinimumWidth = 8;
            this.RiskLevel.Name = "RiskLevel";
            this.RiskLevel.Width = 150;
            // 
            // portfolioLabel
            // 
            this.portfolioLabel.AutoSize = true;
            this.portfolioLabel.Location = new System.Drawing.Point(17, 61);
            this.portfolioLabel.Name = "portfolioLabel";
            this.portfolioLabel.Size = new System.Drawing.Size(89, 25);
            this.portfolioLabel.TabIndex = 4;
            this.portfolioLabel.Text = "Portfolio: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 487);
            this.Controls.Add(this.portfolioLabel);
            this.Controls.Add(this.tradeDataGridView);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.importButton);
            this.Name = "MainForm";
            this.Text = "Risk Level";
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button importButton;
        private Button buttonProcess;
        private OpenFileDialog openFileDialog;
        private DataGridView tradeDataGridView;
        private Label portfolioLabel;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Value;
        private DataGridViewTextBoxColumn Sector;
        private DataGridViewTextBoxColumn RiskLevel;
        private SaveFileDialog saveFileDialog;
    }
}