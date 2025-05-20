namespace KPIPractice2
{
    // Generic-репозиторій
    // - Реалізуйте class Repository<TEntity, TKey> where TEntity : IEntity<TKey>:
    //     void Add(TEntity);
    //     TEntity Find(TKey);
    //     IEnumerable<TEntity> GetAll().
    public interface IEntity<TKey>
    {
        TKey Id { get; }
    }

    public class User : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Repository<TEntity, TKey> where TEntity : IEntity<TKey>
    {
        private readonly Dictionary<TKey, TEntity> _storage = new();

        public void Add(TEntity entity)
        {
            _storage[entity.Id] = entity;
        }

        public TEntity Find(TKey key)
        {
            return _storage.TryGetValue(key, out var entity) ? entity : default;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _storage.Values;
        }
    }

    public class Task12
    {
        public void Main()
        {
            var userRepo = new Repository<User, int>();

            userRepo.Add(new User { Id = 1, Name = "Alice" });
            userRepo.Add(new User { Id = 2, Name = "Bob" });

            var found = userRepo.Find(1);
            Console.WriteLine($"Found user: {found?.Name}");

            Console.WriteLine("All users:");
            foreach (var user in userRepo.GetAll())
            {
                Console.WriteLine($"- {user.Name}");
            }
        }
    }
}
