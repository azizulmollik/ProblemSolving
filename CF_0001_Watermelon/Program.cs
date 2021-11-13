using System;

namespace CF_0001_Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int w=0;
            w= Convert.ToInt32(Console.ReadLine());

            if(w>2 && w%2==0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

        }
    }
}
