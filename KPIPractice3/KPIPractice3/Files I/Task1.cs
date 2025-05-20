namespace KPIPractice3.Files_I
{
    /// <summary>
    /// Завдання 1: Перевірити, чи існує файл за вказаним шляхом.
    /// Метод Execute повертає true, якщо файл існує.
    /// </summary>
    public class Task1
    {
        public bool Execute(string path)
        {
            // TODO: реалізувати за допомогою File.Exists
            return File.Exists(path);
        }

        public void Main()
        {
            // TODO: приклад виклику Execute та виведення результату
            Console.Write("Enter file path: ");
            string path = Console.ReadLine();
            bool exists = Execute(path);
            if (exists)
            {
                Console.WriteLine("File exists.");
            }
            else
            {
                Console.WriteLine("File doesn't exist.");
            }
        }
    }
}
