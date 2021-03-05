using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal(10, "Alfa", 100);
            Animal a3 = (Animal)a2.Clone();
            a3.Nume = "Beta";
            //a3.Greutate = 50;
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);

            Elefant e1 = new Elefant(20, "Dumbo", 500, 2.5f, 'M', "Kenya");
            Vultur v1 = new Vultur(12, "Icarus", 22.2f, 2, 30, true);

            Zoo z1 = new Zoo();
            z1.ListaAnimale.Add(a1);
            z1.ListaAnimale.Add(a3);
            z1.ListaAnimale.Add(a2);
            z1.ListaAnimale.Add(e1);
            z1.ListaAnimale.Add(v1);

            Zoo z2 = (Zoo)z1.Clone();
            z2.Denumire = "Berlin";
            foreach (Animal a in z2.ListaAnimale)
                a.Nume += " copie";

            z1.ListaAnimale.Sort();
            z2.ListaAnimale.Sort();

            Console.WriteLine(z1);
            Console.WriteLine(z2);

            Console.WriteLine("-----------------------");
            a1 = a1 + 10;
            a2 += 10;
            a3 = 10 + a3;
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);

            Console.WriteLine("-----------------------");
            Console.WriteLine(z2[3]);
        }
    }
}
