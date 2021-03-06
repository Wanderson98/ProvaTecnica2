using ControleTeste.Entidades;
using ControleTeste.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace ControleTeste.Telas
{
    public partial class ControleReceitas : Form
    {   //atributo
        List<Receita> Receitas = new List<Receita>();
        //construtor
        public ControleReceitas(List<Receita> receitas)
        {
            InitializeComponent();
            CarregarTema();
            Receitas = receitas;

        }

        //carregar tema aos botoes
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
        //inicialização do form
        private void ControleReceitas_Load(object sender, EventArgs e)
        {
            cbbCategorias.Items.AddRange(Enum.GetNames(typeof(CategoriasReceitas)));
            CarregarTema();
            CarregarLista();
            if (Receitas.Count <= 0)
            {
                btnRemover.Enabled = false;
                btnAtualizar.Enabled = false;
                btnSelecionar.Enabled = false;
                btnBuscar.Enabled = false;
            }
        }
        //adicionar
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Confirmar Inclusão ?", "Inserir", MessageBoxButtons.OKCancel);
                if (DialogResult == DialogResult.OK)
                {
                    CategoriasReceitas categoria = (CategoriasReceitas)cbbCategorias.SelectedIndex;

                    double valor = double.Parse(txtValor.Text);
                    Receita receita = new Receita(txtNomeReceita.Text, dttReceita.Value, valor, categoria);
                    Receita.Adicionar(Receitas, receita);
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

        //carregar lista
        }
        private void CarregarLista()
        {
            ltbReceitas.Items.Clear();
            foreach (Receita item in Receitas)
            {
                ltbReceitas.Items.Add(item);
            }
        }
        //limpar campos
        private void LimparCampos()
        {
            txtNomeReceita.Text = null;
            txtValor.Text = null;
            dttReceita.Text = null;
            btnAdicionar.Enabled = true;
        }
        //remover
        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Tem certeza que deseja remover ?", "Exclusão", MessageBoxButtons.OKCancel);
                if (DialogResult == DialogResult.OK)
                {
                    Receita receita = ltbReceitas.SelectedItem as Receita;
                    Receita.Remover(Receitas, receita);
                }

                CarregarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                LimparCampos();
            }
        }
        //atualizar
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Confirmar Alteração ?", "Atualizar", MessageBoxButtons.OKCancel);
                if (DialogResult == DialogResult.OK)
                {
                    int index = ltbReceitas.SelectedIndex;
                    string nome = txtNomeReceita.Text;
                    CategoriasReceitas categorias = (CategoriasReceitas)cbbCategorias.SelectedIndex;
                    DateTime data = dttReceita.Value;
                    double valor = double.Parse(txtValor.Text);

                    Receita.Atualizar(Receitas, index, nome, categorias, valor, data);
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
        //botao para carregar os dados para serem atualizados
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Receita receita = ltbReceitas.SelectedItem as Receita;
            txtNomeReceita.Text = receita.Nome;
            txtValor.Text = receita.Valor.ToString("F2");
            dttReceita.Value = receita.Data;
            cbbCategorias.SelectedIndex = (int)receita.Categoria;
        }
        //açao para carregar os dados para serem atualizados atraves do double click 
        private void ltbReceitas_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Receita receita = ltbReceitas.SelectedItem as Receita;
            txtNomeReceita.Text = receita.Nome;
            txtValor.Text = receita.Valor.ToString("F2");
            dttReceita.Value = receita.Data;
            cbbCategorias.SelectedIndex = (int)receita.Categoria;
            btnRemover.Enabled = true;
            btnAtualizar.Enabled = true;
            btnSelecionar.Enabled = true;
            btnBuscar.Enabled = true;
            btnAdicionar.Enabled = false;
        }
        //Limpar campos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        //buscar por parte do nome
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Receita> lista = Receita.Buscar(Receitas, txtBusca.Text);
                if (lista.Count < 1)
                {
                    MessageBox.Show("Nenhuma Receita Encontrada");
                }
                else
                {
                    ltbReceitas.Items.Clear();
                    foreach (Receita item in lista)
                    {
                        ltbReceitas.Items.Add(item);
                    }
                    txtBusca.Text = null;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                LimparCampos();
            }

        }
        //ativação de botoes de acordo com selecao 
        private void ltbReceitas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btnRemover.Enabled = true;
            btnAtualizar.Enabled = true;
            btnSelecionar.Enabled = true;
            btnBuscar.Enabled = true;
            btnAdicionar.Enabled = false;
        }
    }
}
