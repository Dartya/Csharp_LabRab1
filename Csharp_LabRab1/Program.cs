using System;

namespace Csharp_LabRab1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            finally
            {
                Console.Write("Press <Enter>");
                Console.ReadLine();
            }
        }
    }
}