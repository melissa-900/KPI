namespace KPIPractice2
{
    // Pair<TKey, TValue> — пара «Key–Value»
    // - Створіть generic-клас Pair<TKey, TValue> з полями Key, Value.
    // - Реалізуйте конструктор та ToString() → "[Key:…, Value:…]".
    // - У Main продемонструйте Pair<int,string> та Pair<Guid,DateTime>.
    public class Pair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public override string ToString()
        {
            return $"[Key: {Key}, Value: {Value}]";
        }
    }

    public class Task3
    {
        public void Main()
        {
            var pair1 = new Pair<int, string>(1, "one");
            Console.WriteLine(pair1);

            var pair2 = new Pair<Guid, DateTime>(Guid.NewGuid(), DateTime.Now);
            Console.WriteLine(pair2);
        }
    }
}
