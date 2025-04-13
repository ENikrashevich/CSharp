using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_2_вариант_С_
{
    public class CoffeMachine
    {
        public int _coffee = 10;
        public int _milk = 10;
        public int _chocolate = 10;
        public int RaspberrySyrup = 10;
        public int StrawberrySyrup = 10;
        public void CookLatte(ref int deposit)
        {
            if (_coffee >= 1 && _milk >= 6)
            {
                deposit -= 100;
                _coffee -= 1;
                _milk -= 6;
                if(RaspberrySyrup > 0 && StrawberrySyrup > 0)
                {
                    Console.WriteLine("Добавить сиропы:");
                    Console.WriteLine("1. Малиновый");
                    Console.WriteLine("2. Клубничный");
                    Console.WriteLine("3. Без сиропа");
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    switch (tmp)
                    {
                        case 1:
                            Console.WriteLine("Добавление малинового сиропа");
                            RaspberrySyrup -= 1;
                            break;
                        case 2:
                            Console.WriteLine("Добавление клубничного сиропа");
                            StrawberrySyrup -= 1;
                            break;
                        default:
                            break;
                    }
                }
                else if(RaspberrySyrup > 0)
                {
                    Console.WriteLine("Добавить сиропы:");
                    Console.WriteLine("1. Малиновый");
                    Console.WriteLine("2. Клубничный - закончился");
                    Console.WriteLine("3. Без сиропа");
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    switch (tmp)
                    {
                        case 1:
                            Console.WriteLine("Добавление малинового сиропа");
                            RaspberrySyrup -= 1;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Добавить сиропы:");
                    Console.WriteLine("1. Малиновый - закончился");
                    Console.WriteLine("2. Клубничный");
                    Console.WriteLine("3. Без сиропа");
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    switch (tmp)
                    {
                        case 2:
                            Console.WriteLine("Добавление клубничного сиропа");
                            StrawberrySyrup -= 1;
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                if (_coffee == 0 && _milk < 6)
                {
                    Console.WriteLine("Недостаточно ингридиентов: кофе и молоко");
                }
                if (_coffee == 0)
                {
                    Console.WriteLine("Недостаточно ингридиента: кофе");
                }
                else
                {
                    Console.WriteLine("Недостаточно ингридиета: молоко");
                }
            }
        }
        public void CookCappuccino(ref int deposit)
        {
            if (_coffee >= 1 && _milk >= 4)
            {
                deposit -= 150;
                _coffee -= 1;
                _milk -= 4;
                if (RaspberrySyrup > 0 && StrawberrySyrup > 0)
                {
                    Console.WriteLine("Добавить сиропы:");
                    Console.WriteLine("1. Малиновый");
                    Console.WriteLine("2. Клубничный");
                    Console.WriteLine("3. Без сиропа");
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    switch (tmp)
                    {
                        case 1:
                            Console.WriteLine("Добавление малинового сиропа");
                            RaspberrySyrup -= 1;
                            break;
                        case 2:
                            Console.WriteLine("Добавление клубничного сиропа");
                            StrawberrySyrup -= 1;
                            break;
                        default:
                            break;
                    }
                }
                else if (RaspberrySyrup > 0)
                {
                    Console.WriteLine("Добавить сиропы:");
                    Console.WriteLine("1. Малиновый");
                    Console.WriteLine("2. Клубничный - закончился");
                    Console.WriteLine("3. Без сиропа");
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    switch (tmp)
                    {
                        case 1:
                            Console.WriteLine("Добавление малинового сиропа");
                            RaspberrySyrup -= 1;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Добавить сиропы:");
                    Console.WriteLine("1. Малиновый - закончился");
                    Console.WriteLine("2. Клубничный");
                    Console.WriteLine("3. Без сиропа");
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    switch (tmp)
                    {
                        case 2:
                            Console.WriteLine("Добавление клубничного сиропа");
                            StrawberrySyrup -= 1;
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                if (_coffee == 0 && _milk < 4)
                {
                    Console.WriteLine("Недостаточно ингридиентов: кофе и молоко");
                }
                if (_coffee == 0)
                {
                    Console.WriteLine("Недостаточно ингридиента: кофе");
                }
                else
                {
                    Console.WriteLine("Недостаточно ингридиета: молоко");
                }
            }
        }
        public void CookEspresso(ref int deposit)
        {
            if (_coffee >= 1 && _milk >= 3)
            {
                deposit -= 200;
                _coffee -= 1;
                _milk -= 3;
                if (RaspberrySyrup > 0 && StrawberrySyrup > 0)
                {
                    Console.WriteLine("Добавить сиропы:");
                    Console.WriteLine("1. Малиновый");
                    Console.WriteLine("2. Клубничный");
                    Console.WriteLine("3. Без сиропа");
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    switch (tmp)
                    {
                        case 1:
                            Console.WriteLine("Добавление малинового сиропа");
                            RaspberrySyrup -= 1;
                            break;
                        case 2:
                            Console.WriteLine("Добавление клубничного сиропа");
                            StrawberrySyrup -= 1;
                            break;
                        default:
                            break;
                    }
                }
                else if (RaspberrySyrup > 0)
                {
                    Console.WriteLine("Добавить сиропы:");
                    Console.WriteLine("1. Малиновый");
                    Console.WriteLine("2. Клубничный - закончился");
                    Console.WriteLine("3. Без сиропа");
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    switch (tmp)
                    {
                        case 1:
                            Console.WriteLine("Добавление малинового сиропа");
                            RaspberrySyrup -= 1;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Добавить сиропы:");
                    Console.WriteLine("1. Малиновый - закончился");
                    Console.WriteLine("2. Клубничный");
                    Console.WriteLine("3. Без сиропа");
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    switch (tmp)
                    {
                        case 2:
                            Console.WriteLine("Добавление клубничного сиропа");
                            StrawberrySyrup -= 1;
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                if( _coffee == 0 && _milk < 3) 
                {
                    Console.WriteLine("Недостаточно ингридиентов: кофе и молоко");
                }
                else if (_coffee == 0)
                {
                    Console.WriteLine("Недостаточно ингридиента: кофе");
                }
                else
                {
                    Console.WriteLine("Недостаточно ингридиета: молоко");
                }
            }
        }
        public void CookClassicChocolate(ref int deposit)
        {
            if (_chocolate >= 1 && _milk >= 3)
            {
                deposit -= 150;
                _chocolate -= 1;
                _milk -= 3;
                if (RaspberrySyrup > 0 && StrawberrySyrup > 0)
                {
                    Console.WriteLine("Добавить сиропы:");
                    Console.WriteLine("1. Малиновый");
                    Console.WriteLine("2. Клубничный");
                    Console.WriteLine("3. Без сиропа");
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    switch (tmp)
                    {
                        case 1:
                            Console.WriteLine("Добавление малинового сиропа");
                            RaspberrySyrup -= 1;
                            break;
                        case 2:
                            Console.WriteLine("Добавление клубничного сиропа");
                            StrawberrySyrup -= 1;
                            break;
                        default:
                            break;
                    }
                }
                else if (RaspberrySyrup > 0)
                {
                    Console.WriteLine("Добавить сиропы:");
                    Console.WriteLine("1. Малиновый");
                    Console.WriteLine("2. Клубничный - закончился");
                    Console.WriteLine("3. Без сиропа");
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    switch (tmp)
                    {
                        case 1:
                            Console.WriteLine("Добавление малинового сиропа");
                            RaspberrySyrup -= 1;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Добавить сиропы:");
                    Console.WriteLine("1. Малиновый - закончился");
                    Console.WriteLine("2. Клубничный");
                    Console.WriteLine("3. Без сиропа");
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    switch (tmp)
                    {
                        case 2:
                            Console.WriteLine("Добавление клубничного сиропа");
                            StrawberrySyrup -= 1;
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                if (_chocolate == 0 && _milk < 3)
                {
                    Console.WriteLine("Недостаточно ингридиентов: шоколад и молоко");
                }
                else if (_chocolate == 0)
                {
                    Console.WriteLine("Недостаточно ингридиента: шоколад");
                }
                else
                {
                    Console.WriteLine("Недостаточно ингридиета: молоко");
                }
            }
        }
        public void CookDoubleChocolate(ref int deposit)
        {
            if (_chocolate >= 2 && _milk >= 3)
            {
                deposit -= 200;
                _chocolate -= 2;
                _milk -= 3;
                if (RaspberrySyrup > 0 && StrawberrySyrup > 0)
                {
                    Console.WriteLine("Добавить сиропы:");
                    Console.WriteLine("1. Малиновый");
                    Console.WriteLine("2. Клубничный");
                    Console.WriteLine("3. Без сиропа");
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    switch (tmp)
                    {
                        case 1:
                            Console.WriteLine("Добавление малинового сиропа");
                            RaspberrySyrup -= 1;
                            break;
                        case 2:
                            Console.WriteLine("Добавление клубничного сиропа");
                            StrawberrySyrup -= 1;
                            break;
                        default:
                            break;
                    }
                }
                else if (RaspberrySyrup > 0)
                {
                    Console.WriteLine("Добавить сиропы:");
                    Console.WriteLine("1. Малиновый");
                    Console.WriteLine("2. Клубничный - закончился");
                    Console.WriteLine("3. Без сиропа");
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    switch (tmp)
                    {
                        case 1:
                            Console.WriteLine("Добавление малинового сиропа");
                            RaspberrySyrup -= 1;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Добавить сиропы:");
                    Console.WriteLine("1. Малиновый - закончился");
                    Console.WriteLine("2. Клубничный");
                    Console.WriteLine("3. Без сиропа");
                    int tmp = Convert.ToInt32(Console.ReadLine());
                    switch (tmp)
                    {
                        case 2:
                            Console.WriteLine("Добавление клубничного сиропа");
                            StrawberrySyrup -= 1;
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                if (_chocolate < 1 && _milk < 3)
                {
                    Console.WriteLine("Недостаточно ингридиентов: шоколад и молоко");
                }
                else if (_chocolate < 1)
                {
                    Console.WriteLine("Недостаточно ингридиента: шоколад");
                }
                else
                {
                    Console.WriteLine("Недостаточно ингридиета: молоко");
                }
            }
        }
    }
}
