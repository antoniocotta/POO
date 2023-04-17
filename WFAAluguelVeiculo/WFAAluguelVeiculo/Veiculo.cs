using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAAluguelVeiculo
{
    public abstract class Veiculo
    {
        protected string placa;
        protected int ano;

        public Veiculo(string _placa, int _ano)
        {
            placa = _placa;
            ano = _ano;
        }
        //getters and setters
        public string Placa { get => placa; set => placa = value; }
        public int Ano { get => ano; set => ano = value; }
        //Métodos

        public virtual double alugar()
        {
            return 0.0;
        }
    
    
    
    
    }
    
    



}
