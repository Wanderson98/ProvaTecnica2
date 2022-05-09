using ControleTeste.Entidades;
using ControleTeste.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ControleTeste.Telas
{
    public partial class CtrlMovimentacoes : Form
    {
        private List<Despesa> Despesas = new List<Despesa>();
        private List<Receita> Receitas = new List<Receita>();

        public CtrlMovimentacoes(List<Despesa> despesas, List<Receita> receitas)
        {
            InitializeComponent();
            CarregarTema();
            Despesas = despesas;
            Receitas = receitas;
            rbtnTodos.Checked = true;

        }

        private void Movimentacoes_Load(object sender, EventArgs e)
        {
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
            ltbMovimentacoes.Items.Clear();
            foreach (Receita receita in Receitas)
            {
                ltbMovimentacoes.Items.Add(receita);
            }
            foreach (Despesa despesa in Despesas)
            {
                ltbMovimentacoes.Items.Add(despesa);
            }

        }
        private void CarregarListaReceita()
        {
            ltbMovimentacoes.Items.Clear();
            foreach (Receita receita in Receitas)
            {
                ltbMovimentacoes.Items.Add(receita);
            }
        }

        private void CarregarListaDespesa()
        {
            ltbMovimentacoes.Items.Clear();
            foreach (Despesa despesa in Despesas)
            {
                ltbMovimentacoes.Items.Add(despesa);
            }
        }

        private void rbtnTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTodos.Checked)
            {
                CarregarLista();
                cbbCategoria.Items.Clear();
            }

        }

        private void rbtnReceitas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnReceitas.Checked)
            {
                cbbCategoria.Items.Clear();
                cbbCategoria.Items.AddRange(Enum.GetNames(typeof(CategoriasReceitas)));
                CarregarListaReceita();

            }
        }

        private void rbtnDespesa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDespesa.Checked)
            {
                CarregarListaDespesa();
                cbbCategoria.Items.Clear();
                string[] elemCategoria = Enum.GetNames(typeof(CategoriasDespesas));
                foreach (var item in elemCategoria)
                {
                    cbbCategoria.Items.Add(item.Replace("_", " "));
                }
            }
        }

        private void cbbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ltbMovimentacoes.Items.Clear();
                if (rbtnDespesa.Checked)
                {
                    List<Despesa> filtro = Despesas.FindAll(x => x.Categoria == (CategoriasDespesas)cbbCategoria.SelectedIndex);
                    foreach (Despesa item in filtro)
                    {
                        ltbMovimentacoes.Items.Add(item);
                    }
                }
                else if (rbtnReceitas.Checked)
                {
                    List<Receita> filtro = Receitas.FindAll(x => x.Categoria == (CategoriasReceitas)cbbCategoria.SelectedIndex);
                    foreach (Receita item in filtro)
                    {
                        ltbMovimentacoes.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }


        }


    }
}
