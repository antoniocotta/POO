using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area2
{
    class Quadrado:Formas
    {
        internal double ladoQuadrado;

        public Quadrado(string nome, double ladoQuadrado): base(nome)
        {
            this.ladoQuadrado = ladoQuadrado;
        }

        public double LadoQuadrado { get => ladoQuadrado; set => ladoQuadrado = value; }

        public override double area()
        {
            return ladoQuadrado * ladoQuadrado;
        }

        public override double perimetro()
        {
            return ladoQuadrado * 4;
        }

    }
}
