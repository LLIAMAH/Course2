using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class DependendForm : Form
    {
        private BindingList<string> _list;

        public DependendForm()
        {
            InitializeComponent();
            this._list = new BindingList<string>()
            {
                "Test 1",
                "Test 2",
                "Test 3",
                "Test 4",
                "Test 5",
                "Test 6",
                "Test 7",
                "Test 8",
                "Test 9",
                "Test 10",
            };

            lbList.DataSource = this._list;
            listBox1.DataSource = this._list;
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            if(!IsValid(tbItem))
                return;

            this._list.Add(tbItem.Text);
            tbItem.Text = string.Empty;
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = lbList.SelectedItem as string;
            if (selectedItem != null)
            {
                this._list.Remove(selectedItem);
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            //lbList.Items.Add()
            //lbList.Items.Remove()
        }

        public bool IsValid(TextBox textBox)
        {
            var input = textBox.Text;
            if (string.IsNullOrEmpty(input))
            {
                errorProvider1.SetError(textBox, "Input is empty.");
                return false;
            }
            else
            {
                errorProvider1.SetError(textBox, null);
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValid(textBox1))
                return;

            // Работаем с введёнными данными

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!IsValid(textBox2))
                return;

            // Работаем с введёнными данными
        }
    }
}
