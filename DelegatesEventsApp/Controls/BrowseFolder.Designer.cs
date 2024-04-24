namespace DelegatesEventsApp.Controls
{
    partial class BrowseFolder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tvBooks = new TreeView();
            bnBrowse = new Button();
            tbFolderPath = new TextBox();
            fbdBrowse = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // tvBooks
            // 
            tvBooks.Location = new Point(3, 40);
            tvBooks.Name = "tvBooks";
            tvBooks.Size = new Size(536, 484);
            tvBooks.TabIndex = 5;
            // 
            // bnBrowse
            // 
            bnBrowse.Location = new Point(427, 0);
            bnBrowse.Name = "bnBrowse";
            bnBrowse.Size = new Size(112, 34);
            bnBrowse.TabIndex = 4;
            bnBrowse.Text = "Browse";
            bnBrowse.UseVisualStyleBackColor = true;
            bnBrowse.Click += bnBrowse_Click;
            // 
            // tbFolderPath
            // 
            tbFolderPath.Location = new Point(3, 3);
            tbFolderPath.Name = "tbFolderPath";
            tbFolderPath.ReadOnly = true;
            tbFolderPath.Size = new Size(418, 31);
            tbFolderPath.TabIndex = 3;
            // 
            // BrowseFolder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tvBooks);
            Controls.Add(bnBrowse);
            Controls.Add(tbFolderPath);
            MaximumSize = new Size(544, 529);
            MinimumSize = new Size(544, 529);
            Name = "BrowseFolder";
            Size = new Size(544, 529);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView tvBooks;
        private Button bnBrowse;
        private TextBox tbFolderPath;
        private FolderBrowserDialog fbdBrowse;
    }
}
