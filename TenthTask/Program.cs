using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenthTask
{
    class Program
    {

         static CRectangle firstRectangle;
         static CRectangle secondRectangle;
         static CRectangle quadrate;

        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Создание объекта прямоугольник");
                Console.WriteLine("2 - Подсчитать Периметр прямоугольника");
                Console.WriteLine("3 - Подсчитать Площадь прямоугольника");
                Console.WriteLine("4 - Создание объекта квадрат");
                Console.WriteLine("5 - Подсчитать Периметр квадрата ");
                Console.WriteLine("6 - Подсчитать Площадь квадрата");
                Console.WriteLine("7 - Сравнить Площади прямоугольников");
                Console.WriteLine("0 - Выход");

                try
                {
                    int enterNumber = int.Parse(Console.ReadLine());
                    switch (enterNumber)
                    {
                        case 0:
                            {
                                flag = false;
                                Console.WriteLine("Программа завершила работу."); break;
                            }
                        case 1:
                            {

                                firstRectangle = new CRectangle(new CPoint(8, 0), new CPoint(9, 1), new CPoint(1, 9), new CPoint(0, 8));
                                secondRectangle = new CRectangle(new CPoint(3, 4), new CPoint(-6, 4), new CPoint(-6, -3), new CPoint(3, -3));
                                if (firstRectangle.isGivenFigure())
                                {
                                    Console.WriteLine("\nСоздан прямоугольник со сторонами: ");
                                    firstRectangle.outputDataOfFigure();
                                }
                                break;
                            }
                        case 2:
                            {
                                if (firstRectangle.isGivenFigure())
                                {
                                    Console.WriteLine("Периметр прямоугольника:{0}", firstRectangle.calcPerimeter());
                                }
                                break;
                            }

                        case 3:
                            {
                                if (firstRectangle.isGivenFigure())
                                {
                                    Console.WriteLine("Площадь прямоугольника: {0}", firstRectangle.calcArea());
                                }
                                break;
                            }
                        case 4:
                            {
                                quadrate = new CQuadrate(new CPoint(3, 3), new CPoint(5, 7), new CPoint(9, 5), new CPoint(7, 1));
                                if (quadrate.isGivenFigure())
                                {
                                    Console.WriteLine("\nСоздан квадрат со сторонами: ");
                                    quadrate.outputDataOfFigure();
                                }
                                break;

                            }
                        case 5:
                            {
                                if (quadrate.isGivenFigure())
                                {
                                    Console.WriteLine("Периметр квадрата:{0}", quadrate.calcPerimeter());
                                }
                                
                                break;
                            }
                        case 6:
                            {
                                if (quadrate.isGivenFigure())
                                {
                                    Console.WriteLine("Площадь квадрата: {0}", quadrate.calcArea());
                                }

                                break;
                            }
                        case 7: 
                            {
                                Console.WriteLine("Первый прямоугольник со сторонами:");
                                firstRectangle.outputDataOfFigure();
                                Console.WriteLine("Площадь первого прямоугольника:{0}\n", firstRectangle.calcArea());
                                
                                Console.WriteLine("Второй прямоугольник со сторонами:");
                                secondRectangle.outputDataOfFigure();
                                Console.WriteLine("Площадь второго прямоугольника:{0}\n", secondRectangle.calcArea());
                                
                                if ( firstRectangle == secondRectangle )
                                {
                                    Console.WriteLine("Площади прямоугольников равны.");
                                }
                                else Console.WriteLine( "Площади данных прямоугольников не равны." );
                                break;
                            }
                        default: Console.WriteLine("Ошибка ввода\n"); break;

                    }
                }
                catch( FormatException )
                {
                    Console.WriteLine( "Введены некорректные данные." );
                }
                catch ( NullReferenceException )
                {
                    Console.WriteLine("Объект ещё не создан.");
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Exception{0}\nFile:{1}\nLocation:{2}", ex.Message, ex.Source, ex.TargetSite);
                }
            }
        }

    }
}
