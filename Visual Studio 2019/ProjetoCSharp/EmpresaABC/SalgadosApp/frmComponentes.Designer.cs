
namespace SalgadosApp
{
    partial class frmComponentes
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
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.gpbPreferencias = new System.Windows.Forms.GroupBox();
            this.ckbLivro = new System.Windows.Forms.CheckBox();
            this.ckbAcademia = new System.Windows.Forms.CheckBox();
            this.ckbCelular = new System.Windows.Forms.CheckBox();
            this.ckbComida = new System.Windows.Forms.CheckBox();
            this.ckbBebida = new System.Windows.Forms.CheckBox();
            this.ckbCorrer = new System.Windows.Forms.CheckBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblListaEscolar = new System.Windows.Forms.Label();
            this.ltbListaEscolar = new System.Windows.Forms.ListBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.gpbSexo.SuspendLayout();
            this.gpbPreferencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rdbFeminino);
            this.gpbSexo.Controls.Add(this.rdbMasculino);
            this.gpbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSexo.Location = new System.Drawing.Point(38, 30);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(180, 109);
            this.gpbSexo.TabIndex = 0;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(25, 72);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(81, 20);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(25, 37);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(87, 20);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // gpbPreferencias
            // 
            this.gpbPreferencias.Controls.Add(this.ckbCorrer);
            this.gpbPreferencias.Controls.Add(this.ckbBebida);
            this.gpbPreferencias.Controls.Add(this.ckbComida);
            this.gpbPreferencias.Controls.Add(this.ckbCelular);
            this.gpbPreferencias.Controls.Add(this.ckbAcademia);
            this.gpbPreferencias.Controls.Add(this.ckbLivro);
            this.gpbPreferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPreferencias.Location = new System.Drawing.Point(38, 188);
            this.gpbPreferencias.Name = "gpbPreferencias";
            this.gpbPreferencias.Size = new System.Drawing.Size(180, 250);
            this.gpbPreferencias.TabIndex = 1;
            this.gpbPreferencias.TabStop = false;
            this.gpbPreferencias.Text = "Preferencias";
            // 
            // ckbLivro
            // 
            this.ckbLivro.AutoSize = true;
            this.ckbLivro.Location = new System.Drawing.Point(25, 53);
            this.ckbLivro.Name = "ckbLivro";
            this.ckbLivro.Size = new System.Drawing.Size(56, 20);
            this.ckbLivro.TabIndex = 0;
            this.ckbLivro.Text = "Livro";
            this.ckbLivro.UseVisualStyleBackColor = true;
            // 
            // ckbAcademia
            // 
            this.ckbAcademia.AutoSize = true;
            this.ckbAcademia.Location = new System.Drawing.Point(25, 77);
            this.ckbAcademia.Name = "ckbAcademia";
            this.ckbAcademia.Size = new System.Drawing.Size(89, 20);
            this.ckbAcademia.TabIndex = 1;
            this.ckbAcademia.Text = "Academia";
            this.ckbAcademia.UseVisualStyleBackColor = true;
            // 
            // ckbCelular
            // 
            this.ckbCelular.AutoSize = true;
            this.ckbCelular.Location = new System.Drawing.Point(25, 101);
            this.ckbCelular.Name = "ckbCelular";
            this.ckbCelular.Size = new System.Drawing.Size(69, 20);
            this.ckbCelular.TabIndex = 2;
            this.ckbCelular.Text = "Celular";
            this.ckbCelular.UseVisualStyleBackColor = true;
            // 
            // ckbComida
            // 
            this.ckbComida.AutoSize = true;
            this.ckbComida.Location = new System.Drawing.Point(25, 125);
            this.ckbComida.Name = "ckbComida";
            this.ckbComida.Size = new System.Drawing.Size(74, 20);
            this.ckbComida.TabIndex = 3;
            this.ckbComida.Text = "Comida";
            this.ckbComida.UseVisualStyleBackColor = true;
            // 
            // ckbBebida
            // 
            this.ckbBebida.AutoSize = true;
            this.ckbBebida.Location = new System.Drawing.Point(25, 149);
            this.ckbBebida.Name = "ckbBebida";
            this.ckbBebida.Size = new System.Drawing.Size(71, 20);
            this.ckbBebida.TabIndex = 4;
            this.ckbBebida.Text = "Bebida";
            this.ckbBebida.UseVisualStyleBackColor = true;
            // 
            // ckbCorrer
            // 
            this.ckbCorrer.AutoSize = true;
            this.ckbCorrer.Location = new System.Drawing.Point(25, 173);
            this.ckbCorrer.Name = "ckbCorrer";
            this.ckbCorrer.Size = new System.Drawing.Size(64, 20);
            this.ckbCorrer.TabIndex = 5;
            this.ckbCorrer.Text = "Correr";
            this.ckbCorrer.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(274, 30);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 16);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado";
            // 
            // cboEstado
            // 
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "São Paulo",
            "Belo Horizonte",
            "Paraná",
            "Ceará",
            "Rio de Janeiro",
            "Acre",
            "Bahia"});
            this.cboEstado.Location = new System.Drawing.Point(277, 58);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 24);
            this.cboEstado.TabIndex = 3;
            // 
            // lblListaEscolar
            // 
            this.lblListaEscolar.AutoSize = true;
            this.lblListaEscolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaEscolar.Location = new System.Drawing.Point(445, 30);
            this.lblListaEscolar.Name = "lblListaEscolar";
            this.lblListaEscolar.Size = new System.Drawing.Size(85, 16);
            this.lblListaEscolar.TabIndex = 4;
            this.lblListaEscolar.Text = "Lista Escolar";
            // 
            // ltbListaEscolar
            // 
            this.ltbListaEscolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaEscolar.FormattingEnabled = true;
            this.ltbListaEscolar.ItemHeight = 16;
            this.ltbListaEscolar.Items.AddRange(new object[] {
            "Borracha",
            "Caderno",
            "Caneta",
            "Cola",
            "Lápis",
            "Tesoura",
            "Régua",
            "Canetinha"});
            this.ltbListaEscolar.Location = new System.Drawing.Point(448, 58);
            this.ltbListaEscolar.Name = "ltbListaEscolar";
            this.ltbListaEscolar.Size = new System.Drawing.Size(120, 84);
            this.ltbListaEscolar.TabIndex = 5;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(277, 188);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(231, 20);
            this.dtpData.TabIndex = 6;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(274, 169);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(37, 16);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Data";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(287, 227);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 16);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "Hora";
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(290, 246);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(64, 20);
            this.dtpHora.TabIndex = 9;
            // 
            // frmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.ltbListaEscolar);
            this.Controls.Add(this.lblListaEscolar);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.gpbPreferencias);
            this.Controls.Add(this.gpbSexo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.Load += new System.EventHandler(this.frmComponentes_Load);
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbPreferencias.ResumeLayout(false);
            this.gpbPreferencias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.GroupBox gpbPreferencias;
        private System.Windows.Forms.CheckBox ckbCorrer;
        private System.Windows.Forms.CheckBox ckbBebida;
        private System.Windows.Forms.CheckBox ckbComida;
        private System.Windows.Forms.CheckBox ckbCelular;
        private System.Windows.Forms.CheckBox ckbAcademia;
        private System.Windows.Forms.CheckBox ckbLivro;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblListaEscolar;
        private System.Windows.Forms.ListBox ltbListaEscolar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpHora;
    }
}