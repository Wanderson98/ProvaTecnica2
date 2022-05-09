using ControleTeste.Entidades;
using ControleTeste.Servicos;
using ControleTeste.Telas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace ControleTeste
{
    public partial class Form1 : Form
    {//atributos
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private List<Despesa> despesas = new List<Despesa>();
        private List<Receita> receitas = new List<Receita>();
   
    //construtor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnFechar.Visible = false;
            pictureBox2.Visible = false;
        }
        //metodo que gera cor aleatoria como tema
        private Color SelectThemeColor()
        {
            int index = random.Next(Temas.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(Temas.ColorList.Count);
            }
            tempIndex = index;
            string cor = Temas.ColorList[index];
            return ColorTranslator.FromHtml(cor);
        }
        //metodo para mudar a cor do botao e tema da tela
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitulo.BackColor = color;
                    panelLogo.BackColor = Temas.ChangeColorBrightness(color, -0.1);
                    Temas.CorPrimaria = color;
                    Temas.CorSecundaria = Temas.ChangeColorBrightness(color, -0.1);
                    btnFechar.Visible = true;
                    pictureBox2.Visible = true;
                }
            }
        }
        //metodo para desativar as alteraçoes nos butoes
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        // metodo para abrir um novo form dentro do panel do form1
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelInicial.Controls.Add(childForm);
            this.panelInicial.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitulo.Text = childForm.Text;
        }
        //chamar form receitas
        private void btnReceitas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ControleReceitas(receitas), sender);
            ActiveButton(sender);

        }
        //chamar form despesas
        private void btnDespesas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ControleDespesas(despesas), sender);
            ActiveButton(sender);
        }
        //chamar form home
        private void btnHome_Click(object sender, EventArgs e)
        {

            OpenChildForm(new TelaInicial(despesas, receitas), sender);
            ActiveButton(sender);
        }
        //resetar para config inicial
        private void Reset()
        {
            DisableButton();
            lblTitulo.Text = "HOME";
            panelTitulo.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            pictureBox2.Visible = false;
        }
        // chamar form movimentacoes
        private void btnMovimentacoes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CtrlMovimentacoes(despesas, receitas), sender);
            ActiveButton(sender);
        }
        //botão para voltar a tela inicial
        private void button1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
            btnFechar.Visible = false;
        }
    }
}
