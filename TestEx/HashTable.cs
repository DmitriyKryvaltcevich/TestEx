
namespace TestEx
{
    public class cell : HashTable
    {
        public string Key { get; private set; }
        public string Value { get; private set; }
        
        public cell(string key, string value)
        {
            if (Valid(key, value)) return;
            Key = key;
            Value = value;
        }

        public void Val(string Val)
        {
            Value = Val;
        }
    }
    
    public class HashTable
    {

        private readonly byte _maxSize = 255;
        private Dictionary<int, List<cell>> _cells;
        public IReadOnlyCollection<KeyValuePair<int, List<cell>>>? cells => _cells?.ToList()?.AsReadOnly();

        public HashTable()
        {
            _cells = new Dictionary<int, List<cell>>(_maxSize);
        }

        int HashGet(string key)
        {
            int hashcode = 0;
            foreach(char c in key)
            {
                hashcode += c;
            }
            return hashcode;    
        }
        protected bool Valid(string key, string value, int hash = 0, bool noCheckVal = false)
        {
            if (string.IsNullOrEmpty(key))
            {
                Console.WriteLine("Введите ФИО!");
                return true;
            }
            if (key.Length > _maxSize)
            {
                Console.WriteLine("Превышена максимальная длина ФИО.");
                return true;
            }

            if (!noCheckVal && string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Введите номер телефона.");
                return true;
            }
            if (hash != 0 && !_cells.ContainsKey(hash)) 
            {
                Console.WriteLine("Пользователь не найден.");
                return true;
            }
            return false;
        }

        public void Insert(string key, string value)
        {
            cell cell = new cell(key, value);
            int hash = HashGet(cell.Key);
            if (Valid(key, value)) return;
            
            if (_cells.ContainsKey(hash))
            {
                if (_cells[hash].SingleOrDefault(i => i.Key == cell.Key && i.Value == cell.Value) != null)
                {
                    Console.WriteLine("Контакт с таким номером уже существует.");
                    return;
                }
                _cells[hash].Add(cell);
            }
            else
            {
                List<cell> hashTablecell = new List<cell> { cell };
                _cells.Add(hash, hashTablecell);
            }
        }
        
        public void Delete(string key)
        {
            int hash = HashGet(key);
            if (Valid(key, "", hash, true)) return;

            cell? cell = _cells[hash].SingleOrDefault(i => i.Key == key);

            if (cell != null)
            {
                _cells[hash].Remove(cell);
            }
        }

        public void Edit(string key,string value)
        {
            int hash = HashGet(key);
            if (Valid(key, value, hash)) return;

            if (_cells[hash] != null)
            {
                cell? cell = _cells[hash].SingleOrDefault(i => i.Key == key);
                if (cell != null)
                {
                    cell.Val(value);
                }
            }
        }
        public void Search(string key)
        {
            int hash = HashGet(key);
            if (Valid(key, "", hash, true)) return;

            if (_cells[hash] != null)
            {
                cell? cell = _cells[hash].SingleOrDefault(i => i.Key == key);
                if (cell != null)
                {
                    Console.WriteLine($"Номер телефона:{cell.Value}");
                }
            }
        }

        public void ShowContscts(HashTable hashTable, string title = "Контакты:")
        {
            Console.WriteLine($"\r\n{title}");
            foreach (var item in hashTable.cells)
            {
                foreach (var value in item.Value)
                {
                    Console.WriteLine($"{value.Key} - {value.Value}");
                }
            }
            Console.WriteLine();
        }
    }
}
