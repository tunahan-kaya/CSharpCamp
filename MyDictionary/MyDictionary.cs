namespace MyDictionary
{
    class MyDictionary<T>
    {
        T[] items;
        public MyDictionary() //constractor
        {
            items= new T[0];
        }
        public void Add(T item)
        {
            T[] _tempItems = new T[items.Length + 1];
            for (int i = 0; i < _tempItems.Length; i++)
            {
                _tempItems[i]=items[i];
            }
            _tempItems[items.Length] = item;
            items = _tempItems;
        }
    }
}
