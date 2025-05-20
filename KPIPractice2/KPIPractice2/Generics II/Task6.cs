namespace KPIPractice2
{
    // Factory<T> where T : class, new()
    // - Створіть class Factory<T> where T:class,new() { T Create(); }.
    // - Напишіть DeliveryCenter із public конструктором за замовчуванням.
    // - У Main: var f=new Factory<DeliveryCenter>(); DeliveryCenter p=f.Create();
    public class Task6
    {
        public void Main()
        {
            Factory<DeliveryCenter> factory = new Factory<DeliveryCenter>();

            DeliveryCenter delivery = factory.Create();

            delivery.Deliver();
        }


        public class DeliveryCenter
        {
            public DeliveryCenter()
            {
                Console.WriteLine("DeliveryCenter created");
            }

            public void Deliver()
            {
                Console.WriteLine("Delivering package...");
            }
        }
        public class Factory<T> where T : class, new()
        {
            public T Create()
            {
                return new T();
            }
        }
    }
}