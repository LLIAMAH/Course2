namespace InfoBindingApp
{
    partial class FMain
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
            lbData = new ListBox();
            bnAdd = new Button();
            bnUpdate = new Button();
            bnDelete = new Button();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // lbData
            // 
            lbData.FormattingEnabled = true;
            lbData.ItemHeight = 25;
            lbData.Location = new Point(12, 12);
            lbData.Name = "lbData";
            lbData.Size = new Size(422, 654);
            lbData.TabIndex = 0;
            // 
            // bnAdd
            // 
            bnAdd.Location = new Point(440, 12);
            bnAdd.Name = "bnAdd";
            bnAdd.Size = new Size(112, 34);
            bnAdd.TabIndex = 1;
            bnAdd.Text = "Add";
            bnAdd.UseVisualStyleBackColor = true;
            bnAdd.Click += bnAdd_Click;
            // 
            // bnUpdate
            // 
            bnUpdate.Location = new Point(440, 52);
            bnUpdate.Name = "bnUpdate";
            bnUpdate.Size = new Size(112, 34);
            bnUpdate.TabIndex = 2;
            bnUpdate.Text = "Update";
            bnUpdate.UseVisualStyleBackColor = true;
            bnUpdate.Click += bnUpdate_Click;
            // 
            // bnDelete
            // 
            bnDelete.Location = new Point(440, 92);
            bnDelete.Name = "bnDelete";
            bnDelete.Size = new Size(112, 34);
            bnDelete.TabIndex = 3;
            bnDelete.Text = "Delete";
            bnDelete.UseVisualStyleBackColor = true;
            bnDelete.Click += bnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(556, 208);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(1211, 502);
            dgvData.TabIndex = 4;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2017, 881);
            Controls.Add(dgvData);
            Controls.Add(bnDelete);
            Controls.Add(bnUpdate);
            Controls.Add(bnAdd);
            Controls.Add(lbData);
            Name = "FMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbData;
        private Button bnAdd;
        private Button bnUpdate;
        private Button bnDelete;
        private DataGridView dgvData;
    }
}
