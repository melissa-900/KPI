namespace KPIPractice2____
{
    // Делегати Func<out TResult> та Action<in T>
    // - Метод TResult ExecuteFunc<TResult>(Func<TResult> func).
    // - Метод void ExecuteAction<T>(Action<T> action, T arg).
    // - Перевірте варіантність на прикладі UkrPoshta → DeliveryCenter.
    public class DeliveryCenter
    {
        public string Name { get; set; }
    }

    public class UkrPoshta : DeliveryCenter
    {
        public int RegionCode { get; set; }
    }

    public class Task11
    {
        public TResult ExecuteFunc<TResult>(Func<TResult> func)
        {
            return func();
        }

        public void ExecuteAction<T>(Action<T> action, T arg)
        {
            action(arg);
        }

        public void Main()
        {
            Func<UkrPoshta> createUkrPoshta = () =>
                new UkrPoshta { Name = "Poltava", RegionCode = 12 };

            DeliveryCenter result = ExecuteFunc<DeliveryCenter>(createUkrPoshta);
            Console.WriteLine($"Created delivery center: {result.Name}");

            Action<DeliveryCenter> printInfo = center =>
                Console.WriteLine($"Package received by: {center.Name}");

            UkrPoshta up = new UkrPoshta { Name = "Odesa", RegionCode = 51 };

            ExecuteAction<UkrPoshta>(printInfo, up);
        }
    }
}
