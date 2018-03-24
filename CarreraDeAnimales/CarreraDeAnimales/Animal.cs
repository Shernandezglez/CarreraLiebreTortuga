using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraDeAnimales
{
    abstract class Animal
    {
        protected int _posicion;
        protected string _especie;

        public int pos { get { return _posicion; } }
        public string nombreDeEspecie { get { return _especie; } }

        public Animal(string nombre)
        {
            _posicion = 0;
            _especie = nombre;

        }


    }
}
