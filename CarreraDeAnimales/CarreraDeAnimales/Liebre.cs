using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraDeAnimales
{
    class Liebre:Animal
    {
        private static int totalPasos = 0;
        Random rnd = new Random();


        public int posicion { get { return _posicion; } }

        public Liebre(string nombreEspecie)
            :base(nombreEspecie)
        {
            _posicion += totalPasos;
        }

        public int avanzar()
        {
            int avance = rnd.Next(10);
            int dormir = rnd.Next(10);
            int resbalones = rnd.Next(10);

            if (dormir == 2)
                totalPasos += 0;
            else if (resbalones == 2)
                totalPasos -= 2;
            else if (resbalones == 1)
                totalPasos -= 12;
            else if (avance == 2)
                totalPasos += 9;
            else if (avance == 3)
                totalPasos += 3;
            else
                totalPasos += 0;

            return totalPasos;


        }
    }
}
