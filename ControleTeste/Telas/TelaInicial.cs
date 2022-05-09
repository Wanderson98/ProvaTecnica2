using ControleTeste.Entidades;
using ControleTeste.Entidades.Enums;
using ControleTeste.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleTeste.Telas
{
    public partial class TelaInicial : Form
    {
        private List<Despesa> Despesas = new List<Despesa>();
        private List<Receita> Receitas = new List<Receita>();
        private double valorTotal;
        private double valorDespesas;
        private double valorReceita;
        private ControleMovimentacoes controle;
        string[] filtro = { "Todos", "7 dias", "Este Mês" };

        public TelaInicial(List<Despesa> despesas, List<Receita> receitas)
        {
            InitializeComponent();
            Despesas = despesas;
            Receitas = receitas;
            CarregarTema();

        }
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
        private void btnHoje_Click(object sender, EventArgs e)
        {

        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            foreach (var item in filtro)
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndex = 0;


            CarregarTema();
            //CalcularValorTotal(Receitas,Despesas);
            //CalcularTotalDespesa(Despesas);
            //CalcularTotalReceita(Receitas);
            //CarregarValores();



            panelValorTotal.BackColor = Temas.ChangeColorBrightness(Temas.CorPrimaria, 0.8);
            panelValorReceita.BackColor = Temas.ChangeColorBrightness(Temas.CorPrimaria, 0.8);
            panelValorDespesa.BackColor = Temas.ChangeColorBrightness(Temas.CorPrimaria, 0.8);

        }

        private void CalcularValorTotal(List<Receita> receita, List<Despesa> despesa)
        {
            foreach(Receita receit in receita)
            {
                valorTotal += receit.Valor;
            }
            foreach(Despesa despes in despesa)
            {
                valorTotal += despes.Valor;
            }
        }
        private void CalcularTotalReceita(List<Receita> receita)
        {
            foreach (Receita receit in receita)
            {
                valorReceita += receit.Valor;
            }
        }
        private void CalcularTotalDespesa(List<Despesa> despesa)
        {
            foreach (Despesa despes in despesa)
            {
                valorDespesas += despes.Valor;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                ResetValores();
                CalcularValorTotal(Receitas, Despesas);
                CalcularTotalDespesa(Despesas);
                CalcularTotalReceita(Receitas);
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
                CarregarValores();
            } else if (comboBox1.SelectedIndex == 2)
            {
                ResetValores();
                controle = new ControleMovimentacoes(Receitas, Despesas);
                List<Despesa> despesa = controle.BuscaDespesaMes();
                List<Receita> receita = controle.BuscaReceitaMes();
                CalcularValorTotal(receita, despesa);
                CalcularTotalDespesa(despesa);
                CalcularTotalReceita(receita);
                CarregarValores();
            }
        }

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

        private void ResetValores()
        {
            valorTotal = 0;
            valorReceita = 0;
            valorDespesas = 0;
        }
    }
}
