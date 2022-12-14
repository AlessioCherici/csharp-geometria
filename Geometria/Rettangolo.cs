using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
    {
    public class Rettangolo

        {
        public string Nome;
        public float BaseRettangolo;                                    // Variabile float anzichè int per generalizzare metodi
        public float AltezzaRettangolo;                                 // Variabile float anzichè int per generalizzare metodi


        //-------------------------------- Metodi Rettangolo ----------------------------------------


        //Metodo Area
        public float CalcolaArea()
            {
            float AreaRettangolo = BaseRettangolo * AltezzaRettangolo;
            Console.WriteLine("Area: " + AreaRettangolo + " Cm2" + "\n");
            return AreaRettangolo;
            }

        //Metodo Perimetro
        public float CalcolaPerimetro()
            {
            float PerimetroRettangolo = (BaseRettangolo + AltezzaRettangolo) * 2;
            Console.WriteLine("Perimetro: " + PerimetroRettangolo + " Cm");
            return PerimetroRettangolo;
            }

        public void StampaRettangolo()
            {
            Console.WriteLine("-- " + Nome + " --");
            Console.WriteLine("Base:" + BaseRettangolo + " cm");
            Console.WriteLine("Altezza:" + AltezzaRettangolo + " cm");
            CalcolaPerimetro();
            CalcolaArea();
            }
        }
    }





