namespace KPIPractice3.Files_II
{
    /// <summary>
    /// Завдання 5: Зчитати всі рядки з файлу, відсортувати за довжиною і повернути список.
    /// </summary>
    public class Task5
    {
        public List<string> Execute(string path)
        {
            // TODO: зчитати через StreamReader.ReadLine(), сортувати list.OrderBy(x => x.Length)

            List<string> lines = new List<string>();

            var reader = new StreamReader(path);

            while (reader.EndOfStream == false)
            {
                lines.Add(reader.ReadLine());
            }

            lines = lines.OrderBy(x => x.Length).ToList();
            return lines;
        }

        public void Main()
        {
            // TODO: демонстрація відсортованих рядків

            Console.Write("Enter file path: ");
            string path = Console.ReadLine();
            List<string> sortedLines = Execute(path);

            Console.WriteLine("Sorted lines by length:");
            foreach (var line in sortedLines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
