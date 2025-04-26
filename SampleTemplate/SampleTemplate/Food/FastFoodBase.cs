using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTemplate.Food
{
    public abstract class FastFoodBase
    {
        public void PrepareFood()
        {
            Console.WriteLine("Подготовка еды");
            AddBread();
            AddSalat();
            AddMeat();
            if(isWantsToppings())
            {
                AddToping();
            }
        }
        public virtual bool isWantsToppings()
        {
            return true;
        }

        protected abstract void AddSalat();
        protected abstract void AddMeat();
        protected abstract void AddToping();

        private void AddBread()
        {
            Console.WriteLine("Добавили хлеб");
        }
    }
}
