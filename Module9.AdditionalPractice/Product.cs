using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLib;

namespace Module9.AdditionalPractice
{
    abstract public class Product
    {
        public virtual string Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public uint Age { get; set; }
        public virtual void Show()
        {
            Console.WriteLine("Категория: " + Category);
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Производитель: " + Manufacturer);
            Console.WriteLine("Возраст: " + Age);
        }
    }
}
