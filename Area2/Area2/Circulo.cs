using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area2
{
    class Circulo:Formas
    {
        private double raio;

        public Circulo(string _nome, double _raio):base(_nome)
        {
            raio = _raio;
        }

        public double Raio { get => raio; set => raio = value; }

        public override double area()
        {
            return Math.PI * Math.Pow(raio,2);
        }

    }

}
