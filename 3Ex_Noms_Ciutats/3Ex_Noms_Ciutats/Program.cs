using System;
using System.Linq;

namespace _3Ex_Noms_Ciutats
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part1
            string ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6;
            Console.WriteLine("Introdueix el nom de la ciutat 1:");
            ciutat1 = Console.ReadLine();

            Console.WriteLine("Introdueix el nom de la ciutat 2:");
            ciutat2 = Console.ReadLine();

            Console.WriteLine("Introdueix el nom de la ciutat 3:");
            ciutat3 = Console.ReadLine();

            Console.WriteLine("Introdueix el nom de la ciutat 4:");
            ciutat4 = Console.ReadLine();

            Console.WriteLine("Introdueix el nom de la ciutat 5:");
            ciutat5 = Console.ReadLine();

            Console.WriteLine("Introdueix el nom de la ciutat 6:");
            ciutat6 = Console.ReadLine();

            Console.WriteLine("Noms de les ciutats introduïdes:");
            Console.WriteLine(ciutat1);
            Console.WriteLine(ciutat2);
            Console.WriteLine(ciutat3);
            Console.WriteLine(ciutat4);
            Console.WriteLine(ciutat5);
            Console.WriteLine(ciutat6);


            //Part2
            string[] arrayCiutats = { ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6 };
            string control;
            for (int i=0; i<arrayCiutats.Length; i++)
            {
                for(int j=i+1; j < arrayCiutats.Length; j++)
                {
                    if (string.Compare(arrayCiutats[j], arrayCiutats[i]) < 1)
                    {
                        control = arrayCiutats[i];
                        arrayCiutats[i] = arrayCiutats[j];
                        arrayCiutats[j] = control;
                    }
                }

            }

            Console.WriteLine("Mostra les dades dins de l'array ordenades alfabèticament:");
            foreach(string ciutat in arrayCiutats)
            {
                Console.WriteLine(ciutat);
            }

            //Part3
            string[] arrayCiutatsModificades=new string[arrayCiutats.Length];
            for (int i = 0; i < arrayCiutats.Length; i++)
            {
                arrayCiutatsModificades[i] = arrayCiutats[i].Replace('a', '4');
            }
            for (int i = 0; i < arrayCiutatsModificades.Length; i++)
            {
                for (int j = i + 1; j < arrayCiutatsModificades.Length; j++)
                {
                    if (string.Compare(arrayCiutatsModificades[j], arrayCiutatsModificades[i]) < 1)
                    {
                        control = arrayCiutatsModificades[i];
                        arrayCiutatsModificades[i] = arrayCiutatsModificades[j];
                        arrayCiutatsModificades[j] = control;
                    }
                }

            }

            Console.WriteLine("Mostra les dades dins de l'array de noms transformats ordenades alfabèticament:");
            foreach (string ciutat in arrayCiutatsModificades)
            {
                Console.WriteLine(ciutat);
            }
        }
    }
}
