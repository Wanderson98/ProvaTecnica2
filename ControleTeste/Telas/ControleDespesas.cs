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
        private List<Despesa> Despesas = new List<Despesa>();
        public ControleDespesas(List<Despesa> despesas)
        {
            InitializeComponent();
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
            if (Despesas.Count <= 0)
            {
                btnRemover.Enabled = false;
                btnAtualizar.Enabled = false;
                btnSelecionar.Enabled = false;
                btnBuscar.Enabled = false;
            }

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
            btnAdicionar.Enabled = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Tem certeza que deseja remover ?", "Exclusão", MessageBoxButtons.OKCancel);
                if (DialogResult == DialogResult.OK)
                {
                    Despesa despesa = ltbDespesas.SelectedItem as Despesa;
                    Despesa.Remover(Despesas, despesa);
                    CarregarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                LimparCampos();
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Confirmar Alteração ?", "Atualizar", MessageBoxButtons.OKCancel);
                if (DialogResult == DialogResult.OK)
                {
                    int index = ltbDespesas.SelectedIndex;
                    string nome = txtNomeDespesa.Text;
                    CategoriasDespesas categorias = (CategoriasDespesas)cbbCategorias.SelectedIndex;
                    DateTime data = dttDespesa.Value;
                    double valor = double.Parse(txtValor.Text);
                    Despesa.Atualizar(Despesas, index, nome, categorias, valor, data);
                    CarregarLista();
                    LimparCampos();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                LimparCampos();
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
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
            try
            {
                DialogResult = MessageBox.Show("Confirmar Inclusão ?", "Inserir", MessageBoxButtons.OKCancel);
                if (DialogResult == DialogResult.OK)
                {
                    CategoriasDespesas categoria = (CategoriasDespesas)cbbCategorias.SelectedIndex;

                    double valor = -double.Parse(txtValor.Text);
                    Despesa despesa = new Despesa(txtNomeDespesa.Text, dttDespesa.Value, valor, categoria);
                    Despesa.Adicionar(Despesas, despesa);
                    btnRemover.Enabled = true;
                    btnAtualizar.Enabled = true;
                    btnSelecionar.Enabled = true;
                    btnBuscar.Enabled = true;
                }
                CarregarLista();
                LimparCampos();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                LimparCampos();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Despesa> despesas = Despesa.Buscar(Despesas, txtBusca.Text);
            if (despesas.Count < 1)
            {
                MessageBox.Show("Nenhuma Despesa Encontrada");
            }
            else
            {
                ltbDespesas.Items.Clear();
                foreach (Despesa despesa in despesas)
                {
                    ltbDespesas.Items.Add(despesa);
                }
                txtBusca.Text = null;
            }
        }

        private void ltbDespesas_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Despesa despesa = ltbDespesas.SelectedItem as Despesa;
            txtNomeDespesa.Text = despesa.Nome;
            txtValor.Text = despesa.Valor.ToString("F2");
            dttDespesa.Value = despesa.Data;
            cbbCategorias.SelectedIndex = (int)despesa.Categoria;
            btnRemover.Enabled = true;
            btnAtualizar.Enabled = true;
            btnSelecionar.Enabled = true;
            btnBuscar.Enabled = true;
            btnAdicionar.Enabled = false;
        }

        private void ltbDespesas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btnRemover.Enabled = true;
            btnAtualizar.Enabled = true;
            btnSelecionar.Enabled = true;
            btnBuscar.Enabled = true;
            btnAdicionar.Enabled = false;
        }

        private void txtNomeDespesa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnAdicionar.Enabled = true;
        }
    }
}
