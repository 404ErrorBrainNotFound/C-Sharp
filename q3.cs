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
                c=Char.ToLower(c);
                if(c=='a'|| c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    continue;
                else 
                    newstr+=str[i];
            }
            Console.WriteLine("Old String: "+str+"\nNew String: "+newstr);
        }
    }
}
