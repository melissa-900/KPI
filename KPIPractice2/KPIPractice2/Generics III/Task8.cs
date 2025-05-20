namespace KPIPractice2_
{
    // Коваріантність IEnumerable<out T>
    // - Створіть DeliveryCenter, NovaPoshta:DeliveryCenter.
    // - Поясніть, чому IEnumerable<NovaPoshta> → IEnumerable<DeliveryCenter> працює.
    public class DeliveryCenter
    {
        public string Name { get; set; }
    }

    public class NovaPoshta : DeliveryCenter
    {
        public int WarehouseNumber { get; set; }
    }

    public class Task8
    {
        public void Main()
        {
            IEnumerable<NovaPoshta> novaList = new List<NovaPoshta>
            {
                new NovaPoshta { Name = "Kyiv", WarehouseNumber = 1 },
                new NovaPoshta { Name = "Lviv", WarehouseNumber = 2 }
            };

            IEnumerable<DeliveryCenter> centers = novaList;

            foreach (var center in centers)
            {
                Console.WriteLine($"DeliveryCenter: {center.Name}");
            }
        }
    }
}
