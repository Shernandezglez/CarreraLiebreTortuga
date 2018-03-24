using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraDeAnimales
{
    class Tortuga : Animal
    {
        private static int totalPasos = 0;
        Random rnd = new Random();

        public int posicion { get { return _posicion; } }

        public Tortuga(string nombreEspecie)
            :base(nombreEspecie)
        {
            _posicion += totalPasos;
        }

        public int avanzar()
        {
            int num = rnd.Next(10);

            if(num == 5)
            {
                totalPasos += 3;
            }
            else if (num == 3)
            {
                totalPasos -= 6;
            }
            else if(num == 2)
            {
                totalPasos += 1;
            }
            else
            {
                totalPasos += 0;
            }
            return totalPasos;


        }


    }
}
