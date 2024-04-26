namespace RC_System
{
    partial class FormCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCliente));
            lblNome = new Label();
            lblCpf = new Label();
            lblEmail = new Label();
            lblSobrenome = new Label();
            lblTelefone = new Label();
            lblCelular = new Label();
            txtNome = new TextBox();
            txtSobrenome = new TextBox();
            txtTelefone = new TextBox();
            txtCpf = new TextBox();
            txtEmail = new TextBox();
            txtCelular = new TextBox();
            btnCadastrar = new Button();
            btnLimpar = new Button();
            textBox1 = new TextBox();
            lblLogradouro = new Label();
            textBox2 = new TextBox();
            lblNumero = new Label();
            textBox3 = new TextBox();
            lblComplemento = new Label();
            textBox4 = new TextBox();
            lblCidade = new Label();
            textBox5 = new TextBox();
            lblUf = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNome.Location = new Point(26, 25);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome*";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.BackColor = Color.Transparent;
            lblCpf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCpf.Location = new Point(26, 98);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(32, 15);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF*";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(26, 169);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "E-mail";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.BackColor = Color.Transparent;
            lblSobrenome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSobrenome.Location = new Point(297, 25);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(77, 15);
            lblSobrenome.TabIndex = 4;
            lblSobrenome.Text = "Sobrenome*";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefone.Location = new Point(297, 98);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(121, 15);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "Telefone Residencial";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.BackColor = Color.Transparent;
            lblCelular.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCelular.Location = new Point(297, 169);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(45, 15);
            lblCelular.TabIndex = 6;
            lblCelular.Text = "Celular";
            lblCelular.Click += label1_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(26, 43);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(216, 23);
            txtNome.TabIndex = 1;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(297, 43);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(216, 23);
            txtSobrenome.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(297, 116);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(216, 23);
            txtTelefone.TabIndex = 4;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(26, 116);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(216, 23);
            txtCpf.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(26, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(297, 187);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(216, 23);
            txtCelular.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.PaleGreen;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ActiveCaptionText;
            btnCadastrar.Location = new Point(137, 363);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(105, 43);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "&Salvar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += button1_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.IndianRed;
            btnLimpar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(297, 363);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(105, 43);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "&Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 247);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 84);
            textBox1.TabIndex = 10;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.BackColor = Color.Transparent;
            lblLogradouro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLogradouro.Location = new Point(26, 229);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(71, 15);
            lblLogradouro.TabIndex = 9;
            lblLogradouro.Text = "&Logradouro";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(297, 247);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(63, 23);
            textBox2.TabIndex = 11;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = Color.Transparent;
            lblNumero.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNumero.Location = new Point(297, 229);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(53, 15);
            lblNumero.TabIndex = 12;
            lblNumero.Text = "Número";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(387, 247);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(126, 23);
            textBox3.TabIndex = 13;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.BackColor = Color.Transparent;
            lblComplemento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblComplemento.Location = new Point(387, 229);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(86, 15);
            lblComplemento.TabIndex = 14;
            lblComplemento.Text = "Complemento";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(297, 308);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(132, 23);
            textBox4.TabIndex = 16;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.BackColor = Color.Transparent;
            lblCidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCidade.Location = new Point(297, 290);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 15;
            lblCidade.Text = "Cidade";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(453, 308);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(60, 23);
            textBox5.TabIndex = 18;
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.BackColor = Color.Transparent;
            lblUf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUf.Location = new Point(453, 290);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(22, 15);
            lblUf.TabIndex = 17;
            lblUf.Text = "UF";
            // 
            // FormCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(545, 421);
            Controls.Add(textBox5);
            Controls.Add(lblUf);
            Controls.Add(textBox4);
            Controls.Add(lblCidade);
            Controls.Add(textBox3);
            Controls.Add(lblComplemento);
            Controls.Add(textBox2);
            Controls.Add(lblNumero);
            Controls.Add(textBox1);
            Controls.Add(lblLogradouro);
            Controls.Add(btnLimpar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtCelular);
            Controls.Add(txtEmail);
            Controls.Add(txtCpf);
            Controls.Add(txtTelefone);
            Controls.Add(txtSobrenome);
            Controls.Add(txtNome);
            Controls.Add(lblCelular);
            Controls.Add(lblTelefone);
            Controls.Add(lblSobrenome);
            Controls.Add(lblEmail);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroCliente";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro cliente";
            Load += FormCadastrarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblCpf;
        private Label lblEmail;
        private Label lblSobrenome;
        private Label lblTelefone;
        private Label lblCelular;
        private TextBox txtNome;
        private TextBox txtSobrenome;
        private TextBox txtTelefone;
        private TextBox txtCpf;
        private TextBox txtEmail;
        private TextBox txtCelular;
        private Button btnCadastrar;
        private Button btnLimpar;
        private TextBox textBox1;
        private Label lblLogradouro;
        private TextBox textBox2;
        private Label lblNumero;
        private TextBox textBox3;
        private Label lblComplemento;
        private TextBox textBox4;
        private Label lblCidade;
        private TextBox textBox5;
        private Label lblUf;
    }
}