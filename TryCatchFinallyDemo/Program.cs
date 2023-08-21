using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinallyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("you entered " + number);
            }

            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.Message.ToString());
            }

            finally
            {
                Console.WriteLine("successful");
            }

            Console.ReadLine();




        }
    }
}
