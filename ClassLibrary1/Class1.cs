namespace ClassLibrary1
{
    public interface ICar: IHasSpeed, ISetAngle // объединение интерфейсов
    {

    }

    public interface IHasSpeed
    {
        int Speed { get; } // SET - does not exists - в ЭТОМ КОНТРАКТЕ Не существует
    }

    public class Plane : ISetAngle
    {
        public void SetAngle(int turnAngle)
        {
            //.....
        }
    }

    public interface ISetAngle
    {
        void SetAngle(int turnAngle);
    }


    public class CarBase : IHasSpeed
    {
        public int Speed { get; set; }
        public string Color1 { get; set; }
        public string Color2 { get; set; }
        public string Color3 { get; set; }
    }

    public class CarGame : CarBase, ISetAngle
    {
        private int _turnAngle;

        public string Contol { get; set; }

        public void TurnLeft()
        {

        }

        public void TurnRight()
        {

        }

        public void Accelerate()
        {

        }

        public void Break()
        {

        }

        
        public void SetAngle(int turnAngle)
        {
            this._turnAngle = turnAngle;
        }

        public override bool Equals(object? obj)
        {
            var converted = obj as IHasSpeed;
            if (converted == null)
                return false;

            return this.Speed == converted.Speed;
            //&& this.Color1 == converted.Color1
            //&& this.Color2 == converted.Color2
            //&& this.Color3 == converted.Color3;
        }
    }

    public class CarCadSystem : CarBase, IDisposable
    {
        public Corpus Body { get; set; }

        private IntPtr a;

        public CarCadSystem()
        {
            this.Body = new Corpus();
        }

        //~CarCadSystem()
        //{
        //    this.a = IntPtr.Zero;
        //}
        public void Dispose()
        {
            this.Body = null;
        }
    }

    // Магазин автомобилей
    public class CarSales : IHasSpeed
    {
        public double Price { get; set; }

        public int Speed { get; set; }
    }

    public class Corpus
    {
        public string FormID { get; set; }
        public string Metall { get; set; }
    }
}