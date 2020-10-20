using System;

namespace Practice_2
{
    class Program
    {
        
        static void Devision()
        {
            Console.WriteLine("Введите первое число: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double n2 = double.Parse(Console.ReadLine());

            if (n2 == 0)
            {
                Console.WriteLine("Деление невозможно! На 0 делить нельзя!");
            }
            else
            {
                double dev = n1 / n2;
                Console.WriteLine($"Результат деления = {dev}");
            }
        }

        static void Calculate()
        {
            Console.WriteLine("Введите первое число: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Нажмите цифру, соответсвующую знаку:");
            Console.WriteLine("1, если +");
            Console.WriteLine("2, если -");
            Console.WriteLine("3, если *");
            Console.WriteLine("4, если /");
            int sign = int.Parse(Console.ReadLine());
            switch (sign)
            {
                case 1:
                    double sum = n1 + n2;
                    Console.WriteLine(sum);
                    break;
                case 2:
                    double dif = n1 - n2;
                    Console.WriteLine(dif);
                    break;
                case 3:
                    double mult = n1 * n2;
                    Console.WriteLine(mult);
                    break;
                case 4:
                    if (n2 == 0)
                    {
                        Console.WriteLine("Деление невозможно! На 0 делить нельзя!");
                    }
                    else
                    {
                        double dev = n1 / n2;
                        Console.WriteLine($"Результат деления = {dev}");
                    }
                    break;
            }
        }


        static void Wallpaper()
        {
            Console.WriteLine("Введите длинну рулона");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину рулона");
            double width = double.Parse(Console.ReadLine());
            double sqrWall = 2 * 2.6 * (8 + 6);
            double sqrWallSmall = sqrWall * 0.8;
            double sqrWallPapper = length * width;
            double numRolls = Math.Ceiling(sqrWallSmall / sqrWallPapper);
            Console.WriteLine($"Площадь стен комнаты = {sqrWall}, м2");
            Console.WriteLine($"Площадь стен комнаты с учетом уменьшения на 20% = {sqrWallSmall}, м2");
            Console.WriteLine($"Площадь одного руллона = {sqrWallPapper}, м2");
            Console.WriteLine($"Необходимо купить {numRolls} руллон(-а/-ов) обоев.");
        }

        static void Main(string[] args)
        {
                bool work = true;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Выберите пункт меню:");
                    Console.WriteLine("1. Деление");
                    Console.WriteLine("2. Калькулятор");
                    Console.WriteLine("3. Обои");
                    Console.WriteLine("0. Выход");

                    int point = int.Parse(Console.ReadLine());
                    switch (point)
                    {
                        case 1:
                            Devision();
                            break;
                        case 2:
                            Calculate();
                            break;
                        case 3:
                            Wallpaper();
                            break;
                        case 0:
                            work = false;
                            break;
                        default:

                            break;
                    }
                } while (work);

                Console.ReadLine();
        }
    }
}
