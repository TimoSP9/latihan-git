using System;

namespace latihan_git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input prima:");
            int bilangan = Convert.ToInt32(Console.ReadLine());
            //ART
            int ART = 0;
            for (int i = 1; i <= bilangan; i++)
            {
                if (bilangan % i== 0 )
                {
                    ART++;
                }
            }
            if (ART == 2)
            {
                Console.Write("Ini itu prima");
            }
            else
                Console.Write("ini bukan prima");
        }
    }
}
