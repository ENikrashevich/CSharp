using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace лаба_2_вариант_С_
{
    public class Display
    {
        public int state;
        public int _deposit = 0;
        public void display(CoffeMachine machine, Management manage)
        {
            while(true)
            {
                if(_deposit == 0)
                {
                    Console.WriteLine("Внесите депозит");
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    _deposit += tmp;
                }
                else
                {
                    Console.WriteLine("Текущий баланс: " + _deposit);
                    Console.WriteLine("Выберите, что приготовить:");
                    Console.WriteLine("1. Латте - 100 рублей");
                    Console.WriteLine("2. Капучино - 150 рублей");
                    Console.WriteLine("3. Эспрессо - 200 рублей");
                    Console.WriteLine("4. Классический горячий шоколад - 150 рублей");
                    Console.WriteLine("5. Двойной горячий шоколад - 200 рублей");
                    Console.WriteLine("6. Пополнить депозит");
                    Console.WriteLine("7. Выход");
                    state = Convert.ToInt32(Console.ReadLine());
                    switch (state)
                    {
                        case 1:
                            if (_deposit < 100)
                            {
                                Console.WriteLine("Недостаточно средств");
                            }
                            else
                            {
                                Console.WriteLine("Добавление растворимого кофе");
                                Console.WriteLine("Добавление воды");
                                Console.WriteLine("Добавление сухого молока");
                                Console.WriteLine("Добавление воды");
                                Console.WriteLine("Добавление сахара");
                                CookLatte cook = new CookLatte(machine);
                                manage.SetCommand(cook);
                                manage.PressButton(ref _deposit);
                            }
                            break;
                        case 2:
                            if (_deposit < 150)
                            {
                                Console.WriteLine("Недостаточно средств");
                            }
                            else
                            {
                                Console.WriteLine("Добавление растворимого кофе");
                                Console.WriteLine("Добавление воды");
                                Console.WriteLine("Добавление сухого молока");
                                Console.WriteLine("Добавление воды");
                                Console.WriteLine("Добавление сахара");
                                CookCappuccino cook = new CookCappuccino(machine);
                                manage.SetCommand(cook);
                                manage.PressButton(ref _deposit);
                            }
                            break;
                        case 3:
                            if (_deposit < 200)
                            {
                                Console.WriteLine("Недостаточно средств");
                            }
                            else
                            {
                                Console.WriteLine("Добавление растворимого кофе");
                                Console.WriteLine("Добавление воды");
                                Console.WriteLine("Добавление сухого молока");
                                Console.WriteLine("Добавление воды");
                                Console.WriteLine("Добавление сахара");
                                CookEspresso cook = new CookEspresso(machine);
                                manage.SetCommand(cook);
                                manage.PressButton(ref _deposit);
                            }
                            break;
                        case 4:
                            if (_deposit < 150)
                            {
                                Console.WriteLine("Недостаточно средств");
                            }
                            else
                            {
                                Console.WriteLine("Добавление растворимого кофе");
                                Console.WriteLine("Добавление воды");
                                Console.WriteLine("Добавление сухого молока");
                                Console.WriteLine("Добавление воды");
                                Console.WriteLine("Добавление сахара");
                                CookClassicChocolate cook = new CookClassicChocolate(machine);
                                manage.SetCommand(cook);
                                manage.PressButton(ref _deposit);
                            }
                            break;
                        case 5:
                            if (_deposit < 200)
                            {
                                Console.WriteLine("Недостаточно средств");
                            }
                            else
                            {
                                Console.WriteLine("Добавление растворимого кофе");
                                Console.WriteLine("Добавление воды");
                                Console.WriteLine("Добавление сухого молока");
                                Console.WriteLine("Добавление воды");
                                Console.WriteLine("Добавление сахара");
                                CookDoubleChocolate cook = new CookDoubleChocolate(machine);
                                manage.SetCommand(cook);
                                manage.PressButton(ref _deposit);
                            }
                            break;
                        case 6:
                            Console.WriteLine("Внесите депозит");
                            int tmp = Convert.ToInt32(Console.ReadLine());
                            _deposit += tmp;
                            break;
                        case 7:
                            Console.WriteLine("Выход из системы");
                            return;
                        default:
                            Console.WriteLine("Неверно выбранная операция");
                            break;
                    }
                }
            }
        }
    }
}
