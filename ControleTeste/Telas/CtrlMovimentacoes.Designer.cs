namespace ControleTeste.Telas
{
    partial class CtrlMovimentacoes
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
            this.ltbMovimentacoes = new System.Windows.Forms.ListBox();
            this.rbtnTodos = new System.Windows.Forms.RadioButton();
            this.rbtnReceitas = new System.Windows.Forms.RadioButton();
            this.rbtnDespesa = new System.Windows.Forms.RadioButton();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltbMovimentacoes
            // 
            this.ltbMovimentacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbMovimentacoes.FormattingEnabled = true;
            this.ltbMovimentacoes.ItemHeight = 24;
            this.ltbMovimentacoes.Location = new System.Drawing.Point(23, 72);
            this.ltbMovimentacoes.Name = "ltbMovimentacoes";
            this.ltbMovimentacoes.Size = new System.Drawing.Size(554, 340);
            this.ltbMovimentacoes.TabIndex = 0;
            // 
            // rbtnTodos
            // 
            this.rbtnTodos.AutoSize = true;
            this.rbtnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTodos.Location = new System.Drawing.Point(23, 38);
            this.rbtnTodos.Name = "rbtnTodos";
            this.rbtnTodos.Size = new System.Drawing.Size(82, 28);
            this.rbtnTodos.TabIndex = 1;
            this.rbtnTodos.TabStop = true;
            this.rbtnTodos.Text = "Todos";
            this.rbtnTodos.UseVisualStyleBackColor = true;
            this.rbtnTodos.CheckedChanged += new System.EventHandler(this.rbtnTodos_CheckedChanged);
            // 
            // rbtnReceitas
            // 
            this.rbtnReceitas.AutoSize = true;
            this.rbtnReceitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnReceitas.Location = new System.Drawing.Point(120, 38);
            this.rbtnReceitas.Name = "rbtnReceitas";
            this.rbtnReceitas.Size = new System.Drawing.Size(100, 28);
            this.rbtnReceitas.TabIndex = 1;
            this.rbtnReceitas.TabStop = true;
            this.rbtnReceitas.Text = "Receitas";
            this.rbtnReceitas.UseVisualStyleBackColor = true;
            this.rbtnReceitas.CheckedChanged += new System.EventHandler(this.rbtnReceitas_CheckedChanged);
            // 
            // rbtnDespesa
            // 
            this.rbtnDespesa.AutoSize = true;
            this.rbtnDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDespesa.Location = new System.Drawing.Point(226, 38);
            this.rbtnDespesa.Name = "rbtnDespesa";
            this.rbtnDespesa.Size = new System.Drawing.Size(111, 28);
            this.rbtnDespesa.TabIndex = 1;
            this.rbtnDespesa.TabStop = true;
            this.rbtnDespesa.Text = "Despesas";
            this.rbtnDespesa.UseVisualStyleBackColor = true;
            this.rbtnDespesa.CheckedChanged += new System.EventHandler(this.rbtnDespesa_CheckedChanged);
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.Location = new System.Drawing.Point(609, 72);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(121, 32);
            this.cbbCategoria.TabIndex = 2;
            this.cbbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbbCategoria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(605, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categoria";
            // 
            // CtrlMovimentacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbCategoria);
            this.Controls.Add(this.rbtnDespesa);
            this.Controls.Add(this.rbtnReceitas);
            this.Controls.Add(this.rbtnTodos);
            this.Controls.Add(this.ltbMovimentacoes);
            this.MaximumSize = new System.Drawing.Size(754, 500);
            this.MinimumSize = new System.Drawing.Size(754, 500);
            this.Name = "CtrlMovimentacoes";
            this.Text = "Movimentacoes";
            this.Load += new System.EventHandler(this.Movimentacoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltbMovimentacoes;
        private System.Windows.Forms.RadioButton rbtnTodos;
        private System.Windows.Forms.RadioButton rbtnReceitas;
        private System.Windows.Forms.RadioButton rbtnDespesa;
        private System.Windows.Forms.ComboBox cbbCategoria;
        private System.Windows.Forms.Label label1;
    }
}