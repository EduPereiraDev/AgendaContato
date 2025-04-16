namespace ContatoAgenda
{
    partial class CadastroContato
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.mtxCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtpCadastro = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 110);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(160, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(106, 166);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(160, 20);
            this.txtApelido.TabIndex = 1;
            // 
            // mtxCpf
            // 
            this.mtxCpf.Location = new System.Drawing.Point(106, 217);
            this.mtxCpf.Mask = "000.000.000-00";
            this.mtxCpf.Name = "mtxCpf";
            this.mtxCpf.Size = new System.Drawing.Size(160, 20);
            this.mtxCpf.TabIndex = 2;
            this.mtxCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxTelefone
            // 
            this.mtxTelefone.Location = new System.Drawing.Point(106, 269);
            this.mtxTelefone.Mask = "(00) 00000-0000";
            this.mtxTelefone.Name = "mtxTelefone";
            this.mtxTelefone.Size = new System.Drawing.Size(160, 20);
            this.mtxTelefone.TabIndex = 3;
            this.mtxTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 321);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(103, 94);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(103, 150);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(45, 13);
            this.lblApelido.TabIndex = 6;
            this.lblApelido.Text = "Apelido:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(103, 201);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 7;
            this.lblCpf.Text = "CPF:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(103, 253);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 8;
            this.lblTel.Text = "Telefone:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(103, 305);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 13);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "E-Mail";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(149, 357);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Adicionar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtpCadastro
            // 
            this.dtpCadastro.Location = new System.Drawing.Point(106, 53);
            this.dtpCadastro.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpCadastro.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpCadastro.Name = "dtpCadastro";
            this.dtpCadastro.Size = new System.Drawing.Size(160, 20);
            this.dtpCadastro.TabIndex = 11;
            // 
            // CadastroContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.dtpCadastro);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mtxTelefone);
            this.Controls.Add(this.mtxCpf);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtNome);
            this.Name = "CadastroContato";
            this.Text = "CadastroContato";
            this.Load += new System.EventHandler(this.CadastroContato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.MaskedTextBox mtxCpf;
        private System.Windows.Forms.MaskedTextBox mtxTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dtpCadastro;
    }
}