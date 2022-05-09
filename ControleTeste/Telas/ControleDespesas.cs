using ControleTeste.Entidades;
using ControleTeste.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ControleTeste.Telas
{
    public partial class ControleDespesas : Form
    {
        List<Despesa> Despesas = new List<Despesa>();
        public ControleDespesas(List<Despesa> despesas)
        {
            InitializeComponent();
            CarregarTema();
            Despesas = despesas;
        }

        private void ControleDespesas_Load(object sender, EventArgs e)
        {
            string[] elemCategoria = Enum.GetNames(typeof(CategoriasDespesas));
            foreach (var item in elemCategoria)
            {
                cbbCategorias.Items.Add(item.Replace("_", " "));
            }
            CarregarTema();
            CarregarLista();
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
        private void CarregarLista()
        {
            ltbDespesas.Items.Clear();
            foreach (Despesa item in Despesas)
            {
                ltbDespesas.Items.Add(item);
            }
        }
        private void LimparCampos()
        {
            txtNomeDespesa.Text = null;
            txtValor.Text = null;
            dttDespesa.Text = null;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Despesa despesa = ltbDespesas.SelectedItem as Despesa;
            Despesa.Remover(Despesas, despesa);
            CarregarLista();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int index = ltbDespesas.SelectedIndex;
            string nome = txtNomeDespesa.Text;
            CategoriasDespesas categorias = (CategoriasDespesas)cbbCategorias.SelectedIndex;
            DateTime data = dttDespesa.Value;
            double valor = double.Parse(txtValor.Text);
            Despesa.Atualizar(Despesas, index, nome, categorias, valor, data);
            CarregarLista();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Despesa despesa = ltbDespesas.SelectedItem as Despesa;
            txtNomeDespesa.Text = despesa.Nome;
            txtValor.Text = despesa.Valor.ToString("F2");
            dttDespesa.Value = despesa.Data;
            cbbCategorias.SelectedIndex = (int)despesa.Categoria;
        }

        private void ltbDespesas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Despesa despesa = ltbDespesas.SelectedItem as Despesa;
            txtNomeDespesa.Text = despesa.Nome;
            txtValor.Text = despesa.Valor.ToString("F2");
            dttDespesa.Value = despesa.Data;
            cbbCategorias.SelectedIndex = (int)despesa.Categoria;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CategoriasDespesas categoria = (CategoriasDespesas)cbbCategorias.SelectedIndex;

            double valor = -double.Parse(txtValor.Text);
            Despesa despesa = new Despesa(txtNomeDespesa.Text, dttDespesa.Value, valor, categoria);
            Despesa.Adicionar(Despesas, despesa);
            CarregarLista();
            LimparCampos();
        }
    }
}
