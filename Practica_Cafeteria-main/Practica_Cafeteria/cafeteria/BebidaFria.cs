using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Cafeteria.cafeteria
{
    internal class BebidaFria:Bebida
    {
        private int CantidadHielo;
        public int cantidadHielo
        {
            get { return CantidadHielo; }
            set { CantidadHielo = value; }
        }
        
        public BebidaFria(string _nombre, string _tamaño, float _precio, int _cantidadHielo):base(_nombre, _tamaño, _precio)
        {
            CantidadHielo = _cantidadHielo;
        }

        //metodo sobreescrito(Polimorfismo)
        public override string Preparar()
        {
            return "Preparando un : " + Nombre+"Alcoholica de tamaño : "+Tamaño;
        }

        public string Listar()
        {
            return "Un/a " + Nombre + "Alcoholica";
        }
    }
}
