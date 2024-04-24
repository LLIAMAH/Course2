namespace DelegatesEventsApp.Classes
{
    // DelegatesEventsApp.Classes.DataItem
    public class DataItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Calculation { get; set; }

        public override string ToString()
        {
            return $"First: {this.FirstName}, Last: {this.LastName}, Age: {this.Age}, Calcs: {this.Calculation}";
        }
    }
}
