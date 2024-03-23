namespace WinFormsApp1.Forms
{
    partial class FSomeData
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
            label1 = new Label();
            label2 = new Label();
            tbTitle = new TextBox();
            cbGenre = new ComboBox();
            bnOK = new Button();
            bnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "Genre";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(77, 16);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(323, 31);
            tbTitle.TabIndex = 2;
            // 
            // cbGenre
            // 
            cbGenre.FormattingEnabled = true;
            cbGenre.Items.AddRange(new object[] { "Action", "Fantasy", "Historical roman", "SciFiction" });
            cbGenre.Location = new Point(77, 59);
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(323, 33);
            cbGenre.TabIndex = 3;
            // 
            // bnOK
            // 
            bnOK.Location = new Point(144, 98);
            bnOK.Name = "bnOK";
            bnOK.Size = new Size(125, 34);
            bnOK.TabIndex = 4;
            bnOK.Text = "OK";
            bnOK.UseVisualStyleBackColor = true;
            bnOK.Click += bnOK_Click;
            // 
            // bnCancel
            // 
            bnCancel.Location = new Point(275, 98);
            bnCancel.Name = "bnCancel";
            bnCancel.Size = new Size(125, 34);
            bnCancel.TabIndex = 5;
            bnCancel.Text = "Cancel";
            bnCancel.UseVisualStyleBackColor = true;
            bnCancel.Click += bnCancel_Click;
            // 
            // FSomeData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 145);
            Controls.Add(bnCancel);
            Controls.Add(bnOK);
            Controls.Add(cbGenre);
            Controls.Add(tbTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FSomeData";
            Text = "Add something";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbTitle;
        private ComboBox cbGenre;
        private Button bnOK;
        private Button bnCancel;
    }
}