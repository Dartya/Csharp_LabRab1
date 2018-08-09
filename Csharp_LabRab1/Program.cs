using System;
//оставляем в директивах только одно пространство имен "System" - остальные, создаваемые по умолчанию, не нужны

namespace Csharp_LabRab1    //указываем неймспейс как имя нашей программы
{
    class Program           //стандартный класс Program
    {
        static void Main(string[] args) //в нем основной метод программы - Main(string[] args). args - массив операторов, записанных в виде объектов String
        {
            try                                     //приучаемся писать правильно, обрабатывая эксепты - пишем основной код программы в теле секции try
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("Please enter a numeric argument.");
                    Console.WriteLine("Usage: Factorial <num>");
                }
                else {
                    for (int i = 0; i < args.Length; i++) {
                        Console.WriteLine(args[i]);
                    }
                }
            }
            catch (Exception e)                     //в этой секции перехватываем ошибку и выводим ее на экран
            {
                Console.WriteLine(e.ToString());
            }

            finally                                 //и в блоке Finally производим те действия, которые будем выполнять вне зависимости от того, выполнится ли try или catch
            {
                Console.Write("Press <Enter>");     //а именно - не дадим закрыться консоли, пока не нажмем Enter :)
                Console.ReadLine();                 //вот теперь можно закрыть консоль
            }
        }
    }
}