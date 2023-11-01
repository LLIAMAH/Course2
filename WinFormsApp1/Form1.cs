namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            var operand1String = tbOperand1.Text;
            var operand2String = tbOperand2.Text;

            var operand1 = Convert.ToDouble(operand1String);
            var operand2 = Convert.ToDouble(operand2String);

            var result = operand1 + operand2;

            tbResult.Text = result.ToString();
        }

        private void bnSubstract_Click(object sender, EventArgs e)
        {

        }

        private void bnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void bnDivide_Click(object sender, EventArgs e)
        {

        }
    }
}