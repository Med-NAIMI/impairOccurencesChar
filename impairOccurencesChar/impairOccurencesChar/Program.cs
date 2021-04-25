using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impairOccurencesChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("svp, entrez la chaine de charactere que vous voulez tester!");
            string s=Console.ReadLine();
            Console.WriteLine("svp, entrez le charactere que vous chercher!");
            char c = (char) Console.Read();

            //int n=Traitement.charOccurrences(s, c);

            Console.WriteLine(Traitement.charOccurrences(s, c));
            Console.ReadKey();//pour conserver l affichage

        }
    }
}
