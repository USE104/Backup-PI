
namespace SalgadosApp
{
    partial class frmJanela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJanela));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(163, 98);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(163, 187);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 25);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail";
            this.lblEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(238, 91);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(193, 33);
            this.txtNome.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(238, 180);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 33);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(168, 287);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 36);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(330, 287);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(101, 36);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // frmJanela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 409);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmJanela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalgadosAPP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnSair;
    }
}

