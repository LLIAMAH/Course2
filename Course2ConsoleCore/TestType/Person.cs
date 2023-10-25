namespace Course2ConsoleCore.TestType
{
    public partial class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public override bool Equals(object? obj)
        {
            var converted = obj as Person;
            if(converted == null) return false;

            return this.Name == converted.Name 
                   && this.Surname == converted.Surname;
        }

        public override string ToString()
        {
            //"Course2ConsoleCore.TestType.Person"
            return $"Name: {this.Name}, Surname: {this.Surname}";
        }
    }

    public partial class Person
    {
        public DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public int EyesCount { get; set; }
    }

    public static class PersonStringExt
    {
        public static string StringPerson(this string template, Person person)
        {
            return string.Format (template, person.Name, person.Surname, person.BirthDate, person.Height);
        }

        public static string ToStringFormatted(this double input)
        {
            return input.ToString("###.000");
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
