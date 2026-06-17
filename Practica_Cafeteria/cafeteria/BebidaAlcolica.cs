using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Cafeteria.cafeteria
{
    internal class BebidaAlcolica : Bebida
    {
        private int GradoAlcohol;
        public int gradoAlcohol
        {
            get { return GradoAlcohol; }
            set { GradoAlcohol = value; }
        }

        public BebidaAlcolica(string _nombre, string _tamaño, float _precio, int _cantidadHielo) : base(_nombre, _tamaño, _precio)
        {
            GradoAlcohol = _cantidadHielo;
        }

        //metodo sobreescrito(Polimorfismo)
        public override string Preparar()
        {
            return "Preparando un : " + Nombre + "Fria de tamaño : " + Tamaño;
        }

        public string Listar()
        {
            return "Un/a " + Nombre + "Fri@";
        }
    }
}
