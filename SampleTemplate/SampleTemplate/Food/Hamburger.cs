using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTemplate.Food
{
    public class Hamburger : FastFoodBase
    {
        protected override void AddMeat()
        {
            Console.WriteLine("Добавлена говяжья котлета");
        }

        protected override void AddSalat()
        {
            Console.WriteLine("Добавлен салат");
        }

        protected override void AddToping()
        {
            Console.WriteLine("Добавлен кетчуп");
        }
    }
}
