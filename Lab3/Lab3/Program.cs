using System;

using Lab3.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Task1.DoWork();
                Task2.DoWork();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
