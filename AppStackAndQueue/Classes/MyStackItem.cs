namespace AppStackAndQueue.Classes
{
    public class MyStackItem
    {
        private readonly object _item;
        private MyStackItem? _deepItemRef;

        public bool HasDeep { get { return this._deepItemRef != null; } }
        public MyStackItem? DeepItem { get { return this._deepItemRef; } }
        public object ItemValue { get { return this._item; } }

        public MyStackItem(object item)
        {
            this._item = item;
            this._deepItemRef = null;
        }

        public MyStackItem(object item, MyStackItem deepItem) : this(item)
        {
            this._deepItemRef = deepItem;
        }
    }
}
