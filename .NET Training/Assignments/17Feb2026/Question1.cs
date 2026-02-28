using System.Collections;
namespace Question1
{
    public class MyCustomException : Exception
    {
        public MyCustomException() : base() { }
        public MyCustomException(string errMsg) : base(errMsg) { }
        public MyCustomException(string errMsg, Exception innerException) : base(errMsg, innerException) { }
    }
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var repo = new InventoryRepository<Item>();

            repo.ItemAdded += () =>
            {
                Console.WriteLine("Item added succesfully");
            };

            try
            {
                repo.Add(new ElectronicItem
                {
                    Id = 1,
                    Name = "Laptop",
                    Price = 75000,
                    WarrentyMonths = 24
                });

                repo.Add(new ElectronicItem
                {
                    Id = 2,
                    Name = "Headphones",
                    Price = 2500,
                    WarrentyMonths = 12
                });

                repo.Add(new GroceryItem
                {
                    Id = 3,
                    Name = "Milk",
                    Price = 60,
                    ExpiryDate = DateTime.Now.AddDays(5)
                });

                repo.Add(new GroceryItem
                {
                    Id = 4,
                    Name = "Olive Oil",
                    Price = 1200,
                    ExpiryDate = DateTime.Now.AddMonths(6)
                });
            }
            catch (MyCustomException e)
            {
                System.Console.WriteLine(e.Message);
            }

            var itemsMoreThan1000 = repo.GetAll().Where(i => i.Price > 1000).ToList();

            var groups = repo.GetAll().GroupBy(i => i.GetType().Name);

            foreach (var group in groups)
            {
                System.Console.WriteLine($"{group.Key}");

                foreach (var item in group)
                {
                    System.Console.WriteLine($"{item.Name}");
                }
            }

            var sorted = repo.GetAll();
            sorted.Sort();

            Console.WriteLine("\nSorted By Price:");
            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Name} - {item.Price}");
            }

            var top2 = repo.GetAll().OrderByDescending(i => i.Price).Take(2);

            Console.WriteLine("\nTop 2 Expensive:");
            foreach (var item in top2)
            {
                Console.WriteLine(item.Name);
            }

            var tasks = new List<Task<string>>
            {
                InventoryRepository.FetchDataAsync(),
                InventoryRepository.FetchDataAsync()
            };

            var done = await Task.WhenAll(tasks);
            

        }
    }

    [Serializable]
    public abstract class Item : IComparable<Item>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public abstract decimal CalculateDiscount();

        public virtual string GetDetails()
        {
            return $"{Id} {Name} {Price}";
        }

        public int CompareTo(Item other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }

    public class ElectronicItem : Item
    {
        public int WarrantyMonths { get; set; }
        public override decimal CalculateDiscount()
        {
            return this.Price * 0.9;
        }
    }

    public class GroceryItem : Item
    {
        public DateTime ExpiryDate { get; set; }

        public override decimal CalculateDiscount()
        {
            return this.Price * 0.95;
        }
    }

    public interface IRepository<T> where T : Item
    {
        public bool Add(T item);
        public bool Remove(int id);
        public bool Update(T item, int id);
        public T GetById(int id);
        public List<T> GetAll();
    }

    public class InventoryRepository<T> : IRepository<T>, IEnumerable<T> where T : Item
    {
        public event Action<T> ItemAdded;
        private Dictionary<int, T> _items;

        public IEnumerator<T> GetEnumerator()
        {
            return _items.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public InventoryRepository()
        {
            _items = new Dictionary<int, T>();
        }

        public bool Add(T item)
        {
            if (_items.ContainsKey(item.Id))
            {
                throw new MyCustomException("Item already exists with the same key");
            }
            _items.Add(item.Id, item);
            ItemAdded?.Invoke(item);
            return true;
        }

        public bool Remove(int id)
        {
            if (_items.ContainsKey(id))
            {
                _items.Remove(id);
                return true;
            }
            return false;
        }

        public bool Update(T item, int id)
        {
            if (!_items.ContainsKey(id))
            {
                throw new MyCustomException("Item does not exists.");
            }
            _items[id] = item;
            return true;
        }

        public T GetById(int id)
        {
            if (!_items.ContainsKey(id))
            {
                throw new MyCustomException("Item does not exists");
            }
            return _items[id];

        }

        public List<T> GetAll()
        {
            if (_items != null)
            {
                return _items.Values.ToList();
            }
            return new List<T>();
        }

        public static async Task<String> FetchDataAsync()
        {
            await Task.Delay(2000);
            return "Data Loaded";
        }
    }

    public class ItemComparer : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            return decimal.Compare(x.Price,y.Price);
        }
    }

    public static class ItemExtension
    {
        public static decimal GetTaxedPrice(this Item item,decimal taxRate)
        {
            return item.Price * (item.Price * taxRate);
        }
    }

    


}