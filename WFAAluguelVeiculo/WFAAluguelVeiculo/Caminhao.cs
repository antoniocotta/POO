using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAAluguelVeiculo
{
    class caminhao : Veiculo
    {
        private int eixos;
        public caminhao(string _placa, int _ano, int _eixos) : base(_placa, _ano)
        {
            eixos = _eixos;
        }
        public int Eixos { get => eixos; set => eixos = value; }


        public override double alugar()
        {

            return (300 * eixos) - (2023 - ano) * 50;
        }
    }
}
