using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTemplate.Food
{
    public class HotDog : FastFoodBase
    {
        protected override void AddMeat()
        {
            Console.WriteLine("Добавлена сосиска");
        }

        protected override void AddSalat()
        {
            Console.WriteLine("Добавлен жаренный лук");
        }

        protected override void AddToping()
        {
            Console.WriteLine("Добавлена горчица");
        }

        public override bool isWantsToppings()
        {
            Console.WriteLine("Нужно добавить горчицу? да/нет:");
            var readLine = Console.ReadLine();
            if(readLine != null && readLine.ToLower().Equals("да"))
            {
                return true;
            }
            return false;
        }
    }
}
