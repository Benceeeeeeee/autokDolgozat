using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autoszalon jarmuvek = new Autoszalon();
            Szemelyauto jarmu = new Szemelyauto("Toyota", "Corolla", 2021, 8000000, 15000, 5, 6.5, "Fehér");
            jarmuvek.UjJarmuHozzaadasa(jarmu);

            Terepjaro terep = new Terepjaro("Land Rove", "Defender", 2020, 15000000, 20000, "4WD", true, 3500);
            jarmuvek.UjJarmuHozzaadasa(jarmu);


            jarmuvek.JarmuEladasa("Toyota", "Corolla");

            jarmuvek.JarmuKeresese("Land Rover", "Defender");

            jarmuvek.JarmuvekListazasa();

        }
    }
}
