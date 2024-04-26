namespace RC_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnFormClientes = new Button();
            btnFormAgendamentos = new Button();
            btnFormServicos = new Button();
            btnFormTecnicos = new Button();
            btnConsulta = new Button();
            btnNovo = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            dataGridView1 = new DataGridView();
            IDCliente = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Endereço = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnFormClientes
            // 
            btnFormClientes.AutoSize = true;
            btnFormClientes.BackColor = SystemColors.Highlight;
            btnFormClientes.Cursor = Cursors.Hand;
            btnFormClientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFormClientes.ForeColor = SystemColors.Control;
            btnFormClientes.Location = new Point(24, 80);
            btnFormClientes.Name = "btnFormClientes";
            btnFormClientes.Size = new Size(109, 73);
            btnFormClientes.TabIndex = 0;
            btnFormClientes.Text = "&Clientes";
            btnFormClientes.UseVisualStyleBackColor = false;
            // 
            // btnFormAgendamentos
            // 
            btnFormAgendamentos.AutoSize = true;
            btnFormAgendamentos.BackColor = SystemColors.Highlight;
            btnFormAgendamentos.Cursor = Cursors.Hand;
            btnFormAgendamentos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFormAgendamentos.ForeColor = SystemColors.Control;
            btnFormAgendamentos.Location = new Point(24, 178);
            btnFormAgendamentos.Name = "btnFormAgendamentos";
            btnFormAgendamentos.Size = new Size(109, 73);
            btnFormAgendamentos.TabIndex = 1;
            btnFormAgendamentos.Text = "&Agendamentos";
            btnFormAgendamentos.UseVisualStyleBackColor = false;
            // 
            // btnFormServicos
            // 
            btnFormServicos.AutoSize = true;
            btnFormServicos.BackColor = SystemColors.Highlight;
            btnFormServicos.Cursor = Cursors.Hand;
            btnFormServicos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFormServicos.ForeColor = SystemColors.Control;
            btnFormServicos.Location = new Point(24, 274);
            btnFormServicos.Name = "btnFormServicos";
            btnFormServicos.Size = new Size(109, 73);
            btnFormServicos.TabIndex = 2;
            btnFormServicos.Text = "&Serviços";
            btnFormServicos.UseVisualStyleBackColor = false;
            // 
            // btnFormTecnicos
            // 
            btnFormTecnicos.AutoSize = true;
            btnFormTecnicos.BackColor = SystemColors.Highlight;
            btnFormTecnicos.Cursor = Cursors.Hand;
            btnFormTecnicos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFormTecnicos.ForeColor = SystemColors.Control;
            btnFormTecnicos.Location = new Point(24, 365);
            btnFormTecnicos.Name = "btnFormTecnicos";
            btnFormTecnicos.Size = new Size(109, 73);
            btnFormTecnicos.TabIndex = 3;
            btnFormTecnicos.Text = "&Técnicos";
            btnFormTecnicos.UseVisualStyleBackColor = false;
            btnFormTecnicos.Click += button1_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.AutoSize = true;
            btnConsulta.BackColor = Color.SkyBlue;
            btnConsulta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsulta.Location = new Point(147, 21);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(125, 38);
            btnConsulta.TabIndex = 4;
            btnConsulta.Text = "&Consulta";
            btnConsulta.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            btnNovo.AutoSize = true;
            btnNovo.BackColor = Color.PaleGreen;
            btnNovo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(313, 21);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(125, 38);
            btnNovo.TabIndex = 5;
            btnNovo.Text = "&Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.AutoSize = true;
            btnAlterar.BackColor = Color.Coral;
            btnAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(481, 21);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(125, 38);
            btnAlterar.TabIndex = 6;
            btnAlterar.Text = "&Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSize = true;
            btnExcluir.BackColor = Color.IndianRed;
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ImageKey = "(nenhum)";
            btnExcluir.Location = new Point(653, 21);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(125, 38);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDCliente, Nome, Endereço, CPF, Telefone, Email });
            dataGridView1.Location = new Point(147, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(701, 578);
            dataGridView1.TabIndex = 8;
            // 
            // IDCliente
            // 
            IDCliente.HeaderText = "ID-Cliente";
            IDCliente.Name = "IDCliente";
            IDCliente.Width = 120;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.Width = 98;
            // 
            // Endereço
            // 
            Endereço.HeaderText = "Endereço";
            Endereço.Name = "Endereço";
            Endereço.Width = 98;
            // 
            // CPF
            // 
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            CPF.Width = 98;
            // 
            // Telefone
            // 
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            Telefone.Width = 98;
            // 
            // Email
            // 
            Email.HeaderText = "E-mail";
            Email.Name = "Email";
            Email.Width = 98;
            // 
            // btnSair
            // 
            btnSair.AutoSize = true;
            btnSair.BackColor = Color.IndianRed;
            btnSair.Cursor = Cursors.Hand;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = SystemColors.Control;
            btnSair.Location = new Point(24, 585);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(109, 73);
            btnSair.TabIndex = 9;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(984, 681);
            Controls.Add(btnSair);
            Controls.Add(dataGridView1);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnNovo);
            Controls.Add(btnConsulta);
            Controls.Add(btnFormTecnicos);
            Controls.Add(btnFormServicos);
            Controls.Add(btnFormAgendamentos);
            Controls.Add(btnFormClientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "RC System";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFormClientes;
        private Button btnFormAgendamentos;
        private Button btnFormServicos;
        private Button btnFormTecnicos;
        private Button btnConsulta;
        private Button btnNovo;
        private Button btnAlterar;
        private Button btnExcluir;
        private DataGridView dataGridView1;
        private Button btnSair;
        private DataGridViewTextBoxColumn IDCliente;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Endereço;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Email;
    }
}
