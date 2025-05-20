namespace KPIPractice3.Files_II
{
    /// <summary>
    /// Завдання 6: Рекурсивно вивести дерево каталогів і файлів з відступами.
    /// Метод Execute приймає кореневий шлях та рівень відступу.
    /// </summary>
    public class Task6
    {
        public void Execute(string rootPath, int indent = 0)
        {
            // TODO: скористатися Directory.GetDirectories/GetFiles та рекурсією
            
            Directory.GetDirectories(rootPath).ToList().ForEach(dir =>
            {
                if (indent > 0)
                {
                    for (int i = 1; i < indent; i++)
                    {
                        Console.Write($"{new string('|', 1)}{new string(' ', 3)}");
                    }
                    Console.WriteLine($"{new string('|', 1)}{new string('-', 3)}{Path.GetFileName(dir)}");
                }
                else
                {
                    Console.WriteLine($"{Path.GetFileName(dir)}");
                }
                Execute(dir, indent + 1);
            });
        }

        public void Main()
        {
            // TODO: приклад виводу структури поточної директорії

            Console.Write("Enter root path: ");
            string rootPath = Console.ReadLine();

            if (Directory.Exists(rootPath))
            {
                Console.WriteLine($"Directory '{rootPath}':");
                Execute(rootPath);
            }
            else
            {
                Console.WriteLine("Directory doesn't exist.");
            }
        }
    }
}
