namespace ControleTeste.Telas
{
    partial class ControleDespesas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cbbCategorias = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dttDespesa = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeDespesa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.ltbDespesas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(594, 54);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 51);
            this.btnLimpar.TabIndex = 37;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(594, 370);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(117, 33);
            this.btnSelecionar.TabIndex = 35;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(594, 278);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(117, 51);
            this.btnAtualizar.TabIndex = 34;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(594, 207);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(117, 51);
            this.btnRemover.TabIndex = 33;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(594, 135);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(117, 51);
            this.btnAdicionar.TabIndex = 32;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cbbCategorias
            // 
            this.cbbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategorias.FormattingEnabled = true;
            this.cbbCategorias.Location = new System.Drawing.Point(404, 88);
            this.cbbCategorias.Name = "cbbCategorias";
            this.cbbCategorias.Size = new System.Drawing.Size(166, 32);
            this.cbbCategorias.TabIndex = 31;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(89, 90);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(129, 29);
            this.txtValor.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Valor";
            // 
            // dttDespesa
            // 
            this.dttDespesa.CustomFormat = "dd/MM/yyyy";
            this.dttDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttDespesa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttDespesa.Location = new System.Drawing.Point(404, 42);
            this.dttDespesa.Name = "dttDespesa";
            this.dttDespesa.Size = new System.Drawing.Size(166, 29);
            this.dttDespesa.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Data";
            // 
            // txtNomeDespesa
            // 
            this.txtNomeDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDespesa.Location = new System.Drawing.Point(89, 42);
            this.txtNomeDespesa.Name = "txtNomeDespesa";
            this.txtNomeDespesa.Size = new System.Drawing.Size(237, 29);
            this.txtNomeDespesa.TabIndex = 25;
            this.txtNomeDespesa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtNomeDespesa_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nome";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(232, 408);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 26);
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(27, 408);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(199, 26);
            this.txtBusca.TabIndex = 38;
            // 
            // ltbDespesas
            // 
            this.ltbDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbDespesas.FormattingEnabled = true;
            this.ltbDespesas.ItemHeight = 24;
            this.ltbDespesas.Location = new System.Drawing.Point(27, 135);
            this.ltbDespesas.Name = "ltbDespesas";
            this.ltbDespesas.Size = new System.Drawing.Size(543, 268);
            this.ltbDespesas.TabIndex = 40;
            this.ltbDespesas.SelectedIndexChanged += new System.EventHandler(this.ltbDespesas_SelectedIndexChanged_1);
            this.ltbDespesas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltbDespesas_MouseDoubleClick_1);
            // 
            // ControleDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 461);
            this.Controls.Add(this.ltbDespesas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cbbCategorias);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dttDespesa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeDespesa);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(754, 500);
            this.MinimumSize = new System.Drawing.Size(754, 500);
            this.Name = "ControleDespesas";
            this.Text = "Controle Despesas";
            this.Load += new System.EventHandler(this.ControleDespesas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cbbCategorias;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dttDespesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeDespesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.ListBox ltbDespesas;
    }
}