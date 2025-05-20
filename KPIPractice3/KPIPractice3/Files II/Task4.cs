namespace KPIPractice3.Files_II
{
    /// <summary>
    /// Завдання 4: Додати набір рядків у кінець існуючого файла.
    /// Метод Execute приймає шлях до файлу та колекцію рядків.
    /// </summary>
    public class Task4
    {
        public void Execute(string path, IEnumerable<string> lines)
        {
            // TODO: реалізувати за допомогою StreamWriter(path, append: true)

            using (var writer = new StreamWriter(path, append: true))
            {
                foreach (var line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }

        public void Main()
        {
            // TODO: приклад додавання рядків у файл
            
            Console.Write("Enter file path: ");
            string path = Console.ReadLine();
            IEnumerable<string> lines = new List<string>
            {
                "First line",
                "Second line",
                "Third line"
            };
            Execute(path, lines);

            string text = File.ReadAllText(path);
            
            Console.WriteLine($"File '{path}' contains contents:\n{text}");
        }
    }
}
