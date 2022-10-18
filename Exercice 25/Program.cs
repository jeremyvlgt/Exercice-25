using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int vlr, vlre;
            char rep='O';
            bool txt=false;

            Console.Write("Veuillez saisir plusieurs valeurs : ");
            vlr = int.Parse(Console.ReadLine());
            vlre = vlr;

            do
            {
                Console.Write("Veuillez saisir plusieurs valeurs : ");
                vlr = int.Parse(Console.ReadLine());
                if (vlr > vlre)
                {
                    vlre = vlr;
                    txt = true;
                }
                else
                {
                    txt = false;
                }
                Console.Write("Voulez vous continuer ? (O/N) : ");
                rep = char.Parse(Console.ReadLine());
            } while (rep != 'N');
            
            if (txt==true)
            {
                Console.WriteLine("La suite de valeurs saisies est strictement croissante.");
            }
            else
            {
                Console.WriteLine("La suite de valeurs saisies n'est pas croissante.");
            }
            Console.ReadLine();
        }
    }
}
