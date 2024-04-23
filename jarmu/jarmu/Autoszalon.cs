using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmu
{
    internal class Autoszalon
    {
        public List<Jarmu> Jarmuvek {  get; set; }
        public Autoszalon()
        {
            Jarmuvek = new List<Jarmu>();
        }
        public void UjJarmuHozzaadasa(Jarmu jarmu)
        {
            Jarmuvek.Add(jarmu);
            Console.WriteLine("jármű hozzá lett adva");
        }
        public void JarmuEladasa(string gyarto, string modell)
        {
            bool kimenet = false;
            int index = 0;
            foreach (var jarmu in Jarmuvek)
            {
                if (jarmu.Gyarto == gyarto && jarmu.Modell == modell)
                {
                    kimenet = true;
                    Jarmuvek.RemoveAt(index);
                }
                else
                {
                    kimenet = false;
                }
                index++;
            }
        }
        public void JarmuKeresese(string gyarto, string modell)
        {
            foreach (var jarmu in Jarmuvek)
            {
                if (jarmu.Gyarto == gyarto && jarmu.Modell == modell)
                {
                    Console.WriteLine(jarmu);
                }
            }
        }
        public void JarmuvekListazasa()
        {
            foreach(var jarmu in Jarmuvek)
            {
                Console.Write(jarmu);
            }
        }
    }
}
