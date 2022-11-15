using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ilk ededi daxil edin");
            int ilkeded = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin");
            int ikincieded= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Isareni daxil edin");
            char isare = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(calculate(ilkeded,ikincieded,isare));

           
        }
        static int calculate(int ilkeded,int ikincieded,char isare)
        {
            if (isare == '+')
            {
                int netice = ilkeded + ikincieded;
                return netice;
            }
            else if (isare == '-')
            {
                int netice = ilkeded - ikincieded;
                return netice;

            }
            else if (isare =='*')
            {
                int netice = ilkeded * ikincieded;
                return netice;

            }
            else if(isare=='/')
            {
                int netice = ilkeded / ikincieded;
                return netice;
            }
            else
            {
                Console.WriteLine("Duzgun operator daxil edin");
                return default;
            }
           
        } 

    }
}
