using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Consoledoga
{
    class Program
    {
        //1,2,4,6,7,8
        static void Main(string[] args)
        {
            List<Nobel> nobelLista = new List<Nobel>();
            StreamReader streamReader = new StreamReader("nobel.csv");
            streamReader.ReadLine();
            while (!streamReader.EndOfStream)
            {
                string[] sor = streamReader.ReadLine().Split(';');
                nobelLista.Add(new Nobel(int.Parse(sor[0]), sor[1], sor[2], sor[3]));
            }
            streamReader.Close();

            foreach (Nobel elem in nobelLista)
            {
                if (elem.Ev == 2017 && elem.Tipus == "irodalmi")
                {
                    Console.WriteLine($"4. feladat: {elem.Keresztnev} {elem.Vezeteknev}");
                }
            }

            Console.WriteLine("6. feladat:");
            foreach (Nobel elem in nobelLista)
            {
                if (elem.Vezeteknev == "Curie")
                {
                    Console.WriteLine($"\t{elem.Ev}: {elem.Keresztnev} {elem.Vezeteknev} ({elem.Tipus})");
                }
            }

            Console.WriteLine("7. feladat:");
            foreach (Nobel elem in nobelLista)
            {
                Console.WriteLine($"\t {elem.Tipus} {elem.Tipus.Count()}");
            }

            Console.WriteLine("8. feladat: orvosi.txt");
            StreamWriter streamWriter = new StreamWriter("orvosi.txt");
            for (int index = nobelLista.Count - 1; index > 0; index--)
            {
                if (nobelLista[index].Tipus == "orvosi")
                {
                    streamWriter.WriteLine($"{nobelLista[index].Ev}:{nobelLista[index].Keresztnev}{nobelLista[index].Vezeteknev}");
                }
            }
            streamWriter.Close();
            Console.ReadKey();
        }
    }
}
