using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal(10, "Azorel", 5);
            Animal a3 = (Animal)a2.Clone();
            a3.Nume = "Grivei";
            a3.Greutate = 17;
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);

            Castor c1 = new Castor(12, "Willy", 4, "maro", 20, 'M');
            Paun p1 = new Paun(9, "Titi", 2, 2, true);

            Zoo z1 = new Zoo();
            z1.ListaAnimale.Add(a1);
            z1.ListaAnimale.Add(a3);
            z1.ListaAnimale.Add(a2);
            z1.ListaAnimale.Add(c1);
            z1.ListaAnimale.Add(p1);


            Zoo z2 = (Zoo)z1.Clone();
            z2.Denumire = "Berlin";
            foreach (Animal a in z2.ListaAnimale)
                a.Nume += " copie";

            z1.ListaAnimale.Sort();
            z2.ListaAnimale.Sort();

            Console.WriteLine(z1);
            Console.WriteLine(z2);

            Console.WriteLine("----------------------");
            Console.WriteLine(z2[3]);

            Console.WriteLine("----------------------");
            a1 = a1 + 10;
            a1 += 10;
            a2 = 5 + a2;
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
        }
    }
}
