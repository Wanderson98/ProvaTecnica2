using ControleTeste.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTeste.Servicos
{
    internal class Dashboard
    {
        private DateTime DataInicial;
        private DateTime DataFinal;
        private int NumeroDeDias;
        public decimal ValorTotal { get; set; }
        public List<Receita> Receita { get; set; }
        public List<Despesa> Despesa { get; set; }

        public Dashboard()
        {
        }


    }
}
