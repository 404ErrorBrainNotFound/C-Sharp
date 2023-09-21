using System;
namespace C-Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your a string: ");
            string str = Console.ReadLine();
            char[]c=str.ToCharArray();
            int sum = 0;
            for(int i=0;i<str.Length;i++)
            {
                int a = 0;
                if (Char.IsDigit(c[i])){
                    while (i<str.Length && Char.IsDigit(c[i])) 
                    {
                        a= (int)((a*10) + Char.GetNumericValue(c[i]));
                        i++;
                    }
                }
                sum += a;
            }
            Console.WriteLine("Sum: "+sum);
        }
    }
}
