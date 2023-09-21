using System;
namespace C-Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your a string: ");
            string name = Console.ReadLine();
            char[] a = name.ToCharArray();
            string rev = "";
            for(int i = a.Length-1; i>=0; i--)
            {
                rev += a[i];
            }
            if (rev == name)
                Console.WriteLine(name + " is Pallindrome String");
            else
                Console.WriteLine(name + " is not Pallindrome String");
        }
    }
}
