using ControleTeste.Entidades;
using System;
using System.Collections.Generic;

namespace ControleTeste.Servicos
{//classe para gerenciar algumas funcoes e buscas
    internal class ControleMovimentacoes
    {
        private List<Receita> Receitas = new List<Receita>();
        private List<Despesa> Despesas = new List<Despesa>();


        public ControleMovimentacoes(List<Receita> receitas, List<Despesa> despesas)
        {
            Receitas = receitas;
            Despesas = despesas;

        }
        //busca as receitas dos ultimos 7 dias com a data do sistema
        public List<Receita> BuscaReceita7Dias()
        {
            List<Receita> receitas = Receitas.FindAll(x => x.Data >= DateTime.Now.AddDays(-7));
            return receitas;
        }
        //busca as receitas do mês vigente com a data do sistema
        public List<Receita> BuscaReceitaMes()
        {
            List<Receita> receitas = Receitas.FindAll(x => x.Data.Month == DateTime.Now.Month);
            return receitas;
        }
        //busca as despesas dos ultimos 7 dias com a data do sistema
        public List<Despesa> BuscaDespesa7Dias()
        {
            List<Despesa> despesas = Despesas.FindAll(x => x.Data >= DateTime.Now.AddDays(-7));
            return despesas;
        }
        //busca as Despesas do mês vigente com a data do sistema
        public List<Despesa> BuscaDespesaMes()
        {
            List<Despesa> despas = Despesas.FindAll(x => x.Data.Month == DateTime.Now.Month);
            return despas;
        }
    }
}
