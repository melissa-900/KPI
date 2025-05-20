namespace KPIPractice2
{
    // IStorage<T> & ListStorage<T>
    // - Оголосіть interface IStorage<T>
    // {
    //  void Add(T);
    //  T Get(int);
    //  int Count;
    // }.
    // - Реалізуйте ListStorage<T> на базі List<T>.
    // - У Main додайте/отримайте елементи int, string тощо.
    public interface IStorage<T>
    {
        void Add(T item);
        T Get(int index);
        int Count { get; }
    }

    public class ListStorage<T> : IStorage<T>
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _items.Count)
                return default;
            //    throw new ArgumentOutOfRangeException(nameof(index));
            return _items[index];
        }

        public int Count => _items.Count;
    }

    public class Task4
    {
        public void Main()
        {
            IStorage<int> intStorage = new ListStorage<int>();
            intStorage.Add(3);
            intStorage.Add(11);
            Console.WriteLine($"{intStorage.Get(0)}, Count = {intStorage.Count}");

            IStorage<string> stringStorage = new ListStorage<string>();
            stringStorage.Add("lorem");
            stringStorage.Add("ipsum");
            Console.WriteLine($"{stringStorage.Get(1)}, Count = {stringStorage.Count}");
        }
    }
}