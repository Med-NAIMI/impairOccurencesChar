using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impairOccurencesChar
{
    abstract class Traitement
    {
        public static int charOccurrences(string s, char c)
        {
            int i = 0;
            //i l'indice du char dans le string, 
            int nbrOccurrences = 0;//nbrOccurrences le nbr des occurences retrouvées
            foreach(char c1 in s)
            {
                
                if (i%2!=0 && c1==c)
                {
                    nbrOccurrences += 1;//on augmente de 1 lorsque les condition demandées sont satisfaites
                }
                i++;
            }return nbrOccurrences;//on retourne le nbr d'occurrences
            
        }
    }
}
