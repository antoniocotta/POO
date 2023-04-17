using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area2
{
    class Triangulo:Formas
    {
        private double baseTriangulo;
        private double alturaTriangulo;

        public Triangulo(string nome, double baseTriangulo, double alturaTriangulo) : base(nome)
        {
            this.baseTriangulo = baseTriangulo;
            this.alturaTriangulo = alturaTriangulo;
        }

        public double BaseTriangulo { get => baseTriangulo; set => baseTriangulo = value; }
        public double AlturaTriangulo { get => alturaTriangulo; set => alturaTriangulo = value; }

        public override double area()
        {
            return (baseTriangulo * alturaTriangulo) / 2.0;
        }

        public override double perimetro()
        {
            throw new NotImplementedException();
        }
    }
}
