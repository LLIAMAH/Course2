namespace WorkWithFiles
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
            bnOldWrite = new Button();
            bnOldRead = new Button();
            bnReadBinary = new Button();
            bnWriteBinary = new Button();
            lbResultBinary = new ListBox();
            lbResultXml = new ListBox();
            bnReadXml = new Button();
            bnWriteXml = new Button();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // bnOldWrite
            // 
            bnOldWrite.Location = new Point(12, 12);
            bnOldWrite.Name = "bnOldWrite";
            bnOldWrite.Size = new Size(204, 67);
            bnOldWrite.TabIndex = 0;
            bnOldWrite.Text = "Old Write";
            bnOldWrite.UseVisualStyleBackColor = true;
            bnOldWrite.Click += bnOldWrite_Click;
            // 
            // bnOldRead
            // 
            bnOldRead.Location = new Point(12, 85);
            bnOldRead.Name = "bnOldRead";
            bnOldRead.Size = new Size(204, 67);
            bnOldRead.TabIndex = 1;
            bnOldRead.Text = "Old Read";
            bnOldRead.UseVisualStyleBackColor = true;
            bnOldRead.Click += bnOldRead_Click;
            // 
            // bnReadBinary
            // 
            bnReadBinary.Location = new Point(285, 85);
            bnReadBinary.Name = "bnReadBinary";
            bnReadBinary.Size = new Size(204, 67);
            bnReadBinary.TabIndex = 3;
            bnReadBinary.Text = "Read (binary)";
            bnReadBinary.UseVisualStyleBackColor = true;
            bnReadBinary.Click += bnReadBinary_Click;
            // 
            // bnWriteBinary
            // 
            bnWriteBinary.Location = new Point(285, 12);
            bnWriteBinary.Name = "bnWriteBinary";
            bnWriteBinary.Size = new Size(204, 67);
            bnWriteBinary.TabIndex = 2;
            bnWriteBinary.Text = "Write (binary)";
            bnWriteBinary.UseVisualStyleBackColor = true;
            bnWriteBinary.Click += bnWriteBinary_Click;
            // 
            // lbResultBinary
            // 
            lbResultBinary.FormattingEnabled = true;
            lbResultBinary.ItemHeight = 25;
            lbResultBinary.Location = new Point(211, 158);
            lbResultBinary.Name = "lbResultBinary";
            lbResultBinary.Size = new Size(386, 279);
            lbResultBinary.TabIndex = 4;
            // 
            // lbResultXml
            // 
            lbResultXml.FormattingEnabled = true;
            lbResultXml.ItemHeight = 25;
            lbResultXml.Location = new Point(603, 158);
            lbResultXml.Name = "lbResultXml";
            lbResultXml.Size = new Size(386, 279);
            lbResultXml.TabIndex = 7;
            lbResultXml.SelectedIndexChanged += lbResultXml_SelectedIndexChanged;
            // 
            // bnReadXml
            // 
            bnReadXml.Location = new Point(677, 85);
            bnReadXml.Name = "bnReadXml";
            bnReadXml.Size = new Size(204, 67);
            bnReadXml.TabIndex = 6;
            bnReadXml.Text = "Read (XML)";
            bnReadXml.UseVisualStyleBackColor = true;
            bnReadXml.Click += bnReadXml_Click;
            // 
            // bnWriteXml
            // 
            bnWriteXml.Location = new Point(677, 12);
            bnWriteXml.Name = "bnWriteXml";
            bnWriteXml.Size = new Size(204, 67);
            bnWriteXml.TabIndex = 5;
            bnWriteXml.Text = "Write (XML)";
            bnWriteXml.UseVisualStyleBackColor = true;
            bnWriteXml.Click += bnWriteXml_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1142, 51);
            button1.Name = "button1";
            button1.Size = new Size(196, 141);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1142, 198);
            button2.Name = "button2";
            button2.Size = new Size(196, 141);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 464);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(365, 31);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(35, 520);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(366, 31);
            textBox2.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(977, 492);
            button3.Name = "button3";
            button3.Size = new Size(178, 104);
            button3.TabIndex = 12;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Test 1", "Test 2", "Test 3" });
            listBox1.Location = new Point(577, 460);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(330, 179);
            listBox1.TabIndex = 13;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1387, 679);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbResultXml);
            Controls.Add(bnReadXml);
            Controls.Add(bnWriteXml);
            Controls.Add(lbResultBinary);
            Controls.Add(bnReadBinary);
            Controls.Add(bnWriteBinary);
            Controls.Add(bnOldRead);
            Controls.Add(bnOldWrite);
            Name = "FMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bnOldWrite;
        private Button bnOldRead;
        private Button bnReadBinary;
        private Button bnWriteBinary;
        private ListBox lbResultBinary;
        private ListBox lbResultXml;
        private Button bnReadXml;
        private Button bnWriteXml;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button3;
        private ListBox listBox1;
    }
}
