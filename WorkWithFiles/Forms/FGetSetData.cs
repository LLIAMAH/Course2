using WorkWithFiles.Interfaces;

namespace WorkWithFiles.Forms
{
    public partial class FGetSetData : Form, IGetSetData
    {
        public FGetSetData()
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
        }

        public void SetData(string data)
        {
            if(string.IsNullOrEmpty(data))
                return;

            textBox1.Text = data;
        }
    }
}
