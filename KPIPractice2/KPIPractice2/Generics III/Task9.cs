namespace KPIPractice2__
{
    //  Контраваріантність IComparer<in T>
    // - Реалізуйте DeliveryCenterComparer : IComparer<DeliveryCenter>.
    // - Покажіть, що IComparer<DeliveryCenter> можна присвоїти IComparer<NovaPoshta> і відсортувати NovaPoshta[].    
    public class DeliveryCenter
    {
        public string Name { get; set; }
    }

    public class NovaPoshta : DeliveryCenter
    {
        public int WarehouseNumber { get; set; }
    }

    public class DeliveryCenterComparer : IComparer<DeliveryCenter>
    {
        public int Compare(DeliveryCenter x, DeliveryCenter y)
        {
            return string.Compare(x?.Name, y?.Name, StringComparison.Ordinal);
        }
    }

    public class Task9
    {
        public void Main()
        {
            NovaPoshta[] novaArray =
            {
                new NovaPoshta { Name = "Lviv", WarehouseNumber = 2 },
                new NovaPoshta { Name = "Kyiv", WarehouseNumber = 1 },
                new NovaPoshta { Name = "Odesa", WarehouseNumber = 3 }
            };

            IComparer<NovaPoshta> comparer = new DeliveryCenterComparer();

            Array.Sort(novaArray, comparer);

            foreach (var np in novaArray)
            {
                Console.WriteLine($"{np.Name} (Warehouse #{np.WarehouseNumber})");
            }
        }
    }
}
