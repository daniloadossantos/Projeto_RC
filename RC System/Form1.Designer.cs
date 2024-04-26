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
            btnLimparHora = new Button();
            btnInserirHora = new Button();
            panel2 = new Panel();
            lblDataSelecionada = new Label();
            lblHora = new Label();
            lblData = new Label();
            cmbTipoServico = new ComboBox();
            lblIdServico = new Label();
            lblTituloAgendamento = new Label();
            listHoras = new ListBox();
            mesCalendario = new MonthCalendar();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblCliente = new Label();
            lblEndereco = new Label();
            lblIdAgendamento = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)listaClientes).BeginInit();
            panel1.SuspendLayout();
            tabControlAgendamento.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
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
            tabPage1.BackColor = Color.CornflowerBlue;
            tabPage1.Controls.Add(btnLimparHora);
            tabPage1.Controls.Add(btnInserirHora);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(listHoras);
            tabPage1.Controls.Add(mesCalendario);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(874, 550);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Em andamento";
            tabPage1.Click += tabPage1_Click;
            // 
            // btnLimparHora
            // 
            btnLimparHora.BackColor = Color.IndianRed;
            btnLimparHora.Location = new Point(180, 483);
            btnLimparHora.Name = "btnLimparHora";
            btnLimparHora.Size = new Size(75, 33);
            btnLimparHora.TabIndex = 4;
            btnLimparHora.Text = "Cancelar";
            btnLimparHora.UseVisualStyleBackColor = false;
            // 
            // btnInserirHora
            // 
            btnInserirHora.BackColor = Color.PaleGreen;
            btnInserirHora.Location = new Point(28, 483);
            btnInserirHora.Name = "btnInserirHora";
            btnInserirHora.Size = new Size(75, 33);
            btnInserirHora.TabIndex = 3;
            btnInserirHora.Text = "OK";
            btnInserirHora.UseVisualStyleBackColor = false;
            btnInserirHora.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(lblIdAgendamento);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblEndereco);
            panel2.Controls.Add(lblCliente);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblDataSelecionada);
            panel2.Controls.Add(lblHora);
            panel2.Controls.Add(lblData);
            panel2.Controls.Add(cmbTipoServico);
            panel2.Controls.Add(lblIdServico);
            panel2.Controls.Add(lblTituloAgendamento);
            panel2.Location = new Point(334, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(499, 468);
            panel2.TabIndex = 2;
            // 
            // lblDataSelecionada
            // 
            lblDataSelecionada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblDataSelecionada.BackColor = Color.Silver;
            lblDataSelecionada.BorderStyle = BorderStyle.Fixed3D;
            lblDataSelecionada.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataSelecionada.Location = new Point(227, 141);
            lblDataSelecionada.Name = "lblDataSelecionada";
            lblDataSelecionada.Size = new Size(106, 25);
            lblDataSelecionada.TabIndex = 5;
            lblDataSelecionada.Text = "\"    \"";
            lblDataSelecionada.TextAlign = ContentAlignment.MiddleLeft;
            lblDataSelecionada.Click += lblDataSelecionada_Click;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(369, 114);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(62, 20);
            lblHora.TabIndex = 4;
            lblHora.Text = "Horário";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.Location = new Point(227, 114);
            lblData.Name = "lblData";
            lblData.Size = new Size(113, 20);
            lblData.TabIndex = 3;
            lblData.Text = "Data agendada";
            lblData.Click += lblData_Click;
            // 
            // cmbTipoServico
            // 
            cmbTipoServico.FormattingEnabled = true;
            cmbTipoServico.Location = new Point(29, 141);
            cmbTipoServico.Name = "cmbTipoServico";
            cmbTipoServico.Size = new Size(172, 23);
            cmbTipoServico.TabIndex = 2;
            // 
            // lblIdServico
            // 
            lblIdServico.AutoSize = true;
            lblIdServico.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdServico.Location = new Point(29, 114);
            lblIdServico.Name = "lblIdServico";
            lblIdServico.Size = new Size(120, 20);
            lblIdServico.TabIndex = 1;
            lblIdServico.Text = "Tipo de serviço*";
            // 
            // lblTituloAgendamento
            // 
            lblTituloAgendamento.AutoSize = true;
            lblTituloAgendamento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloAgendamento.Location = new Point(29, 14);
            lblTituloAgendamento.Name = "lblTituloAgendamento";
            lblTituloAgendamento.Size = new Size(159, 21);
            lblTituloAgendamento.TabIndex = 0;
            lblTituloAgendamento.Text = "Criar Agendamento";
            // 
            // listHoras
            // 
            listHoras.BackColor = Color.LightGray;
            listHoras.Cursor = Cursors.Hand;
            listHoras.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listHoras.FormattingEnabled = true;
            listHoras.ItemHeight = 21;
            listHoras.Location = new Point(28, 218);
            listHoras.MultiColumn = true;
            listHoras.Name = "listHoras";
            listHoras.Size = new Size(227, 235);
            listHoras.TabIndex = 1;
            listHoras.SelectedIndexChanged += listHoras_SelectedIndexChanged;
            // 
            // mesCalendario
            // 
            mesCalendario.BackColor = Color.LightGray;
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.BackColor = Color.Silver;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(369, 142);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 6;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 208);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 7;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 289);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 8;
            label3.Text = "Endereço";
            label3.Click += label3_Click;
            // 
            // lblCliente
            // 
            lblCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblCliente.BackColor = Color.Silver;
            lblCliente.BorderStyle = BorderStyle.Fixed3D;
            lblCliente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(29, 235);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(209, 25);
            lblCliente.TabIndex = 9;
            lblCliente.Text = "\"    \"";
            lblCliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEndereco
            // 
            lblEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblEndereco.BackColor = Color.Silver;
            lblEndereco.BorderStyle = BorderStyle.Fixed3D;
            lblEndereco.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(29, 322);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(446, 71);
            lblEndereco.TabIndex = 10;
            lblEndereco.Text = "\"    \"";
            // 
            // lblIdAgendamento
            // 
            lblIdAgendamento.AutoSize = true;
            lblIdAgendamento.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdAgendamento.Location = new Point(29, 63);
            lblIdAgendamento.Name = "lblIdAgendamento";
            lblIdAgendamento.Size = new Size(135, 20);
            lblIdAgendamento.TabIndex = 12;
            lblIdAgendamento.Text = "ID - Agendamento";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.BackColor = Color.Silver;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(170, 61);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 11;
            label5.Text = "\"    \"";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(151, 417);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 14;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGreen;
            button2.Location = new Point(29, 417);
            button2.Name = "button2";
            button2.Size = new Size(75, 33);
            button2.TabIndex = 13;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = false;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Button btnInserirHora;
        private Panel panel2;
        private Button btnLimparHora;
        private Label lblIdServico;
        private Label lblTituloAgendamento;
        private Label lblHora;
        private Label lblData;
        private ComboBox cmbTipoServico;
        private Label lblDataSelecionada;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label lblEndereco;
        private Label lblCliente;
        private Label lblIdAgendamento;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}
