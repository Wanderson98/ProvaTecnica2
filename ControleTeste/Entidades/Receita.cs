using ControleTeste.Entidades.Enums;
using System;
using System.Collections.Generic;

namespace ControleTeste.Entidades
{
    public class Receita : Movimentacoes
    {
        public CategoriasReceitas Categoria { get; set; }

        public Receita(string nome, DateTime data, double valor, CategoriasReceitas categoria) : base(nome, data, valor)
        {
            Categoria = categoria;
        }


        public static void Adicionar(List<Receita> receitas, Receita receita)
        {
            receitas.Add(receita);
        }

        public static void Remover(List<Receita> receitas, Receita receita)
        {
            receitas.Remove(receita);
        }
        public static void Atualizar(List<Receita> receitas, int index, string nome, CategoriasReceitas categoria, double valor, DateTime data)
        {
            receitas[index].Valor = valor;
            receitas[index].Data = data;
            receitas[index].Categoria = categoria;
            receitas[index].Nome = nome;

        }
        
        public static List<Receita> Buscar(List<Receita> receitas, string nome)
        {
            List<Receita> receitaResultado = receitas.FindAll(x => x.Nome.Contains(nome));
            return receitaResultado;
        }
        public override string ToString()
        {
            return $"{Nome} - Data: {Data.ToString("dd/MM/yyyy")} - Valor R$ {Valor:F2} - Categoria {Categoria}";
        }
    }
}
