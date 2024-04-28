using System;
using System.Collections.Generic;
using System.IO;

namespace InventoryManagementSystem
{
    class Program
    {
        static List<Product> inventory = new List<Product>();
        static int lastId = 0;


        static void Main(string[] args)
        {
            LoadInventoryFromFile();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nСистема менеджмента инвентаря");
                Console.WriteLine("1. Добавить продукт");
                Console.WriteLine("2. Удалить продукт");
                Console.WriteLine("3. Обновить продукт");
                Console.WriteLine("4. Найти продукт");
                Console.WriteLine("5. Посмотреть инвентарь");
                Console.WriteLine("6. Сохранить инвентарь в файл");
                Console.WriteLine("7. Загрузить инвентарь с файла");
                Console.WriteLine("8. Выйти");
                Console.Write("Введите ваш выбор: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddProduct();
                            break;
                        case 2:
                            RemoveProduct();
                            break;
                        case 3:
                            UpdateProduct();
                            break;
                        case 4:
                            SearchProducts();
                            break;
                        case 5:
                            ViewInventory();
                            break;
                        case 6:
                            SaveInventoryToFile();
                            break;
                        case 7:
                            inventory.Clear();
                            LoadInventoryFromFile();
                            break;
                        case 8:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Ошибка, неправильный выбор");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Неправильный ввод, попробуйте еще раз.");
                }
            }

            SaveInventoryToFile();
        }

        static void AddProduct()
        {
            Console.Write("Введите имя продукта: ");
            string name = Console.ReadLine();

            Console.Write("Введите категорию продукта: ");
            string category = Console.ReadLine();

            Console.Write("Введите цену продукта: ");
            decimal price = decimal.Parse(Console.ReadLine());

            int newId = ++lastId;
            Product newProduct = new Product(newId, name, category, price);
            inventory.Add(newProduct);
            Console.WriteLine($"Продукт с ID {newId} успешно добавлен.");
        }

        static void RemoveProduct()
        {
            Console.Write("Введите ID или имя продукта: ");
            string input = Console.ReadLine();

            Product productToRemove = inventory.Find(p => p.Id.ToString() == input || p.Name.ToLower() == input.ToLower());
            if (productToRemove != null)
            {
                inventory.Remove(productToRemove);
                Console.WriteLine("Продукт удален.");
            }
            else
            {
                Console.WriteLine("Продукт не найден");
            }
        }

        static void UpdateProduct()
        {
            Console.Write("Введите ID или имя продукта: ");
            string input = Console.ReadLine();

            Product productToUpdate = inventory.Find(p => p.Id.ToString() == input || p.Name.ToLower() == input.ToLower());
            if (productToUpdate != null)
            {
                Console.Write("Введите новое имя продукта (или оставьте имя пустым чтобы сохранить текущее имя продукта): ");
                string newName = Console.ReadLine();
                if (!string.IsNullOrEmpty(newName))
                {
                    productToUpdate.Name = newName;
                }

                Console.Write("Введите новую категорию продукта (или оставьте имя пустым чтобы сохранить текущую категорию продукта): ");
                string newCategory = Console.ReadLine();
                if (!string.IsNullOrEmpty(newCategory))
                {
                    productToUpdate.Category = newCategory;
                }

                Console.Write("Введите новую цену продукта (или оставьте имя пустым чтобы сохранить текущую цену продукта): ");
                string newPriceInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(newPriceInput))
                {
                    decimal newPrice = decimal.Parse(newPriceInput);
                    productToUpdate.Price = newPrice;
                }

                Console.WriteLine("Продукт обновлен.");
            }
            else
            {
                Console.WriteLine("Продукт не найден.");
            }
        }

        static void SearchProducts()
        {
            Console.Write("Введите критерию поиска (ID, имя, категгория,цена): ");
            string criteria = Console.ReadLine().ToLower();

            List<Product> searchResults = new List<Product>();


            int id;
            if (int.TryParse(criteria, out id))
            {

                searchResults = inventory.Where(p => p.Id == id).ToList();
            }
            else
            {

                searchResults = inventory.Where(p =>
                    p.Name.ToLower().Contains(criteria) ||
                    p.Category.ToLower().Contains(criteria) ||
                    p.Price.ToString().Contains(criteria)).ToList();
            }

            if (searchResults.Count > 0)
            {
                Console.WriteLine("\nРезультат поиска:");
                foreach (Product product in searchResults)
                {
                    Console.WriteLine($"ID: {product.Id}, Имя: {product.Name}, Категория: {product.Category}, Цена: {product.Price}");
                }
            }
            else
            {
                Console.WriteLine("Нет продуктов по такой крите.");
            }
        }

        static void ViewInventory()
        {
            if (inventory.Count > 0)
            {
                Console.WriteLine("\nИвентарь:");
                foreach (Product product in inventory)
                {
                    Console.WriteLine($"ID: {product.Id}, Имя: {product.Name}, Категория: {product.Category}, Цена: {product.Price}");
                }
            }
            else
            {
                Console.WriteLine("Инвентарь пуст.");
            }
        }

        static void LoadInventoryFromFile()
        {
            string filePath = "inventory.txt";
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 4)
                        {
                            int id = int.Parse(parts[0]);
                            string name = parts[1];
                            string category = parts[2];
                            decimal price = decimal.Parse(parts[3]);
                            Product product = new Product(id, name, category, price);
                            inventory.Add(product);
                            lastId = Math.Max(lastId, id);
                        }
                    }
                }
                Console.WriteLine("Инвентарь загружен с файла.");
            }
            else
            {
                Console.WriteLine("Не найдено файла с инвентарем. Создается новый файл инвентаря.");
            }
        }
        static void SaveInventoryToFile()
        {
            string filePath = "inventory.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Product product in inventory)
                {
                    writer.WriteLine($"{product.Id},{product.Name},{product.Category},{product.Price}");
                }
            }
            Console.WriteLine("Инвентарь сохранен в файл.");
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, string category, decimal price)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
        }
    }
}