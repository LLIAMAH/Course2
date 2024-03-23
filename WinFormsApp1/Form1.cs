using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int _test;
        private BindingList<string> _list;

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
            var form = new DependendForm();
            form.ShowDialog();
            ////form.Show();

            //var dateTime = DateTime.Now;
            //dateTimePicker1.Value = dateTime;

            //numericUpDown1.Value = 120;
            //var t = Convert.ToInt32(numericUpDown1.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            //radioButton1.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Indeterminate)
                bnNext.Enabled = false;

            //this._list = GetData();

            //comboBox1.DataSource = this._list;
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

        private void efitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu item clicked.");
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
        }

        private void monthCalendar1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void monthCalendar1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void monthCalendar1_MouseDown(object sender, MouseEventArgs e)
        {
            var mc = sender as MonthCalendar;
            if (mc == null)
                return;

            if (e.Button == MouseButtons.Right)
            {
                var position = mc.PointToClient(Cursor.Position);

                if (mc.SelectionStart.Date == mc.TodayDate.Date)
                    contextMenuStrip1.Show(mc, position);
            }
        }

        private Stack<Person> stack = null;
        private Queue<Person> queue = null;

        private void button2_Click(object sender, EventArgs e)
        {
            if (stack == null)
                stack = new Stack<Person>();

            if (queue == null)
                queue = new Queue<Person>();

            var person1 = new Person() { Name = "Vasiliy", Surname = "H", BirthDate = new DateTime(1982, 10, 25) };
            var person2 = new Person() { Name = "Anastacia", Surname = "S", BirthDate = new DateTime(2000, 2, 7) };
            var person3 = new Person() { Name = "Bogdan", Surname = "Y", BirthDate = new DateTime(2004, 8, 27) };

            stack.Push(person1);
            stack.Push(person2);
            stack.Push(person3);

            queue.Enqueue(person1);
            queue.Enqueue(person2);
            queue.Enqueue(person3);

            var peekedPersonStack1 = stack.Peek();
            var peekedPersonQueue1 = queue.Peek();

            var takenStack = stack.Pop();
            var takenQueue = queue.Dequeue();

            // 0          // 1        // 2
            var a = new string[] { "Vasiliy", "Anastacia", "Bogdan" };
            var keyValue = new KeyValuePair<string, Person>(person1.Name, person1);

            //var list = new List<Person>();
            //list.Add(person1);
            //list.Add(person2);
            //list.Add(person3);
            //var person = list[1];

            //var list = new List<KeyValuePair<string, Person>>();
            //list.Add(new KeyValuePair<string, Person>(person1.Name, person1));
            //list.Add(new KeyValuePair<string, Person>(person2.Name, person2));
            //list.Add(new KeyValuePair<string, Person>(person3.Name, person3));

            //var person = list.First(o => o.Key == "Vasiliy").Value;

            var dictionary = new Dictionary<string, Person>();
            dictionary.Add(person1.Name, person1);
            dictionary.Add(person2.Name, person2);
            dictionary.Add(person3.Name, person3);

            //var person = dictionary["Anastacia"];
            // dictionary.Add("Anastacia", new Person(){}); <== Exception - ключ с таким значением уже есть и мы добавляем ещё один 
            //dictionary["Anastacia"] = new Person() { };

            //dictionary["Anastacia2"] = new Person() { }; <= Exception - потому что ключ должен быть добавлен
            //dictionary.Add("Anastacia2", new Person(){});

            var list = new List<Person>();
            list.Add(person1);
            list.Add(person2);
            list.Add(person3);
            list.Add(new Person() { Name = "Oleg", Surname = "H", BirthDate = new DateTime(1950, 6, 12) });
            list.Add(new Person() { Name = "Anton", Surname = "H", BirthDate = new DateTime(1950, 6, 12) });
            list.Add(new Person() { Name = "Pyotr", Surname = "S", BirthDate = new DateTime(1950, 6, 12) });
            list.Add(new Person() { Name = "Anna", Surname = "S", BirthDate = new DateTime(1950, 6, 12) });
            list.Add(new Person() { Name = "Nickolay", Surname = "S", BirthDate = new DateTime(1950, 6, 12) });
            list.Add(new Person() { Name = "Ivan", Surname = "Y", BirthDate = new DateTime(1950, 6, 12) });
            list.Add(new Person() { Name = "Maria", Surname = "Y", BirthDate = new DateTime(1950, 6, 12) });

            //var report = new Dictionary<string, int>();
            //for (var i = 0; i < list.Count; i++)
            //{
            //    try
            //    {
            //        var counter = report[list[i].Surname];
            //        counter++;
            //        report[list[i].Surname] = counter;
            //    }
            //    catch
            //    {
            //        report.Add(list[i].Surname, 1);
            //    }
            //}

            var report = list.ToLookup(k => k.Surname, v => v);

            var countWithH = report["H"].Count();

            var ttt = report;

            var listChuncked = list.Chunk(3);

            foreach (var items in listChuncked)
            {

            }

            var t = 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var form = new ModalForm())
            {
                var result = form.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            textBox3.Text = form.SomeInfo.SomeData;
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            break;
                        }
                    case DialogResult.Retry:
                        {
                            MessageBox.Show("Хреново пытаешься!");
                            break;
                        }
                }
            }
        }

        private void bnShowModal_Click(object sender, EventArgs e)
        {
            using (var form = new FSomeData())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var data = form.GetData();
                    tbModalFormOutput.Text = $"{data.Title} ({data.Genre})";
                }
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Surname} {this.BirthDate:dd/MM/yyyy}";
        }
    }
}