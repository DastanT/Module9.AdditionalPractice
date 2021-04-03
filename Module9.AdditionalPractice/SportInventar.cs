using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.AdditionalPractice
{
    public class SportEquipment: Product
    {
        public override string Category { get; set; } = "Спортивный инвентарь";
        public void InitSportInvent(int size, List<SportEquipment> sportInventars)
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                SportEquipment sportEquip = new SportEquipment();
                sportEquip.Name = string.Format("{0}", rnd.Next(1, 100000));
                sportEquip.Price = rnd.Next(500, 100000);
                sportEquip.Manufacturer = string.Format("{0}", rnd.Next(1, 1000));
                sportEquip.Age = (uint)rnd.Next(3, 100);
                sportInventars.Add(sportEquip);
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
            Console.WriteLine("Возраст: " + Age);
            Console.ResetColor();
        }
    }
}
