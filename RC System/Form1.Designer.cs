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
            listaClientes = new DataGridView();
            IDCliente = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Endereço = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            btnSair = new Button();
            panel1 = new Panel();
            tabControlAgendamento = new TabControl();
            tabPage1 = new TabPage();
            listHoras = new ListBox();
            mesCalendario = new MonthCalendar();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)listaClientes).BeginInit();
            panel1.SuspendLayout();
            tabControlAgendamento.SuspendLayout();
            tabPage1.SuspendLayout();
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
            btnFormClientes.Click += btnFormClientes_Click;
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
            btnFormAgendamentos.Click += btnFormAgendamentos_Click;
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
            btnConsulta.Cursor = Cursors.Hand;
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
            btnNovo.Cursor = Cursors.Hand;
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
            btnAlterar.Cursor = Cursors.Hand;
            btnAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(481, 21);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(125, 38);
            btnAlterar.TabIndex = 6;
            btnAlterar.Text = "&Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSize = true;
            btnExcluir.BackColor = Color.IndianRed;
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ImageKey = "(nenhum)";
            btnExcluir.Location = new Point(653, 21);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(125, 38);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // listaClientes
            // 
            listaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaClientes.Columns.AddRange(new DataGridViewColumn[] { IDCliente, Nome, Endereço, CPF, Telefone, Email });
            listaClientes.Location = new Point(0, 0);
            listaClientes.Name = "listaClientes";
            listaClientes.Size = new Size(701, 578);
            listaClientes.TabIndex = 8;
            listaClientes.Visible = false;
            listaClientes.CellContentClick += listaClientes_CellContentClick;
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
            // panel1
            // 
            panel1.Controls.Add(listaClientes);
            panel1.Location = new Point(147, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 578);
            panel1.TabIndex = 11;
            // 
            // tabControlAgendamento
            // 
            tabControlAgendamento.Controls.Add(tabPage1);
            tabControlAgendamento.Controls.Add(tabPage2);
            tabControlAgendamento.Controls.Add(tabPage3);
            tabControlAgendamento.Location = new Point(147, 80);
            tabControlAgendamento.Name = "tabControlAgendamento";
            tabControlAgendamento.SelectedIndex = 0;
            tabControlAgendamento.Size = new Size(882, 578);
            tabControlAgendamento.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listHoras);
            tabPage1.Controls.Add(mesCalendario);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(874, 550);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Em andamento";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // listHoras
            // 
            listHoras.Cursor = Cursors.Hand;
            listHoras.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listHoras.FormattingEnabled = true;
            listHoras.ItemHeight = 21;
            listHoras.Location = new Point(28, 218);
            listHoras.MultiColumn = true;
            listHoras.Name = "listHoras";
            listHoras.Size = new Size(227, 298);
            listHoras.TabIndex = 1;
            listHoras.SelectedIndexChanged += listHoras_SelectedIndexChanged;
            // 
            // mesCalendario
            // 
            mesCalendario.BackColor = SystemColors.Window;
            mesCalendario.Cursor = Cursors.Hand;
            mesCalendario.FirstDayOfWeek = Day.Monday;
            mesCalendario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mesCalendario.Location = new Point(28, 44);
            mesCalendario.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            mesCalendario.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            mesCalendario.Name = "mesCalendario";
            mesCalendario.TabIndex = 0;
            mesCalendario.DateChanged += mesCalendario_DateChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(874, 550);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Concluído";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(874, 550);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cancelado";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1100, 681);
            Controls.Add(tabControlAgendamento);
            Controls.Add(panel1);
            Controls.Add(btnSair);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnNovo);
            Controls.Add(btnConsulta);
            Controls.Add(btnFormTecnicos);
            Controls.Add(btnFormServicos);
            Controls.Add(btnFormAgendamentos);
            Controls.Add(btnFormClientes);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RC System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)listaClientes).EndInit();
            panel1.ResumeLayout(false);
            tabControlAgendamento.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
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
        private DataGridView listaClientes;
        private Button btnSair;
        private DataGridViewTextBoxColumn IDCliente;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Endereço;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Email;
        private Panel panel1;
        private TabControl tabControlAgendamento;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DateTimePicker dateTimePicker1;
        private MonthCalendar mesCalendario;
        private TabPage tabPage3;
        private ListBox listHoras;
    }
}
