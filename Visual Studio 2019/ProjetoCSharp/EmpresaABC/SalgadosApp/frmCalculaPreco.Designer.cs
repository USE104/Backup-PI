
namespace SalgadosApp
{
    partial class frmCalculaPreco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculaPreco));
            this.lblCalculaPrecos = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.lblPrecoProduto = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCalculaPrecos
            // 
            this.lblCalculaPrecos.AutoSize = true;
            this.lblCalculaPrecos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculaPrecos.Location = new System.Drawing.Point(212, 19);
            this.lblCalculaPrecos.Name = "lblCalculaPrecos";
            this.lblCalculaPrecos.Size = new System.Drawing.Size(189, 29);
            this.lblCalculaPrecos.TabIndex = 0;
            this.lblCalculaPrecos.Text = "Calcula Preços";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNome.Location = new System.Drawing.Point(204, 95);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 17);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCusto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrecoCusto.Location = new System.Drawing.Point(141, 137);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(110, 17);
            this.lblPrecoCusto.TabIndex = 2;
            this.lblPrecoCusto.Text = "Preço de Custo";
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPorcentagem.Location = new System.Drawing.Point(155, 179);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(96, 17);
            this.lblPorcentagem.TabIndex = 3;
            this.lblPorcentagem.Text = "Porcentagem";
            // 
            // lblPrecoProduto
            // 
            this.lblPrecoProduto.AutoSize = true;
            this.lblPrecoProduto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrecoProduto.Location = new System.Drawing.Point(129, 217);
            this.lblPrecoProduto.Name = "lblPrecoProduto";
            this.lblPrecoProduto.Size = new System.Drawing.Size(122, 17);
            this.lblPrecoProduto.TabIndex = 4;
            this.lblPrecoProduto.Text = "Preço do Produto";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(270, 92);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(146, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Location = new System.Drawing.Point(270, 134);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(83, 20);
            this.txtPrecoCusto.TabIndex = 1;
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.Location = new System.Drawing.Point(270, 176);
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(83, 20);
            this.txtPorcentagem.TabIndex = 2;
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Location = new System.Drawing.Point(270, 214);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(83, 20);
            this.txtPrecoProduto.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalcular.Location = new System.Drawing.Point(461, 159);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(97, 75);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(461, 253);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 75);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmCalculaPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.txtPorcentagem);
            this.Controls.Add(this.txtPrecoCusto);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblPrecoProduto);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.lblPrecoCusto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCalculaPrecos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalculaPreco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculaPreco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculaPrecos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Label lblPrecoProduto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.TextBox txtPorcentagem;
        private System.Windows.Forms.TextBox txtPrecoProduto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
    }
}