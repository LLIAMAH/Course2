namespace DelegatesEventsApp.Classes
{
    public delegate void StepIncrement();
    public delegate void Finished(IList<DataItem> list);

    public class DataProcessor
    {
        public StepIncrement? OnStepIncrement;
        public Finished? OnFinished;

        public void ProcessData(IList<DataItem> list)
        {
            foreach (var item in list)
            {
                item.Calculation = item.Age < 30
                    ? Random.Shared.Next(0, 50)
                    : Random.Shared.Next(50, 100);
                this.OnStepIncrement?.Invoke();
                Thread.Sleep(2000);
            }

            this.OnFinished?.Invoke(list);
        }
    }
}
