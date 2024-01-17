using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace InfoBindingApp
{
    public partial class FMain : Form
    {
        private static string[] names = new[]
            { "Vasiliy", "Bogdan", "Anastacia", "Oleg", "Ivan", "Nicolay", "Olga", "Varvara", "Tets" };

        private static string[] surnames = new[]
            { "Ivanov", "Petrov", "Sidorov", "Sologub", "Mikul", "Krasnov", "Orehov", "Tormoz", "Volkov" };

        private readonly Random _rand;
        private readonly BindingList<Person> _list;

        public FMain()
        {
            InitializeComponent();
            this._rand = new Random();
            this._list = new BindingList<Person>();

            lbData.DataSource = this._list;
            dgvData.DataSource = this._list;
        }

        private string GenRandName()
        {
            return names[this._rand.Next(names.Length)];
        }

        private string GenRandSurname()
        {
            return surnames[this._rand.Next(surnames.Length)];
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            var person = new Person()
            {
                Name = this.GenRandName(),
                Surname = this.GenRandSurname()
            };

            this._list.Add(person);
        }

        private void bnUpdate_Click(object sender, EventArgs e)
        {
            var selected = lbData.SelectedItem as Person;
            var oldName = selected.Name;
            string newName;
            do
            {
                newName = this.GenRandName();
            } while (oldName == newName);
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            var selected = lbData.SelectedItem as Person;
            this._list.Remove(selected);
        }
    }

    public class Person : INotifyPropertyChanged
    {
        private string _name;
        private string _surname;

        public string Name
        {
            get => this._name;
            set
            {
                this._name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Surname
        {
            get
            {
                return this._surname;
            }
            set
            {
                this._surname = value;
                OnPropertyChanged(nameof(Surname));
            }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Surname}";
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion
    }
}
