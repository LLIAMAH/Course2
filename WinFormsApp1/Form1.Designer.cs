namespace WinFormsApp1
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
            bnAdd = new Button();
            tbOperand1 = new TextBox();
            tbOperand2 = new TextBox();
            bnSubstract = new Button();
            bnMultiply = new Button();
            bnDivide = new Button();
            tbResult = new TextBox();
            SuspendLayout();
            // 
            // bnAdd
            // 
            bnAdd.Location = new Point(170, 12);
            bnAdd.Name = "bnAdd";
            bnAdd.Size = new Size(93, 68);
            bnAdd.TabIndex = 0;
            bnAdd.Text = "+";
            bnAdd.UseVisualStyleBackColor = true;
            bnAdd.Click += bnAdd_Click;
            // 
            // tbOperand1
            // 
            tbOperand1.Location = new Point(12, 12);
            tbOperand1.Name = "tbOperand1";
            tbOperand1.Size = new Size(152, 31);
            tbOperand1.TabIndex = 1;
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
            bnSubstract.Location = new Point(269, 12);
            bnSubstract.Name = "bnSubstract";
            bnSubstract.Size = new Size(93, 68);
            bnSubstract.TabIndex = 3;
            bnSubstract.Text = "-";
            bnSubstract.UseVisualStyleBackColor = true;
            bnSubstract.Click += bnSubstract_Click;
            // 
            // bnMultiply
            // 
            bnMultiply.Location = new Point(368, 12);
            bnMultiply.Name = "bnMultiply";
            bnMultiply.Size = new Size(93, 68);
            bnMultiply.TabIndex = 4;
            bnMultiply.Text = "*";
            bnMultiply.UseVisualStyleBackColor = true;
            bnMultiply.Click += bnMultiply_Click;
            // 
            // bnDivide
            // 
            bnDivide.Location = new Point(467, 12);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 209);
            Controls.Add(tbResult);
            Controls.Add(bnDivide);
            Controls.Add(bnMultiply);
            Controls.Add(bnSubstract);
            Controls.Add(tbOperand2);
            Controls.Add(tbOperand1);
            Controls.Add(bnAdd);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Some super form";
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
    }
}