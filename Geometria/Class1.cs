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
        public float BaseRettangolo;
        public float AltezzaRettangolo;


        //-------------------------------- Metodi Rettangolo ----------------------------------------


        //Metodo Area
        public float CalcolaArea()
            {
            float AreaRettangolo = BaseRettangolo * AltezzaRettangolo;
            Console.WriteLine("L' area del rettangolo " + Nome + " è di: " + AreaRettangolo + " Cm2");
            return AreaRettangolo;
            }

        //Metodo Perimetro
        public float CalcolaPerimetro()
            {
            float PerimetroRettangolo = (BaseRettangolo + AltezzaRettangolo) * 2;
            Console.WriteLine("Il perimetro del rettangolo " + Nome + " è di: " + PerimetroRettangolo + " Cm");
            return PerimetroRettangolo;
            }
        }
    }




