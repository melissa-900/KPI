namespace KPIPractice2
{
    //  SendPackage<T> where T : DeliveryCenter, IDelivery
    // - Оголосіть DeliveryCenter та IDelivery { void Deliver(); }.
    // - Реалізуйте NovaPoshta : DeliveryCenter, IDelivery.
    // - Метод void SendPackage<T>(T c) where T:DeliveryCenter,IDelivery { c.Deliver(); }.
    public interface IDelivery
    {
        void Deliver();
    }

    public class DeliveryCenter
    {
        public string Address { get; set; } = "Unknown";
    }

    public class NovaPoshta : DeliveryCenter, IDelivery
    {
        public void Deliver()
        {
            Console.WriteLine($"Delivering package to {Address}");
        }
    }

    public class UkrPoshta : DeliveryCenter, IDelivery
    {
        public void Deliver()
        {
            Console.WriteLine($"Delivering package to {Address}");
        }
    }

    public class Task7
    {
        public static void SendPackage<T>(T c) where T : DeliveryCenter, IDelivery
        {
            c.Deliver();
        }

        public void Main()
        {
            var novaPoshta = new NovaPoshta { Address = "Kyiv" };
            var ukrPoshta = new UkrPoshta { Address = "Lviv" };
            SendPackage(novaPoshta);
            SendPackage(ukrPoshta);
        }
    }
}
