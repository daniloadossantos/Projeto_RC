namespace RC_System
{
    partial class FormAlterarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarCliente));
            btnExcluir = new Button();
            btnCadastrar = new Button();
            txtCelular = new TextBox();
            txtEmail = new TextBox();
            txtCpf = new TextBox();
            txtTelefone = new TextBox();
            txtSobrenome = new TextBox();
            txtNome = new TextBox();
            lblCelular = new Label();
            lblTelefone = new Label();
            lblSobrenome = new Label();
            lblEmail = new Label();
            lblCpf = new Label();
            lblNome = new Label();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.IndianRed;
            btnExcluir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(300, 234);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(95, 34);
            btnExcluir.TabIndex = 22;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.PaleGreen;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ActiveCaptionText;
            btnCadastrar.Location = new Point(150, 234);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(95, 34);
            btnCadastrar.TabIndex = 21;
            btnCadastrar.Text = "&Salvar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(300, 189);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(216, 23);
            txtCelular.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(29, 189);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 23);
            txtEmail.TabIndex = 17;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(29, 118);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(216, 23);
            txtCpf.TabIndex = 13;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(300, 118);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(216, 23);
            txtTelefone.TabIndex = 15;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(300, 45);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(216, 23);
            txtSobrenome.TabIndex = 11;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(29, 45);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(216, 23);
            txtNome.TabIndex = 9;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.BackColor = Color.Transparent;
            lblCelular.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCelular.Location = new Point(300, 171);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(45, 15);
            lblCelular.TabIndex = 20;
            lblCelular.Text = "Celular";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefone.Location = new Point(300, 100);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(121, 15);
            lblTelefone.TabIndex = 18;
            lblTelefone.Text = "Telefone Residencial";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.BackColor = Color.Transparent;
            lblSobrenome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSobrenome.Location = new Point(300, 27);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(77, 15);
            lblSobrenome.TabIndex = 16;
            lblSobrenome.Text = "Sobrenome*";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(29, 171);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "E-mail";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.BackColor = Color.Transparent;
            lblCpf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCpf.Location = new Point(29, 100);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(32, 15);
            lblCpf.TabIndex = 12;
            lblCpf.Text = "CPF*";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNome.Location = new Point(29, 27);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 15);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome*";
            // 
            // FormAlterarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(545, 295);
            Controls.Add(btnExcluir);
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
            Name = "FormAlterarCliente";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAlterarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcluir;
        private Button btnCadastrar;
        private TextBox txtCelular;
        private TextBox txtEmail;
        private TextBox txtCpf;
        private TextBox txtTelefone;
        private TextBox txtSobrenome;
        private TextBox txtNome;
        private Label lblCelular;
        private Label lblTelefone;
        private Label lblSobrenome;
        private Label lblEmail;
        private Label lblCpf;
        private Label lblNome;
    }
}