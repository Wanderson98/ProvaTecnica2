using ControleTeste.Telas;
using ControleTeste.Entidades.Enums;
using ControleTeste.Entidades;
using System.Collections.Generic;

namespace ControleTeste.Servicos
{
    public class CalculosReceita
    {
      List<Receita> Receita = new List<Receita>();
        

        public CalculosReceita(List<Receita> receita)
        {
            Receita = receita;
        }

        public double ValorTotal()
        {
            double total = 0;   
            foreach (Receita receita in Receita)
            {
                total += receita.Valor;
            }
            return total;
        }


    }
}
