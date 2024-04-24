namespace DelegatesEventsApp
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
            bfSource = new Controls.BrowseFolder();
            bfDestination = new Controls.BrowseFolder();
            bnMoveTo = new Button();
            SuspendLayout();
            // 
            // bfSource
            // 
            bfSource.Location = new Point(12, 12);
            bfSource.MaximumSize = new Size(544, 529);
            bfSource.MinimumSize = new Size(544, 529);
            bfSource.Name = "bfSource";
            bfSource.Size = new Size(544, 529);
            bfSource.TabIndex = 0;
            // 
            // bfDestination
            // 
            bfDestination.Location = new Point(772, 12);
            bfDestination.MaximumSize = new Size(544, 529);
            bfDestination.MinimumSize = new Size(544, 529);
            bfDestination.Name = "bfDestination";
            bfDestination.Size = new Size(544, 529);
            bfDestination.TabIndex = 1;
            // 
            // bnMoveTo
            // 
            bnMoveTo.Location = new Point(597, 192);
            bnMoveTo.Name = "bnMoveTo";
            bnMoveTo.Size = new Size(131, 175);
            bnMoveTo.TabIndex = 2;
            bnMoveTo.Text = "==>";
            bnMoveTo.UseVisualStyleBackColor = true;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1523, 863);
            Controls.Add(bnMoveTo);
            Controls.Add(bfDestination);
            Controls.Add(bfSource);
            Name = "FMain";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Controls.BrowseFolder bfSource;
        private Controls.BrowseFolder bfDestination;
        private Button bnMoveTo;
    }
}
