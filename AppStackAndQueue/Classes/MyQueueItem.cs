namespace AppStackAndQueue.Classes
{
    public class MyQueueItem<T>
    {
        private readonly T _item;
        private MyQueueItem<T>? _nextItemRef;
        public T ItemValue { get { return this._item; } }

        public MyQueueItem(T item)
        {
            this._item = item;
        }

        public bool HasNext { get { return this._nextItemRef != null; } }

        public MyQueueItem<T>? Next { get { return this._nextItemRef; } }

        public void SetNext(MyQueueItem<T> element)
        {
            this._nextItemRef = element;
        }

    }
}
