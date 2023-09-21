using System;
namespace C-Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your a string: ");
            string str = Console.ReadLine();
            string newstr= "";
            for(int i=0;i<str.Length;i++)
            {
                char c= str[i];
                if (Char.IsWhiteSpace(c))
                    continue;
                else
                    newstr += c;
            }
            Console.WriteLine("Old String: "+str+"\nNew String: "+newstr);
        }
    }
}
