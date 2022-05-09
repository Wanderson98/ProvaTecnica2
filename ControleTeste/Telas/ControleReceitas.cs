using ControleTeste.Entidades;
using ControleTeste.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace ControleTeste.Telas
{
    public partial class ControleReceitas : Form
    {
        List<Receita> Receitas = new List<Receita>();
        public ControleReceitas(List<Receita> receitas)
        {
            InitializeComponent();
            CarregarTema();
            Receitas = receitas;

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

        private void ControleReceitas_Load(object sender, EventArgs e)
        {
            cbbCategorias.Items.AddRange(Enum.GetNames(typeof(CategoriasReceitas)));
            CarregarTema();
            CarregarLista();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CategoriasReceitas categoria = (CategoriasReceitas)cbbCategorias.SelectedIndex;

            double valor = double.Parse(txtValor.Text);
            Receita receita = new Receita(txtNomeReceita.Text, dttReceita.Value, valor, categoria);
            Receita.Adicionar(Receitas, receita);
            CarregarLista();
            LimparCampos();


        }
        private void CarregarLista()
        {
            ltbReceitas.Items.Clear();
            foreach (Receita item in Receitas)
            {
                ltbReceitas.Items.Add(item);
            }
        }

        private void LimparCampos()
        {
            txtNomeReceita.Text = null;
            txtValor.Text = null;
            dttReceita.Text = null;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Receita receita = ltbReceitas.SelectedItem as Receita;
            Receita.Remover(Receitas, receita);
            CarregarLista();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int index = ltbReceitas.SelectedIndex;
            string nome = txtNomeReceita.Text;
            CategoriasReceitas categorias = (CategoriasReceitas)cbbCategorias.SelectedIndex;
            DateTime data = dttReceita.Value;
            double valor = double.Parse(txtValor.Text);
            Receita.Atualizar(Receitas, index, nome, categorias, valor, data);
            CarregarLista();
        }

        private void ltbReceitas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Receita receita = ltbReceitas.SelectedItem as Receita;
            txtNomeReceita.Text = receita.Nome;
            txtValor.Text = receita.Valor.ToString("F2");
            dttReceita.Value = receita.Data;
            cbbCategorias.SelectedIndex = (int)receita.Categoria;
        }

        private void ltbReceitas_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Receita receita = ltbReceitas.SelectedItem as Receita;
            txtNomeReceita.Text = receita.Nome;
            txtValor.Text = receita.Valor.ToString("F2");
            dttReceita.Value = receita.Data;
            cbbCategorias.SelectedIndex = (int)receita.Categoria;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
