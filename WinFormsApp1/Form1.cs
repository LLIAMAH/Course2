namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int _test;

        public Form1()
        {
            InitializeComponent();

            bnAdd.MouseMove += OnMouseMove;
            bnDivide.MouseMove += OnMouseMove;
            bnMultiply.MouseMove += OnMouseMove;
            bnSubstract.MouseMove += OnMouseMove;
            this.MouseMove += OnMouseMove;
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {

            this._test = 435;
            var operand1String = tbOperand1.Text;
            var operand2String = tbOperand2.Text;

            var operand1 = Convert.ToDouble(operand1String);
            var operand2 = Convert.ToDouble(operand2String);

            //var result = operand1 + operand2;
            var result = Sum(operand1, operand2);

            tbResult.Text = result.ToString();
        }

        private void bnAdd_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyCode == Keys.A)
            {

            }
        }

        private double Sum(double a, double b)
        {
            return a + b;
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

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            var t = sender as Button;

            if (t == null)
                return;

            lOnHoverMouseX.Text = $"On button position X: {e.X}";
            lOnHoverMouseY.Text = $"On button position Y: {e.Y}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tbOperand1.Text = "Some value";
            //var form = new DependendForm();
            //form.ShowDialog();
            ////form.Show();

            var dateTime = DateTime.Now;
            dateTimePicker1.Value = dateTime;

            numericUpDown1.Value = 120;
            var t = Convert.ToInt32(numericUpDown1.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            checkBox1.Checked = true;
            radioButton1.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Indeterminate)
                bnNext.Enabled = false;
        }

        private void bnNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы кликнули на кнопку");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Indeterminate)
                bnNext.Enabled = false;
            else
                bnNext.Enabled = true;
        }
    }
}