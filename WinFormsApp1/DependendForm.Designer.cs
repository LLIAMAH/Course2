namespace WinFormsApp1
{
    partial class DependendForm
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
            components = new System.ComponentModel.Container();
            lbList = new ListBox();
            tbItem = new TextBox();
            bnAdd = new Button();
            bnDelete = new Button();
            Load = new Button();
            errorProvider1 = new ErrorProvider(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbList
            // 
            lbList.FormattingEnabled = true;
            lbList.ItemHeight = 25;
            lbList.Location = new Point(12, 12);
            lbList.Name = "lbList";
            lbList.Size = new Size(666, 604);
            lbList.TabIndex = 0;
            // 
            // tbItem
            // 
            tbItem.Location = new Point(684, 12);
            tbItem.Name = "tbItem";
            tbItem.Size = new Size(255, 31);
            tbItem.TabIndex = 1;
            // 
            // bnAdd
            // 
            bnAdd.Location = new Point(684, 49);
            bnAdd.Name = "bnAdd";
            bnAdd.Size = new Size(112, 34);
            bnAdd.TabIndex = 2;
            bnAdd.Text = "Add";
            bnAdd.UseVisualStyleBackColor = true;
            bnAdd.Click += bnAdd_Click;
            // 
            // bnDelete
            // 
            bnDelete.Location = new Point(684, 89);
            bnDelete.Name = "bnDelete";
            bnDelete.Size = new Size(112, 34);
            bnDelete.TabIndex = 3;
            bnDelete.Text = "Delete";
            bnDelete.UseVisualStyleBackColor = true;
            bnDelete.Click += bnDelete_Click;
            // 
            // Load
            // 
            Load.Location = new Point(684, 237);
            Load.Name = "Load";
            Load.Size = new Size(136, 66);
            Load.TabIndex = 4;
            Load.Text = "Load Items";
            Load.UseVisualStyleBackColor = true;
            Load.Click += Load_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1009, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1270, 13);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 31);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(1038, 64);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1309, 55);
            button2.Name = "button2";
            button2.Size = new Size(137, 43);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(1058, 182);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(666, 604);
            listBox1.TabIndex = 9;
            // 
            // DependendForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1759, 846);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Load);
            Controls.Add(bnDelete);
            Controls.Add(bnAdd);
            Controls.Add(tbItem);
            Controls.Add(lbList);
            Name = "DependendForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DependendForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbList;
        private TextBox tbItem;
        private Button bnAdd;
        private Button bnDelete;
        private Button Load;
        private ErrorProvider errorProvider1;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBox1;
    }
}