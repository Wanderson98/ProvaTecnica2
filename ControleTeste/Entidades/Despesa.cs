using ControleTeste.Entidades.Enums;
using System;
using System.Collections.Generic;

namespace ControleTeste.Entidades
{
    public class Despesa : Movimentacoes
    {
        public CategoriasDespesas Categoria { get; set; }

        public Despesa(string nome, DateTime data, double valor, CategoriasDespesas categoria) : base(nome, data, valor)
        {
            Categoria = categoria;
        }

        public static void Adicionar(List<Despesa> despesas, Despesa despesa)
        {
            despesas.Add(despesa);
        }

        public static void Remover(List<Despesa> despesas, Despesa despesa)
        {
            despesas.Remove(despesa);
        }
        public static void Atualizar(List<Despesa> despesas, int index, string nome, CategoriasDespesas categoria, double valor, DateTime data)
        {
            despesas[index].Valor = valor;
            despesas[index].Data = data;
            despesas[index].Categoria = categoria;
            despesas[index].Nome = nome;

        }

        public override string ToString()
        {
            return $"{Nome} - Data: {Data.ToString("dd/MM/yyyy")} - Valor R$ {Valor:F2} - Categoria {Categoria}";
        }
    }
}
