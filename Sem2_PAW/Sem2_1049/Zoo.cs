using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_1049
{
    class Zoo: ICloneable
    {
        private string denumire;
        private List<Animal> listaAnimale;

        public Zoo()
        {
            denumire = "Baneasa";
            listaAnimale = new List<Animal>();
        }

        public string Denumire
        {
            get { return denumire; }
            set { if (value != null) denumire = value; }
        }

        public List<Animal> ListaAnimale
        {
            get { return listaAnimale; }
            set { if (value != null) listaAnimale = value; }
        }

        public object Clone()
        {
            //return this.MemberwiseClone();
            Zoo clona = (Zoo)this.MemberwiseClone();
            List<Animal> listaNoua = new List<Animal>();
            foreach (Animal a in listaAnimale)
                listaNoua.Add((Animal)a.Clone());
            clona.listaAnimale = listaNoua;
            return clona;
        }

        public override string ToString()
        {
            string rezultat = "Zoo " + denumire + " are urmatoarele animale: "+Environment.NewLine;
            foreach (Animal a in listaAnimale)
                rezultat += a.ToString() + Environment.NewLine;
            return rezultat;
        }

        public Animal this[int index]
        {
            get
            {
                if (listaAnimale != null && index >= 0 && index < listaAnimale.Count)
                    return listaAnimale[index];
                else
                    return null;
            }
        }
    }
}
