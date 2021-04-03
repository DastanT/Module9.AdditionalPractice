using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.AdditionalPractice
{
    public class Book:Product
    {
        public override string Category { get; set; } = "Книги";
        public string Autor { get; set; }

        public void InitBook(int size, List<Book> books)
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                Book book = new Book();
                book.Name = string.Format("{0}", rnd.Next(1, 100000));
                book.Autor = string.Format("{0}", rnd.Next(1, 10000));
                book.Price = rnd.Next(500, 100000);
                book.Manufacturer = string.Format("{0}", rnd.Next(1, 1000));
                book.Age = (uint)rnd.Next(1, 18);
                books.Add(book);
            }
        }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Категория: " + Category);
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Автор: " + Autor);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Издательство: " + Manufacturer);
            Console.WriteLine("Возраст: " + Age);
            Console.ResetColor();
        }
    }
}
