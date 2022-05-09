using ControleTeste.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTeste.Servicos
{
    internal class ControleMovimentacoes
    {
        private List<Receita> Receitas = new List<Receita>();
        private List<Despesa> Despesas = new List<Despesa>();
       

        public ControleMovimentacoes(List<Receita> receitas, List<Despesa> despesas)
        {
            Receitas = receitas;
            Despesas = despesas;
           
        }

        public List<Receita> BuscaReceita7Dias()
        {
            List<Receita> receitas = Receitas.FindAll(x=> x.Data >= DateTime.Now.AddDays(-7));
            return receitas;
        }

        public List<Receita> BuscaReceitaMes()
        {
            List<Receita> receitas = Receitas.FindAll(x => x.Data.Month == DateTime.Now.Month);
            return receitas;
        }

        public List<Despesa> BuscaDespesa7Dias()
        {
            List<Despesa> despesas = Despesas.FindAll(x => x.Data >= DateTime.Now.AddDays(-7));
            return despesas;
        }
        public List<Despesa> BuscaDespesaMes()
        {
            List<Despesa> despas = Despesas.FindAll(x => x.Data.Month == DateTime.Now.Month);
            return despas;
        }
    }
}
