namespace KPIPractice3.Files_I
{
    /// <summary>
    /// Завдання 2: Створити новий текстовий файл та записати в нього вміст.
    /// Метод Execute приймає шлях до файлу та текст для запису.
    /// </summary>
    public class Task2
    {
        public void Execute(string path, string contents)
        {
            // TODO: реалізувати за допомогою File.WriteAllText
            File.WriteAllText(path, contents);
        }

        public void Main()
        {
            // TODO: приклад створення файлу та запису тексту

            Console.Write("Enter file name: ");
            string fileName = Console.ReadLine();
            Console.Write("Enter file contents: ");
            string contents = Console.ReadLine();

            File.Create(fileName).Close();
            Execute(fileName, contents);

            string text = File.ReadAllText(fileName);
            Console.WriteLine($"File '{fileName}' created with contents:\n{text}");
        }
    }
}