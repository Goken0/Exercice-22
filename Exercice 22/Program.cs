using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_22
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration
            float note;
            int nbsup = 0;
            // boucle sur la saisie des 10 notes
            for(int k = 1; k <= 10; k++)
            {
                Console.Write("Entrez une note = ");
                note = float.Parse(Console.ReadLine());
                // affichage des notes supérieures ou égales à 10
                if (note >= 10)
                {
                    nbsup++;
                }
            }
            // affichage des notes supérieures et inférieurs ou égales à 10
            Console.WriteLine("Nombres de notes >= 10 : " + nbsup);
            Console.WriteLine("Nombres de notes < 10 : " + (10 - nbsup));
            Console.ReadLine();
        }
    }
}
