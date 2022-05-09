using System;

namespace ControleTeste.Entidades
{
    public abstract class Movimentacoes
    {
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }

        protected Movimentacoes(string nome, DateTime data, double valor)
        {
            Nome = nome;
            Data = data;
            Valor = valor;
        }

    }
}
