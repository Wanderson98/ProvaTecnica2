using ControleTeste.Entidades;
using ControleTeste.Entidades.Enums;
using ControleTeste.Servicos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ControleTeste.Telas
{
    public partial class TelaInicial : Form
    {//atributos
        private List<Despesa> Despesas = new List<Despesa>();
        private List<Receita> Receitas = new List<Receita>();
        private double valorTotal;
        private double valorDespesas;
        private double valorReceita;
        private ControleMovimentacoes controle;
        string[] filtro = { "Todos", "7 dias", "Este Mês" };
        //construtor
        public TelaInicial(List<Despesa> despesas, List<Receita> receitas)
        {
            InitializeComponent();
            Despesas = despesas;
            Receitas = receitas;
            CarregarTema();

        }
        //carregar o tema
        private void CarregarTema()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Temas.CorPrimaria;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Temas.CorSecundaria;

                }
            }
        }
        //config inicial 
        private void TelaInicial_Load(object sender, EventArgs e)
        {
            foreach (var item in filtro)
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndex = 0;
            CarregarTema();
            panelValorTotal.BackColor = Temas.ChangeColorBrightness(Temas.CorPrimaria, 0.8);
            panelValorReceita.BackColor = Temas.ChangeColorBrightness(Temas.CorPrimaria, 0.8);
            panelValorDespesa.BackColor = Temas.ChangeColorBrightness(Temas.CorPrimaria, 0.8);

        }
        //calcular valor total receitas e despesas
        private void CalcularValorTotal(List<Receita> receita, List<Despesa> despesa)
        {
            foreach (Receita receit in receita)
            {
                valorTotal += receit.Valor;
            }
            foreach (Despesa despes in despesa)
            {
                valorTotal += despes.Valor;
            }
        }
        //calcular valor total receitas
        private void CalcularTotalReceita(List<Receita> receita)
        {
            foreach (Receita receit in receita)
            {
                valorReceita += receit.Valor;
            }
        }
        //calcular valor total despesas
        private void CalcularTotalDespesa(List<Despesa> despesa)
        {
            foreach (Despesa despes in despesa)
            {
                valorDespesas += despes.Valor;
            }
        }
        //chamada de funcoes para carregamento de dados de acordo com a seleção
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                ResetValores();
                CalcularValorTotal(Receitas, Despesas);
                CalcularTotalDespesa(Despesas);
                CalcularTotalReceita(Receitas);
                CarregarGraficoReceita(Receitas);
                CarregarGraficoDespesas(Despesas);
                CarregarValores();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                ResetValores();
                controle = new ControleMovimentacoes(Receitas, Despesas);
                List<Despesa> despesa = controle.BuscaDespesa7Dias();
                List<Receita> receita = controle.BuscaReceita7Dias();
                CalcularValorTotal(receita, despesa);
                CalcularTotalDespesa(despesa);
                CalcularTotalReceita(receita);
                CarregarGraficoReceita(receita);
                CarregarGraficoDespesas(despesa);
                CarregarValores();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                ResetValores();
                controle = new ControleMovimentacoes(Receitas, Despesas);
                List<Despesa> despesa = controle.BuscaDespesaMes();
                List<Receita> receita = controle.BuscaReceitaMes();
                CalcularValorTotal(receita, despesa);
                CalcularTotalDespesa(despesa);
                CalcularTotalReceita(receita);
                CarregarGraficoReceita(receita);
                CarregarGraficoDespesas(despesa);
                CarregarValores();
            }
        }
        //carregar valores nas labels
        private void CarregarValores()
        {
            if (valorTotal > 0)
            {
                lblValorTotal.ForeColor = Color.Green;
            }
            else if (valorTotal < 0)
            {
                lblValorTotal.ForeColor = Color.Red;
            }
            else
            {
                lblValorTotal.ForeColor = Color.Black;
            }
            lblValorTotal.Text = $"R$ {valorTotal:F2}";
            lblValorReceita.ForeColor = Color.Green;
            lblValorReceita.Text = $"R$ {valorReceita:F2}";
            lblValorDespesa.ForeColor = Color.Red;
            lblValorDespesa.Text = $"R$ {valorDespesas:F2}";
        }
        //resetar valores para 0, para nas chamadas das funcoes não haja valores somados indevidamente
        private void ResetValores()
        {
            valorTotal = 0;
            valorReceita = 0;
            valorDespesas = 0;
        }
        //carrega o grafico com dados das receitas
        private void CarregarGraficoReceita(List<Receita> receitas)
        {
            grafReceita.Series.Clear();
            string[] rece = Enum.GetNames(typeof(CategoriasReceitas));
            foreach (string recei in rece)
            {
                grafReceita.Series.Add(recei);
            }
            for (int i = 0; i < receitas.Count; i++)
            {
                grafReceita.Series[receitas[i].Categoria.ToString()].Points.AddXY("Receitas", receitas[i].Valor);

            }

        } 
        //carrega o grafico com dados das despesas
        private void CarregarGraficoDespesas(List<Despesa> despesas)
        {
            grafDespesa.Series.Clear();

            string[] rece = Enum.GetNames(typeof(CategoriasDespesas));
            foreach (string recei in rece)
            {
                grafDespesa.Series.Add(recei.Replace("_", " "));
            }
            for (int i = 0; i < despesas.Count; i++)
            {
                grafDespesa.Series[despesas[i].Categoria.ToString()].Points.AddXY("Despesas", (despesas[i].Valor * -1));

            }

        }

    }
}

