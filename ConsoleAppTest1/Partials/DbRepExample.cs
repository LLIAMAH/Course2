using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest1.Partials
{
    public class Person
    {
        public long Id { get; set; }
    }

    public class Car
    {
        public long Id { get; set; }
    }

    public class DbConext
    {
        public IList<Person> Persons { get; }
        public IList<Car> Cars { get; }

        public DbConext()
        {
            this.Persons = new List<Person>();
            this.Cars = new List<Car>();
        }
    }

    public interface IRep<T>
    {
        void Create(T item);
        void Update(long id, T item);
        void Delete(T item);
        IList<T> Read();
    }

    public abstract class Rep<T> : IRep<T>
    {
        private readonly DbConext _ctx;

        protected Rep(DbConext ctx)
        {
            this._ctx = ctx;
        }

        public void Create(T item)
        {
            throw new NotImplementedException();
        }

        public void Update(long id, T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public IList<T> Read()
        {
            throw new NotImplementedException();
        }
    }

    public interface IRepPerson : IRep<Person> { }
    public interface IRepCar : IRep<Car> { }

    public class RepPerson : Rep<Person>, IRepPerson
    {
        public RepPerson(DbConext ctx) : base(ctx) { }
    }

    public class RepCar : Rep<Car>, IRepCar
    {
        public RepCar(DbConext ctx) : base(ctx) { }
    }
}
