using WorkWithFiles.Interfaces;

namespace WorkWithFiles.Forms
{
    public partial class FGetData : Form, IGetData
    {
        public FGetData()
        {
            InitializeComponent();
        }

        public string GetData()
        {
            return textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.No;
            }
        }
    }
}
