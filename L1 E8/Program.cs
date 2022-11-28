using System;

namespace L1_E8
{
    /* Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica
       daca x este divizibil cu y. 
       In cazul in care x este divizibil cu y, programul va afisa “divizibil” iar in caz contrar, 
       “indivizibil”.
    */
    class Program
    {
        static void Main(string[] args)
        {
            int primulNumar;
            int alDoileaNumar;

            Console.WriteLine("Introduceti primul numar");
            primulNumar = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");
            alDoileaNumar = int.Parse(Console.ReadLine());

            if (primulNumar % alDoileaNumar == 0)
            {
                Console.WriteLine("divizibil");
            }
            else
            {
                Console.WriteLine("indivizibil");
            }
        }
    }
}