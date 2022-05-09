namespace ControleTeste
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMovimentacoes = new System.Windows.Forms.Button();
            this.btnDespesas = new System.Windows.Forms.Button();
            this.btnReceitas = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelInicial = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelInicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnMovimentacoes);
            this.panelMenu.Controls.Add(this.btnDespesas);
            this.panelMenu.Controls.Add(this.btnReceitas);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 580);
            this.panelMenu.TabIndex = 0;
            // 
            // btnMovimentacoes
            // 
            this.btnMovimentacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovimentacoes.FlatAppearance.BorderSize = 0;
            this.btnMovimentacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimentacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimentacoes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMovimentacoes.Image = global::ControleTeste.Properties.Resources.todas;
            this.btnMovimentacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimentacoes.Location = new System.Drawing.Point(0, 260);
            this.btnMovimentacoes.Name = "btnMovimentacoes";
            this.btnMovimentacoes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMovimentacoes.Size = new System.Drawing.Size(200, 60);
            this.btnMovimentacoes.TabIndex = 2;
            this.btnMovimentacoes.Text = "    Movimentações";
            this.btnMovimentacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovimentacoes.UseVisualStyleBackColor = true;
            this.btnMovimentacoes.Click += new System.EventHandler(this.btnMovimentacoes_Click);
            // 
            // btnDespesas
            // 
            this.btnDespesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDespesas.FlatAppearance.BorderSize = 0;
            this.btnDespesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespesas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDespesas.Image = global::ControleTeste.Properties.Resources.Despesas;
            this.btnDespesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDespesas.Location = new System.Drawing.Point(0, 200);
            this.btnDespesas.Name = "btnDespesas";
            this.btnDespesas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDespesas.Size = new System.Drawing.Size(200, 60);
            this.btnDespesas.TabIndex = 4;
            this.btnDespesas.Text = "    Despesas";
            this.btnDespesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDespesas.UseVisualStyleBackColor = true;
            this.btnDespesas.Click += new System.EventHandler(this.btnDespesas_Click);
            // 
            // btnReceitas
            // 
            this.btnReceitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceitas.FlatAppearance.BorderSize = 0;
            this.btnReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceitas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReceitas.Image = global::ControleTeste.Properties.Resources.Receitas;
            this.btnReceitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceitas.Location = new System.Drawing.Point(0, 140);
            this.btnReceitas.Name = "btnReceitas";
            this.btnReceitas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReceitas.Size = new System.Drawing.Size(200, 60);
            this.btnReceitas.TabIndex = 3;
            this.btnReceitas.Text = "    Receitas";
            this.btnReceitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceitas.UseVisualStyleBackColor = true;
            this.btnReceitas.Click += new System.EventHandler(this.btnReceitas_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHome.Image = global::ControleTeste.Properties.Resources.dashboard;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 80);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(200, 60);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "    DashBoard";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitulo.Controls.Add(this.btnFechar);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(200, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(754, 80);
            this.panelTitulo.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.LightGray;
            this.btnFechar.Location = new System.Drawing.Point(0, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 80);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "x";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(312, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(78, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "HOME";
            // 
            // panelInicial
            // 
            this.panelInicial.Controls.Add(this.pictureBox1);
            this.panelInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicial.Location = new System.Drawing.Point(200, 80);
            this.panelInicial.Name = "panelInicial";
            this.panelInicial.Size = new System.Drawing.Size(754, 500);
            this.panelInicial.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControleTeste.Properties.Resources.logo_ok_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(101, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 390);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ControleTeste.Properties.Resources.logo_ok_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(45, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 580);
            this.Controls.Add(this.panelInicial);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelInicial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDespesas;
        private System.Windows.Forms.Button btnReceitas;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelInicial;
        private System.Windows.Forms.Button btnMovimentacoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

