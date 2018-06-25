using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stop="a";
            
            while(stop!="koniec")
            {
                stop = Console.ReadLine();
                Console.WriteLine(stop);
            }
           

        }
    }    
}
