using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UserLib;



namespace Module9.AdditionalPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            List<Toy> toys = new List<Toy>();
            List<Book> books = new List<Book>();
            List<SportEquipment> sportEquipments = new List<SportEquipment>();

            Toy toyObject = new Toy();
            Book bookObject = new Book();
            SportEquipment sportEquip = new SportEquipment();

            User user = new User();
            int size = 4; //количестов позиций

            do
            {
                user.UserMenuTaskOne();
                switch (user.UserChoice())
                {
                    case 1:
                        Console.Clear();
                        toyObject.InitToy(size, toys);
                        user.Loading();
                        user.HeaderColor("Игрушки");
                        foreach (Toy toy in toys)
                        {
                            toy.Show();
                        }
                        products.AddRange(toys);
                        break;
                    case 2:
                        Console.Clear();
                        bookObject.InitBook(size, books);
                        user.Loading();
                        user.HeaderColor("Книги");
                        foreach (Book book in books)
                        {
                            book.Show();
                        }
                        products.AddRange(books);
                        break;
                    case 3:
                        Console.Clear();
                        sportEquip.InitSportInvent(size, sportEquipments);
                        user.Loading();
                        user.HeaderColor("Спортивный инвентарь");
                        foreach (SportEquipment sportEqp in sportEquipments)
                        {
                            sportEqp.Show();
                        }
                        products.AddRange(sportEquipments);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Весь ассортимент: ");
                        if (products.Count == 0)
                        {
                            Console.WriteLine("Список пуст");
                        }
                        else
                        {
                            foreach (Product prod in products)
                            {
                                prod.Show();
                            }
                        }
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("Введите категорию товара для поиска: ");
                        string userInput = Console.ReadLine();
                        string message = "";
                        if (userInput != "")
                        {
                            foreach (Product prod in products)
                            {
                                if (prod.Category.ToLower().Contains(userInput))
                                {
                                    prod.Show();
                                }
                            }                     
                        }
                        else
                        {
                            Console.WriteLine("Вы ничего не ввели");
                        }
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (true);

        }


    }
}
