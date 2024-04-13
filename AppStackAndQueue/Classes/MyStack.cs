namespace AppStackAndQueue.Classes
{
    public class MyStack : IMyStack
    {
        private MyStackItem? _startPoint;

        public IEnumerable<object> Items { get { return this.GetItems(); } }

        public MyStack()
        {
            this._startPoint = null;
        }

        public void Push(object item)
        {
            if (this._startPoint == null)
            {
                this._startPoint = new MyStackItem(item);
            }
            else
            {
                var deepItem = this._startPoint;
                this._startPoint = new MyStackItem(item, deepItem);
            }
        }

        public object? Pop()
        {
            if (this._startPoint == null)
                return null;

            if (!this._startPoint.HasDeep)
            {
                var lastItem = _startPoint.ItemValue;
                this._startPoint = null;
                return lastItem;
            }

            var outputItem = this._startPoint.ItemValue;
            this._startPoint = this._startPoint.DeepItem;

            return outputItem;
        }

        private IEnumerable<object> GetItems()
        {
            if (this._startPoint == null)
                return Enumerable.Empty<object>();

            var result = new List<object>();
            var item = this._startPoint;
            result.Add(item);
            while (item.HasDeep)
            {
                item = item.DeepItem;
                result.Add(item.ItemValue);
            }

            return result;
        }
    }
}
