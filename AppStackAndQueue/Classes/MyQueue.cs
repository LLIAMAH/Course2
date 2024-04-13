namespace AppStackAndQueue.Classes
{
    public class MyQueue<T> : IMyQueue<T>
    {
        private MyQueueItem<T>? _startPoint;
        public IEnumerable<T> Items { get { return this.GetItems(); } }


        public MyQueue()
        {
            this._startPoint = null;
        }

        public void Push(T item)
        {
            if (this._startPoint == null)
            {
                this._startPoint = new MyQueueItem<T>(item);
            }
            else
            {
                if (!this._startPoint.HasNext)
                {
                    var newQueueItem = new MyQueueItem<T>(item);
                    this._startPoint.SetNext(newQueueItem);
                }
                else
                {
                    MyQueueItem<T>? lastItem = this._startPoint;
                    do
                    {
                        lastItem = lastItem.Next!;
                    } while (lastItem.HasNext);

                    var newQueueItem = new MyQueueItem<T>(item);
                    lastItem.SetNext(newQueueItem);
                }
            }
        }

        public T? Pop()
        {
            if (this._startPoint == null)
                return default(T);

            T? result = default(T);
            if (!this._startPoint.HasNext)
            {
                result = this._startPoint.ItemValue;
                this._startPoint = null;
                return result;
            }

            result = this._startPoint.ItemValue;
            var itemNext = this._startPoint.Next;
            this._startPoint = itemNext;
            return result;
        }

        private IEnumerable<T> GetItems()
        {
            if (this._startPoint == null)
                return Enumerable.Empty<T>();

            var result = new List<T>();
            var item = this._startPoint;
            result.Add(item.ItemValue);
            while (item.HasNext)
            {
                item = item.Next;
                result.Add(item.ItemValue);
            }

            return result;
        }

        public int Count()
        {
            return this.GetItems().Count();
        }
    }
}
