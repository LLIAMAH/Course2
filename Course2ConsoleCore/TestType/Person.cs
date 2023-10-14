namespace Course2ConsoleCore.TestType
{
    public class Person
    {
        private int id;

        protected string SomeValue;

        public int Id
        {
            get
            {
                return id;
            }
            private set
            {
                if(value < 0)
                    return;

                id = value;
            }
        }

        public Person()
        {

        }

        public void SetId(string data)// <== "23141"
        {
            if (Int32.TryParse(data, out var dataConverted))
            {
                this.Id = dataConverted;
            }
        }
    }

    public class PersonChild : Person
    {
        public PersonChild()
        {
            
        }

        public void SetValue(string data)
        {
            //this.SomeValue = data;
            base.SomeValue = data;
        }
    }

    public class PersonChild2 : Person
    {
        private string SomeValue;
        public PersonChild2()
        {

        }

        public void SetValue2(string data)
        {
            this.SomeValue = data;
        }
    }

    public abstract class Insurance
    {
        public abstract string ToString();
    }

    public class InsuranceOCTA : Insurance
    {
        public string Owner;
        public string CarNumber;
        public override string ToString()
        {
            return $"Owner: {this.Owner}, Car number: {this.CarNumber}";
        }
    }

    public class InsuranceKASKO : Insurance
    {
        public string Owner { get; private set; }
        public string CarNumber { get; private set; }
        public string KaskoNr { get; private set; }

        public InsuranceKASKO() { }

        public InsuranceKASKO(string owner)
        {
            this.Owner = owner;
        }

        public InsuranceKASKO(string owner, string carNumber)
            :this(owner)
        {
            this.CarNumber = carNumber;
        }

        public InsuranceKASKO(string owner, string carNumber, string kaskoNr)
            : this(owner, carNumber)
        {
            this.KaskoNr = kaskoNr;
        }

        public void ChangeKaskoData(string kaskoNr)
        {
            this.KaskoNr = kaskoNr;
        }

        public void ChangeKaskoData(string kaskoNr, string carNumber)
        {
            this.KaskoNr = kaskoNr;
            this.CarNumber = carNumber;
        }

        public override string ToString()
        {
            return $"Owner: {this.Owner}, Car number: {this.CarNumber}, Kasko Nr: {this.KaskoNr}";
        }
    }

    public class InsuranceTravel : Insurance
    {
        public string Owner { get; set; }
        public string Beneficiar;
        public string Country;
        public override string ToString()
        {
            return $"Owner: {this.Owner}, Beneficiar: {this.Beneficiar}, Country: {this.Country}";
        }
    }

    public class InsuranceBuilding : Insurance
    {
        public string Owner;
        public string Address;
        public override string ToString()
        {
            return $"Owner: {this.Owner}, Address: {this.Address}";
        }
    }
}
