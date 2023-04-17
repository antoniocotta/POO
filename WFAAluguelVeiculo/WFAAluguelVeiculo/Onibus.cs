using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAAluguelVeiculo
{
     class Onibus:Veiculo
    {
        private int qtdAssentos;
        public Onibus(string _placa, int _ano, int _qtdAssentos) : base(_placa, _ano)
        {
            qtdAssentos = _qtdAssentos;
        }
        public int QtdAssentos { get => qtdAssentos; set => qtdAssentos = value; }

    
        public override double alugar()
        {
            
            return (30 * qtdAssentos) - (2023 - ano) * 70;
        }
    }
}
