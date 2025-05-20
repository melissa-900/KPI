using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPIPractice3.Files_I
{
    /// <summary>
    /// Завдання 3: Прочитати весь вміст текстового файлу.
    /// Метод Execute повертає вміст файлу як рядок.
    /// </summary>
    public class Task3
    {
        public string Execute(string path)
        {
            // TODO: реалізувати за допомогою File.ReadAllText
            return File.ReadAllText(path);
        }

        public void Main()
        {
            // TODO: приклад читання та виведення вмісту файлу

            Console.Write("Enter file path: ");
            string path = Console.ReadLine();
            string text = Execute(path);
            
            Console.WriteLine($"File \"{path}\" contains contents:\n{text}");
        }
    }
}
