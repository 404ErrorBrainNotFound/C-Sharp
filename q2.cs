using System;
namespace C-Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your a string: ");
            string str = Console.ReadLine();
            int vo = 0; int con=0; int spa = 0;
            for(int i=0;i<str.Length;i++)
            {
                char c= str[i];
                c=Char.ToLower(c);
                if (Char.IsWhiteSpace(c))
                {
                    spa++;
                }
                else if(c=='a'|| c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    vo++;
                else if(Char.IsLetter(c)) 
                    con++;
            }
            Console.WriteLine("Vowels: " + vo + "\nConsonants: " + con+"\nWhite Space: "+spa);
        }
    }
}
