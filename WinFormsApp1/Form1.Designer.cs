﻿namespace WinFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            bnAdd = new Button();
            tbOperand1 = new TextBox();
            tbOperand2 = new TextBox();
            bnSubstract = new Button();
            bnMultiply = new Button();
            bnDivide = new Button();
            tbResult = new TextBox();
            lOnHoverMouseX = new Label();
            lOnHoverMouseY = new Label();
            lOnHoverMouseXForm = new Label();
            lOnHoverMouseYForm = new Label();
            button1 = new Button();
            tbUserName = new TextBox();
            lUserName = new Label();
            lPassword = new Label();
            tbPassword = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            meni1ToolStripMenuItem = new ToolStripMenuItem();
            menui2ToolStripMenuItem = new ToolStripMenuItem();
            menu3ToolStripMenuItem = new ToolStripMenuItem();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            bnNext = new Button();
            checkedListBox1 = new CheckedListBox();
            dateTimePicker1 = new DateTimePicker();
            monthCalendar1 = new MonthCalendar();
            numericUpDown1 = new NumericUpDown();
            richTextBox1 = new RichTextBox();
            radioButton5 = new RadioButton();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            test1ToolStripMenuItem = new ToolStripMenuItem();
            test2ToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            editConfigureToolStripMenuItem = new ToolStripMenuItem();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            textBox3 = new TextBox();
            bnShowModal = new Button();
            tbModalFormOutput = new TextBox();
            contextMenuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bnAdd
            // 
            bnAdd.Location = new Point(197, 155);
            bnAdd.Name = "bnAdd";
            bnAdd.Size = new Size(100, 100);
            bnAdd.TabIndex = 0;
            bnAdd.Text = "+";
            bnAdd.UseVisualStyleBackColor = true;
            bnAdd.Click += bnAdd_Click;
            // 
            // tbOperand1
            // 
            tbOperand1.Location = new Point(68, 175);
            tbOperand1.Name = "tbOperand1";
            tbOperand1.Size = new Size(152, 31);
            tbOperand1.TabIndex = 1;
            tbOperand1.Text = "sdfgsdfgsdfgsdf";
            // 
            // tbOperand2
            // 
            tbOperand2.Location = new Point(12, 49);
            tbOperand2.Name = "tbOperand2";
            tbOperand2.Size = new Size(152, 31);
            tbOperand2.TabIndex = 2;
            // 
            // bnSubstract
            // 
            bnSubstract.Location = new Point(594, 196);
            bnSubstract.Name = "bnSubstract";
            bnSubstract.Size = new Size(93, 68);
            bnSubstract.TabIndex = 3;
            bnSubstract.Text = "-";
            bnSubstract.UseVisualStyleBackColor = true;
            bnSubstract.Click += bnSubstract_Click;
            // 
            // bnMultiply
            // 
            bnMultiply.Location = new Point(437, 117);
            bnMultiply.Name = "bnMultiply";
            bnMultiply.Size = new Size(93, 68);
            bnMultiply.TabIndex = 4;
            bnMultiply.Text = "*";
            bnMultiply.UseVisualStyleBackColor = true;
            bnMultiply.Click += bnMultiply_Click;
            // 
            // bnDivide
            // 
            bnDivide.Location = new Point(572, 96);
            bnDivide.Name = "bnDivide";
            bnDivide.Size = new Size(93, 68);
            bnDivide.TabIndex = 5;
            bnDivide.Text = "/";
            bnDivide.UseVisualStyleBackColor = true;
            bnDivide.Click += bnDivide_Click;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(12, 86);
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.Size = new Size(251, 31);
            tbResult.TabIndex = 6;
            // 
            // lOnHoverMouseX
            // 
            lOnHoverMouseX.AutoSize = true;
            lOnHoverMouseX.Location = new Point(12, 143);
            lOnHoverMouseX.Name = "lOnHoverMouseX";
            lOnHoverMouseX.Size = new Size(59, 25);
            lOnHoverMouseX.TabIndex = 7;
            lOnHoverMouseX.Text = "label1";
            // 
            // lOnHoverMouseY
            // 
            lOnHoverMouseY.AutoSize = true;
            lOnHoverMouseY.Location = new Point(12, 168);
            lOnHoverMouseY.Name = "lOnHoverMouseY";
            lOnHoverMouseY.Size = new Size(59, 25);
            lOnHoverMouseY.TabIndex = 8;
            lOnHoverMouseY.Text = "label2";
            // 
            // lOnHoverMouseXForm
            // 
            lOnHoverMouseXForm.AutoSize = true;
            lOnHoverMouseXForm.Location = new Point(12, 193);
            lOnHoverMouseXForm.Name = "lOnHoverMouseXForm";
            lOnHoverMouseXForm.Size = new Size(59, 25);
            lOnHoverMouseXForm.TabIndex = 9;
            lOnHoverMouseXForm.Text = "label3";
            // 
            // lOnHoverMouseYForm
            // 
            lOnHoverMouseYForm.AutoSize = true;
            lOnHoverMouseYForm.Location = new Point(12, 218);
            lOnHoverMouseYForm.Name = "lOnHoverMouseYForm";
            lOnHoverMouseYForm.Size = new Size(59, 25);
            lOnHoverMouseYForm.TabIndex = 10;
            lOnHoverMouseYForm.Text = "label4";
            // 
            // button1
            // 
            button1.Location = new Point(327, 107);
            button1.Name = "button1";
            button1.Size = new Size(203, 136);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(1567, 49);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(410, 31);
            tbUserName.TabIndex = 12;
            tbUserName.TextChanged += textBox1_TextChanged;
            // 
            // lUserName
            // 
            lUserName.AutoSize = true;
            lUserName.Location = new Point(630, 351);
            lUserName.Name = "lUserName";
            lUserName.Size = new Size(100, 25);
            lUserName.TabIndex = 13;
            lUserName.Text = "User name:";
            // 
            // lPassword
            // 
            lPassword.AutoSize = true;
            lPassword.Location = new Point(630, 415);
            lPassword.Name = "lPassword";
            lPassword.Size = new Size(87, 25);
            lPassword.TabIndex = 15;
            lPassword.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.ContextMenuStrip = contextMenuStrip1;
            tbPassword.Location = new Point(6, 36);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(412, 31);
            tbPassword.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { meni1ToolStripMenuItem, menui2ToolStripMenuItem, menu3ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(149, 100);
            // 
            // meni1ToolStripMenuItem
            // 
            meni1ToolStripMenuItem.Name = "meni1ToolStripMenuItem";
            meni1ToolStripMenuItem.Size = new Size(148, 32);
            meni1ToolStripMenuItem.Text = "Meni 1";
            // 
            // menui2ToolStripMenuItem
            // 
            menui2ToolStripMenuItem.Name = "menui2ToolStripMenuItem";
            menui2ToolStripMenuItem.Size = new Size(148, 32);
            menui2ToolStripMenuItem.Text = "Menui 2";
            // 
            // menu3ToolStripMenuItem
            // 
            menu3ToolStripMenuItem.Name = "menu3ToolStripMenuItem";
            menu3ToolStripMenuItem.Size = new Size(148, 32);
            menu3ToolStripMenuItem.Text = "Menu 3";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Indeterminate;
            checkBox1.Location = new Point(1200, 82);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(1200, 117);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(121, 29);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(tbPassword);
            groupBox1.Location = new Point(1017, 328);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 160);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Имя, фамилиЁ отчество";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(412, 31);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(412, 31);
            textBox1.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton4);
            panel1.Location = new Point(1634, 384);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 221);
            panel1.TabIndex = 23;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(114, 116);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(141, 29);
            radioButton3.TabIndex = 23;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(112, 75);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(141, 29);
            radioButton4.TabIndex = 22;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // bnNext
            // 
            bnNext.Location = new Point(1201, 163);
            bnNext.Name = "bnNext";
            bnNext.Size = new Size(182, 55);
            bnNext.TabIndex = 24;
            bnNext.Text = "Next";
            bnNext.UseVisualStyleBackColor = true;
            bnNext.Click += bnNext_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(572, 510);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(445, 228);
            checkedListBox1.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(310, 310);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 26;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(726, 31);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 27;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            monthCalendar1.KeyDown += monthCalendar1_KeyDown;
            monthCalendar1.MouseDown += monthCalendar1_MouseDown;
            monthCalendar1.MouseUp += monthCalendar1_MouseUp;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown1.Location = new Point(1348, 49);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(132, 31);
            numericUpDown1.TabIndex = 28;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(31, 371);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(499, 325);
            richTextBox1.TabIndex = 29;
            richTextBox1.Text = "";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(1266, 271);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(141, 29);
            radioButton5.TabIndex = 30;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2108, 33);
            menuStrip1.TabIndex = 31;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, toolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(158, 34);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { test1ToolStripMenuItem, test2ToolStripMenuItem });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(158, 34);
            openToolStripMenuItem.Text = "Open";
            // 
            // test1ToolStripMenuItem
            // 
            test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            test1ToolStripMenuItem.Size = new Size(154, 34);
            test1ToolStripMenuItem.Text = "Test1";
            test1ToolStripMenuItem.Click += test1ToolStripMenuItem_Click;
            // 
            // test2ToolStripMenuItem
            // 
            test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            test2ToolStripMenuItem.Size = new Size(154, 34);
            test2ToolStripMenuItem.Text = "Test2";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(158, 34);
            saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(155, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editConfigureToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // editConfigureToolStripMenuItem
            // 
            editConfigureToolStripMenuItem.Name = "editConfigureToolStripMenuItem";
            editConfigureToolStripMenuItem.Size = new Size(246, 34);
            editConfigureToolStripMenuItem.Text = "Edit && Configure";
            // 
            // comboBox1
            // 
            comboBox1.DataSource = checkedListBox1.CustomTabOffsets;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1574, 166);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(408, 33);
            comboBox1.TabIndex = 32;
            // 
            // button2
            // 
            button2.Location = new Point(1096, 494);
            button2.Name = "button2";
            button2.Size = new Size(225, 97);
            button2.TabIndex = 33;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1496, 633);
            button3.Name = "button3";
            button3.Size = new Size(283, 114);
            button3.TabIndex = 34;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1803, 653);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(226, 31);
            textBox3.TabIndex = 35;
            // 
            // bnShowModal
            // 
            bnShowModal.Location = new Point(1111, 667);
            bnShowModal.Name = "bnShowModal";
            bnShowModal.Size = new Size(197, 73);
            bnShowModal.TabIndex = 36;
            bnShowModal.Text = "Show modal form";
            bnShowModal.UseVisualStyleBackColor = true;
            bnShowModal.Click += bnShowModal_Click;
            // 
            // tbModalFormOutput
            // 
            tbModalFormOutput.Location = new Point(1064, 746);
            tbModalFormOutput.Name = "tbModalFormOutput";
            tbModalFormOutput.ReadOnly = true;
            tbModalFormOutput.Size = new Size(304, 31);
            tbModalFormOutput.TabIndex = 37;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2108, 827);
            Controls.Add(tbModalFormOutput);
            Controls.Add(bnShowModal);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(radioButton5);
            Controls.Add(richTextBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(monthCalendar1);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkedListBox1);
            Controls.Add(bnNext);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(lPassword);
            Controls.Add(lUserName);
            Controls.Add(tbUserName);
            Controls.Add(button1);
            Controls.Add(lOnHoverMouseYForm);
            Controls.Add(lOnHoverMouseXForm);
            Controls.Add(lOnHoverMouseY);
            Controls.Add(lOnHoverMouseX);
            Controls.Add(tbResult);
            Controls.Add(bnDivide);
            Controls.Add(bnMultiply);
            Controls.Add(bnSubstract);
            Controls.Add(tbOperand2);
            Controls.Add(tbOperand1);
            Controls.Add(bnAdd);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bnAdd;
        private TextBox tbOperand1;
        private TextBox tbOperand2;
        private Button bnSubstract;
        private Button bnMultiply;
        private Button bnDivide;
        private TextBox tbResult;
        private Label lOnHoverMouseX;
        private Label lOnHoverMouseY;
        private Label lOnHoverMouseXForm;
        private Label lOnHoverMouseYForm;
        private Button button1;
        private TextBox tbUserName;
        private Label lUserName;
        private Label lPassword;
        private TextBox tbPassword;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private GroupBox groupBox1;
        private Panel panel1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button bnNext;
        private CheckedListBox checkedListBox1;
        private DateTimePicker dateTimePicker1;
        private MonthCalendar monthCalendar1;
        private NumericUpDown numericUpDown1;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private RadioButton radioButton5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem test1ToolStripMenuItem;
        private ToolStripMenuItem test2ToolStripMenuItem;
        private ToolStripMenuItem editConfigureToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem meni1ToolStripMenuItem;
        private ToolStripMenuItem menui2ToolStripMenuItem;
        private ToolStripMenuItem menu3ToolStripMenuItem;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private TextBox textBox3;
        private Button bnShowModal;
        private TextBox tbModalFormOutput;
    }
}