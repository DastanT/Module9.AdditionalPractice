using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.AdditionalPractice
{
    public class Toy : Product
    {
        public override string Category { get; set; } = "Игрушки";
        public string Material { get; set; }
        public void InitToy(int size, List<Toy> toys)
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                Toy toy = new Toy();
                toy.Name = string.Format("{0}", rnd.Next(1, 100000));
                toy.Price = rnd.Next(500, 100000);
                toy.Manufacturer = string.Format("{0}", rnd.Next(1, 1000));
                toy.Material = string.Format("{0}", rnd.Next(1, 50));
                toy.Age = (uint)rnd.Next(0, 16);
                toys.Add(toy);
            }
        }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Категория: " + Category);
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Производитель: " + Manufacturer);
            Console.WriteLine("Материал: " + Material);
            Console.WriteLine("Возраст: " + Age);
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
