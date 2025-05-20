namespace KPIPractice2___
{
    // Власні IProducer<out T> та IConsumer<in T>
    // - Оголосіть IProducer<out T> { T Produce(); } та IConsumer<in T> { void Consume(T); }.
    // - Реалізуйте NovaPoshtaProducer : IProducer<NovaPoshta>, DeliveryCenterConsumer : IConsumer<DeliveryCenter>.
    // - Покажіть присвоєння IProducer<NovaPoshta> → IProducer<DeliveryCenter> і IConsumer<DeliveryCenter> → IConsumer<NovaPoshta>.
    public class DeliveryCenter
    {
        public string Name { get; set; }
    }

    public class NovaPoshta : DeliveryCenter
    {
        public int WarehouseNumber { get; set; }
    }

    public interface IProducer<out T>
    {
        T Produce();
    }

    public interface IConsumer<in T>
    {
        void Consume(T item);
    }

    public class NovaPoshtaProducer : IProducer<NovaPoshta>
    {
        public NovaPoshta Produce()
        {
            return new NovaPoshta { Name = "Kyiv", WarehouseNumber = 7 };
        }
    }

    public class DeliveryCenterConsumer : IConsumer<DeliveryCenter>
    {
        public void Consume(DeliveryCenter item)
        {
            Console.WriteLine($"Received package at: {item.Name}");
        }
    }

    public class Task10
    {
        public void Main()
        {
            IProducer<NovaPoshta> npProducer = new NovaPoshtaProducer();
            IProducer<DeliveryCenter> dcProducer = npProducer;

            DeliveryCenter produced = dcProducer.Produce();
            Console.WriteLine($"Produced: {produced.Name}");

            IConsumer<DeliveryCenter> dcConsumer = new DeliveryCenterConsumer();
            IConsumer<NovaPoshta> npConsumer = dcConsumer;

            npConsumer.Consume(new NovaPoshta { Name = "Lviv", WarehouseNumber = 12 });
        }
    }
}
