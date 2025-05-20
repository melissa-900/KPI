namespace KPIPractice2
{
    /// Box<T> — універсальний контейнер
    /// - Оголосіть клас Box<T>, який має поле чи властивість T Value.
    /// - Додайте метод void Display(), що виводить у консоль значення Value.
    /// - У методі Main продемонструйте роботу Box<int>, Box<string> та Box<Person>,
    /// де Person — ваш власний клас із полями Name і Age.

    public class Box<T>
    {
        public T Value { get; set; }

        public Box(T value)
        {
            Value = value;
        }

        public void Display()
        {
            Console.WriteLine(Value);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    public class Task1
    {
        public void Main()
        {
            var intBox = new Box<int>(42);
            intBox.Display();

            var stringBox = new Box<string>("Hello, World!");
            stringBox.Display();

            var personBox = new Box<Person>(new Person("Alice", 30));
            personBox.Display();
        }
    }
}
