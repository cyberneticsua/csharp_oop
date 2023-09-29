using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 0;
            int y = 3;
            try
            {
                //int z = y / x;
                //Console.ReadLine();
                string name = Console.ReadLine();
                if (name.Length<2)
                {
                    throw new Exception("The name should be longer than 2 symbols");
                }
                Console.WriteLine(name);
            }
            catch (DivideByZeroException e) when (y==0)
            {
                Console.WriteLine("Y must be non-zero");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division by zero");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
            Console.WriteLine("After try");
            Console.ReadLine();
        }
    }
}
