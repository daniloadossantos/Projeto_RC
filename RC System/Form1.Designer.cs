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
            pnlClientes = new Panel();
            pnlAgendamentos = new Panel();
            pnlTecnico = new Panel();
            pnlCriarTecnico = new Panel();
            button3 = new Button();
            btnCadastrar = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            lblNomeTecnico = new Label();
            lblTituloCriarTecnico = new Label();
            dataGridTecnicos = new DataGridView();
            IDTecnico = new DataGridViewTextBoxColumn();
            NomeTecnico = new DataGridViewTextBoxColumn();
            CpfTecnico = new DataGridViewTextBoxColumn();
            TelefoneTecnico = new DataGridViewTextBoxColumn();
            pnlDetalhesAgendamento = new Panel();
            button1 = new Button();
            button2 = new Button();
            lblIdAgendamento = new Label();
            label5 = new Label();
            lblEndereco = new Label();
            lblCliente = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblDataSelecionada = new Label();
            lblHora = new Label();
            lblData = new Label();
            cmbTipoServico = new ComboBox();
            lblIdServico = new Label();
            lblTituloAgendamento = new Label();
            tabControlAgendamento = new TabControl();
            tabPage1 = new TabPage();
            btnLimparHora = new Button();
            btnInserirHora = new Button();
            listHoras = new ListBox();
            mesCalendario = new MonthCalendar();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            IDAgendamento = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            LocalDoServiço = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            tabPage4 = new TabPage();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            tabTodos = new TabPage();
            dataGridView4 = new DataGridView();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            pnlServicos = new Panel();
            tabServicos = new TabControl();
            tabDetalhesServico = new TabPage();
            cmbFormaPagamento = new ComboBox();
            lblFormaPagamento = new Label();
            btnCancelarServico = new Button();
            btnSalvarServico = new Button();
            groupBoxDetalhesOrcamento = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            lblTipoServicoOrcamentoValor = new Label();
            lblValorTotalServico = new Label();
            lblDescricaoOrcamentoServico = new Label();
            label8 = new Label();
            lblPrecoServico = new Label();
            lblTipoServicoServicos = new Label();
            btnGerarServico = new Button();
            lblNomeClienteServico = new Label();
            lblNomeTecnicoServico = new Label();
            label7 = new Label();
            txtAgendamentoServico = new TextBox();
            lblIdAgendamentoServico = new Label();
            txtIdOrcamentoServico = new TextBox();
            lblIdOrcamentoServico = new Label();
            label4 = new Label();
            lblDetalhesServico = new Label();
            tabEmAndamentoServicos = new TabPage();
            dataGridView5 = new DataGridView();
            IDServico = new DataGridViewTextBoxColumn();
            Tipodeservico = new DataGridViewTextBoxColumn();
            ClienteServico = new DataGridViewTextBoxColumn();
            StatusServico = new DataGridViewTextBoxColumn();
            tabReprovadoServico = new TabPage();
            dataGridView6 = new DataGridView();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            tabAprovadoServico = new TabPage();
            dataGridView7 = new DataGridView();
            dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
            tabTodosServicos = new TabPage();
            dataGridView8 = new DataGridView();
            dataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn23 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn24 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn25 = new DataGridViewTextBoxColumn();
            StatusOrcamento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)listaClientes).BeginInit();
            pnlClientes.SuspendLayout();
            pnlAgendamentos.SuspendLayout();
            pnlTecnico.SuspendLayout();
            pnlCriarTecnico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTecnicos).BeginInit();
            pnlDetalhesAgendamento.SuspendLayout();
            tabControlAgendamento.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            pnlServicos.SuspendLayout();
            tabServicos.SuspendLayout();
            tabDetalhesServico.SuspendLayout();
            groupBoxDetalhesOrcamento.SuspendLayout();
            tabEmAndamentoServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            tabReprovadoServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            tabAprovadoServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            tabTodosServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).BeginInit();
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
            btnFormServicos.Click += btnFormServicos_Click;
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
            btnFormTecnicos.Click += btnFormTecnicos_Click;
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
            listaClientes.Location = new Point(0, 5);
            listaClientes.Name = "listaClientes";
            listaClientes.Size = new Size(986, 578);
            listaClientes.TabIndex = 8;
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
            // pnlClientes
            // 
            pnlClientes.BackColor = Color.Transparent;
            pnlClientes.Controls.Add(listaClientes);
            pnlClientes.Location = new Point(147, 80);
            pnlClientes.Name = "pnlClientes";
            pnlClientes.Size = new Size(989, 578);
            pnlClientes.TabIndex = 11;
            pnlClientes.Visible = false;
            // 
            // pnlAgendamentos
            // 
            pnlAgendamentos.BackColor = Color.Transparent;
            pnlAgendamentos.Controls.Add(pnlTecnico);
            pnlAgendamentos.Controls.Add(pnlDetalhesAgendamento);
            pnlAgendamentos.Controls.Add(tabControlAgendamento);
            pnlAgendamentos.Location = new Point(146, 80);
            pnlAgendamentos.Name = "pnlAgendamentos";
            pnlAgendamentos.Size = new Size(989, 578);
            pnlAgendamentos.TabIndex = 5;
            pnlAgendamentos.Visible = false;
            // 
            // pnlTecnico
            // 
            pnlTecnico.BackColor = Color.Transparent;
            pnlTecnico.Controls.Add(pnlCriarTecnico);
            pnlTecnico.Controls.Add(dataGridTecnicos);
            pnlTecnico.Location = new Point(1, 0);
            pnlTecnico.Name = "pnlTecnico";
            pnlTecnico.Size = new Size(992, 578);
            pnlTecnico.TabIndex = 15;
            pnlTecnico.Visible = false;
            pnlTecnico.Paint += pnlTecnico_Paint;
            // 
            // pnlCriarTecnico
            // 
            pnlCriarTecnico.Controls.Add(button3);
            pnlCriarTecnico.Controls.Add(btnCadastrar);
            pnlCriarTecnico.Controls.Add(textBox3);
            pnlCriarTecnico.Controls.Add(textBox2);
            pnlCriarTecnico.Controls.Add(textBox1);
            pnlCriarTecnico.Controls.Add(label13);
            pnlCriarTecnico.Controls.Add(label12);
            pnlCriarTecnico.Controls.Add(lblNomeTecnico);
            pnlCriarTecnico.Controls.Add(lblTituloCriarTecnico);
            pnlCriarTecnico.Location = new Point(536, 5);
            pnlCriarTecnico.Name = "pnlCriarTecnico";
            pnlCriarTecnico.Size = new Size(449, 552);
            pnlCriarTecnico.TabIndex = 1;
            pnlCriarTecnico.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(258, 241);
            button3.Name = "button3";
            button3.Size = new Size(95, 34);
            button3.TabIndex = 24;
            button3.Text = "&Excluir";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.PaleGreen;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ActiveCaptionText;
            btnCadastrar.Location = new Point(108, 241);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(95, 34);
            btnCadastrar.TabIndex = 23;
            btnCadastrar.Text = "&Salvar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(91, 126);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(315, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 23);
            textBox1.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(23, 175);
            label13.Name = "label13";
            label13.Size = new Size(62, 19);
            label13.TabIndex = 3;
            label13.Text = "Telefone";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(23, 130);
            label12.Name = "label12";
            label12.Size = new Size(39, 19);
            label12.TabIndex = 2;
            label12.Text = "CPF*";
            // 
            // lblNomeTecnico
            // 
            lblNomeTecnico.AutoSize = true;
            lblNomeTecnico.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeTecnico.Location = new Point(23, 85);
            lblNomeTecnico.Name = "lblNomeTecnico";
            lblNomeTecnico.Size = new Size(47, 19);
            lblNomeTecnico.TabIndex = 1;
            lblNomeTecnico.Text = "Nome";
            // 
            // lblTituloCriarTecnico
            // 
            lblTituloCriarTecnico.AutoSize = true;
            lblTituloCriarTecnico.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTituloCriarTecnico.Location = new Point(23, 25);
            lblTituloCriarTecnico.Name = "lblTituloCriarTecnico";
            lblTituloCriarTecnico.Size = new Size(98, 20);
            lblTituloCriarTecnico.TabIndex = 0;
            lblTituloCriarTecnico.Text = "Criar Técnico";
            // 
            // dataGridTecnicos
            // 
            dataGridTecnicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTecnicos.Columns.AddRange(new DataGridViewColumn[] { IDTecnico, NomeTecnico, CpfTecnico, TelefoneTecnico });
            dataGridTecnicos.Location = new Point(2, 5);
            dataGridTecnicos.Name = "dataGridTecnicos";
            dataGridTecnicos.Size = new Size(536, 552);
            dataGridTecnicos.TabIndex = 0;
            dataGridTecnicos.CellContentClick += dataGridTecnicos_CellContentClick;
            // 
            // IDTecnico
            // 
            IDTecnico.HeaderText = "ID-Técnico";
            IDTecnico.Name = "IDTecnico";
            // 
            // NomeTecnico
            // 
            NomeTecnico.HeaderText = "Nome Técnico";
            NomeTecnico.Name = "NomeTecnico";
            // 
            // CpfTecnico
            // 
            CpfTecnico.HeaderText = "CPF";
            CpfTecnico.Name = "CpfTecnico";
            // 
            // TelefoneTecnico
            // 
            TelefoneTecnico.HeaderText = "Telefone";
            TelefoneTecnico.Name = "TelefoneTecnico";
            // 
            // pnlDetalhesAgendamento
            // 
            pnlDetalhesAgendamento.BackColor = Color.LightGray;
            pnlDetalhesAgendamento.Controls.Add(button1);
            pnlDetalhesAgendamento.Controls.Add(button2);
            pnlDetalhesAgendamento.Controls.Add(lblIdAgendamento);
            pnlDetalhesAgendamento.Controls.Add(label5);
            pnlDetalhesAgendamento.Controls.Add(lblEndereco);
            pnlDetalhesAgendamento.Controls.Add(lblCliente);
            pnlDetalhesAgendamento.Controls.Add(label3);
            pnlDetalhesAgendamento.Controls.Add(label2);
            pnlDetalhesAgendamento.Controls.Add(label1);
            pnlDetalhesAgendamento.Controls.Add(lblDataSelecionada);
            pnlDetalhesAgendamento.Controls.Add(lblHora);
            pnlDetalhesAgendamento.Controls.Add(lblData);
            pnlDetalhesAgendamento.Controls.Add(cmbTipoServico);
            pnlDetalhesAgendamento.Controls.Add(lblIdServico);
            pnlDetalhesAgendamento.Controls.Add(lblTituloAgendamento);
            pnlDetalhesAgendamento.Location = new Point(472, 24);
            pnlDetalhesAgendamento.Name = "pnlDetalhesAgendamento";
            pnlDetalhesAgendamento.Size = new Size(499, 468);
            pnlDetalhesAgendamento.TabIndex = 2;
            pnlDetalhesAgendamento.Visible = false;
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
            // lblCliente
            // 
            lblCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblCliente.BackColor = Color.Silver;
            lblCliente.BorderStyle = BorderStyle.Fixed3D;
            lblCliente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(29, 235);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(304, 25);
            lblCliente.TabIndex = 9;
            lblCliente.Text = "\"    \"";
            lblCliente.TextAlign = ContentAlignment.MiddleLeft;
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.BackColor = Color.Silver;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(369, 142);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 6;
            label1.Text = "\" \"";
            label1.TextAlign = ContentAlignment.MiddleLeft;
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
            cmbTipoServico.Font = new Font("Segoe UI", 9.75F);
            cmbTipoServico.FormattingEnabled = true;
            cmbTipoServico.Location = new Point(29, 141);
            cmbTipoServico.Name = "cmbTipoServico";
            cmbTipoServico.Size = new Size(172, 25);
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
            lblTituloAgendamento.Size = new Size(212, 21);
            lblTituloAgendamento.TabIndex = 0;
            lblTituloAgendamento.Text = "Detalhes do agendamento";
            // 
            // tabControlAgendamento
            // 
            tabControlAgendamento.Controls.Add(tabPage1);
            tabControlAgendamento.Controls.Add(tabPage2);
            tabControlAgendamento.Controls.Add(tabPage3);
            tabControlAgendamento.Controls.Add(tabPage4);
            tabControlAgendamento.Controls.Add(tabTodos);
            tabControlAgendamento.Location = new Point(3, 3);
            tabControlAgendamento.Name = "tabControlAgendamento";
            tabControlAgendamento.SelectedIndex = 0;
            tabControlAgendamento.Size = new Size(446, 578);
            tabControlAgendamento.TabIndex = 13;
            tabControlAgendamento.SelectedIndexChanged += tabControlAgendamento_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.CornflowerBlue;
            tabPage1.Controls.Add(btnLimparHora);
            tabPage1.Controls.Add(btnInserirHora);
            tabPage1.Controls.Add(listHoras);
            tabPage1.Controls.Add(mesCalendario);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(438, 550);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Detalhes";
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
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(438, 550);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Em andamento";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDAgendamento, Cliente, LocalDoServiço, Data, Hora });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(989, 578);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IDAgendamento
            // 
            IDAgendamento.HeaderText = "Id-Agendamento";
            IDAgendamento.Name = "IDAgendamento";
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            // 
            // LocalDoServiço
            // 
            LocalDoServiço.HeaderText = "Local do serviço";
            LocalDoServiço.Name = "LocalDoServiço";
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.Name = "Data";
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.Name = "Hora";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(438, 550);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cancelado";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView2.Location = new Point(-1, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(874, 550);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id-Agendamento";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Cliente";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Local do serviço";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Data";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Hora";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView3);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(438, 550);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Concluído";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dataGridView3.Location = new Point(-1, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(874, 550);
            dataGridView3.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Id-Agendamento";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Cliente";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Local do serviço";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Data";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Hora";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // tabTodos
            // 
            tabTodos.Controls.Add(dataGridView4);
            tabTodos.Location = new Point(4, 24);
            tabTodos.Name = "tabTodos";
            tabTodos.Padding = new Padding(3);
            tabTodos.Size = new Size(438, 550);
            tabTodos.TabIndex = 4;
            tabTodos.Text = "Todos";
            tabTodos.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, Status });
            dataGridView4.Location = new Point(-1, 0);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(874, 550);
            dataGridView4.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Id-Agendamento";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Cliente";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Local do serviço";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Data";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.HeaderText = "Hora";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // pnlServicos
            // 
            pnlServicos.BackColor = Color.Transparent;
            pnlServicos.Controls.Add(tabServicos);
            pnlServicos.Location = new Point(147, 80);
            pnlServicos.Name = "pnlServicos";
            pnlServicos.Size = new Size(989, 578);
            pnlServicos.TabIndex = 14;
            pnlServicos.Visible = false;
            pnlServicos.Paint += pnlServicos_Paint;
            // 
            // tabServicos
            // 
            tabServicos.Controls.Add(tabDetalhesServico);
            tabServicos.Controls.Add(tabEmAndamentoServicos);
            tabServicos.Controls.Add(tabReprovadoServico);
            tabServicos.Controls.Add(tabAprovadoServico);
            tabServicos.Controls.Add(tabTodosServicos);
            tabServicos.Location = new Point(3, 3);
            tabServicos.Name = "tabServicos";
            tabServicos.SelectedIndex = 0;
            tabServicos.Size = new Size(992, 575);
            tabServicos.TabIndex = 0;
            // 
            // tabDetalhesServico
            // 
            tabDetalhesServico.BackColor = Color.LightGray;
            tabDetalhesServico.Controls.Add(cmbFormaPagamento);
            tabDetalhesServico.Controls.Add(lblFormaPagamento);
            tabDetalhesServico.Controls.Add(btnCancelarServico);
            tabDetalhesServico.Controls.Add(btnSalvarServico);
            tabDetalhesServico.Controls.Add(groupBoxDetalhesOrcamento);
            tabDetalhesServico.Controls.Add(btnGerarServico);
            tabDetalhesServico.Controls.Add(lblNomeClienteServico);
            tabDetalhesServico.Controls.Add(lblNomeTecnicoServico);
            tabDetalhesServico.Controls.Add(label7);
            tabDetalhesServico.Controls.Add(txtAgendamentoServico);
            tabDetalhesServico.Controls.Add(lblIdAgendamentoServico);
            tabDetalhesServico.Controls.Add(txtIdOrcamentoServico);
            tabDetalhesServico.Controls.Add(lblIdOrcamentoServico);
            tabDetalhesServico.Controls.Add(label4);
            tabDetalhesServico.Controls.Add(lblDetalhesServico);
            tabDetalhesServico.Location = new Point(4, 24);
            tabDetalhesServico.Name = "tabDetalhesServico";
            tabDetalhesServico.Padding = new Padding(3);
            tabDetalhesServico.Size = new Size(984, 547);
            tabDetalhesServico.TabIndex = 0;
            tabDetalhesServico.Text = "Detalhes";
            tabDetalhesServico.Click += tabDetalhesServico_Click;
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.FormattingEnabled = true;
            cmbFormaPagamento.Items.AddRange(new object[] { "Cartão de crédito", "Cartão de débito", "Transferência bancária" });
            cmbFormaPagamento.Location = new Point(31, 338);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(159, 23);
            cmbFormaPagamento.TabIndex = 27;
            cmbFormaPagamento.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblFormaPagamento
            // 
            lblFormaPagamento.AutoSize = true;
            lblFormaPagamento.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormaPagamento.Location = new Point(31, 314);
            lblFormaPagamento.Name = "lblFormaPagamento";
            lblFormaPagamento.Size = new Size(156, 20);
            lblFormaPagamento.TabIndex = 26;
            lblFormaPagamento.Text = "Forma de pagamento";
            lblFormaPagamento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCancelarServico
            // 
            btnCancelarServico.BackColor = Color.IndianRed;
            btnCancelarServico.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarServico.Location = new Point(161, 478);
            btnCancelarServico.Name = "btnCancelarServico";
            btnCancelarServico.Size = new Size(95, 34);
            btnCancelarServico.TabIndex = 25;
            btnCancelarServico.Text = "&Cancelar";
            btnCancelarServico.UseVisualStyleBackColor = false;
            // 
            // btnSalvarServico
            // 
            btnSalvarServico.BackColor = Color.PaleGreen;
            btnSalvarServico.Cursor = Cursors.Hand;
            btnSalvarServico.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvarServico.ForeColor = SystemColors.ActiveCaptionText;
            btnSalvarServico.Location = new Point(29, 478);
            btnSalvarServico.Name = "btnSalvarServico";
            btnSalvarServico.Size = new Size(95, 34);
            btnSalvarServico.TabIndex = 24;
            btnSalvarServico.Text = "&Salvar";
            btnSalvarServico.UseVisualStyleBackColor = false;
            // 
            // groupBoxDetalhesOrcamento
            // 
            groupBoxDetalhesOrcamento.BackColor = Color.Gainsboro;
            groupBoxDetalhesOrcamento.Controls.Add(label11);
            groupBoxDetalhesOrcamento.Controls.Add(label10);
            groupBoxDetalhesOrcamento.Controls.Add(label9);
            groupBoxDetalhesOrcamento.Controls.Add(label6);
            groupBoxDetalhesOrcamento.Controls.Add(lblTipoServicoOrcamentoValor);
            groupBoxDetalhesOrcamento.Controls.Add(lblValorTotalServico);
            groupBoxDetalhesOrcamento.Controls.Add(lblDescricaoOrcamentoServico);
            groupBoxDetalhesOrcamento.Controls.Add(label8);
            groupBoxDetalhesOrcamento.Controls.Add(lblPrecoServico);
            groupBoxDetalhesOrcamento.Controls.Add(lblTipoServicoServicos);
            groupBoxDetalhesOrcamento.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            groupBoxDetalhesOrcamento.Location = new Point(279, 279);
            groupBoxDetalhesOrcamento.Name = "groupBoxDetalhesOrcamento";
            groupBoxDetalhesOrcamento.Padding = new Padding(9);
            groupBoxDetalhesOrcamento.Size = new Size(493, 233);
            groupBoxDetalhesOrcamento.TabIndex = 14;
            groupBoxDetalhesOrcamento.TabStop = false;
            groupBoxDetalhesOrcamento.Text = "Detalhes do orçamento:";
            groupBoxDetalhesOrcamento.Enter += groupBox1_Enter;
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Location = new Point(166, 194);
            label11.Name = "label11";
            label11.Size = new Size(288, 26);
            label11.TabIndex = 20;
            label11.Text = "\"\"\"\"";
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Location = new Point(166, 159);
            label10.Name = "label10";
            label10.Size = new Size(288, 26);
            label10.TabIndex = 19;
            label10.Text = "\"\"\"\"";
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Location = new Point(166, 124);
            label9.Name = "label9";
            label9.Size = new Size(288, 26);
            label9.TabIndex = 18;
            label9.Text = "\"\"\"\"";
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(166, 56);
            label6.Name = "label6";
            label6.Size = new Size(288, 59);
            label6.TabIndex = 17;
            label6.Text = "\"\"\"\"";
            // 
            // lblTipoServicoOrcamentoValor
            // 
            lblTipoServicoOrcamentoValor.BackColor = Color.White;
            lblTipoServicoOrcamentoValor.BorderStyle = BorderStyle.FixedSingle;
            lblTipoServicoOrcamentoValor.Location = new Point(166, 25);
            lblTipoServicoOrcamentoValor.Name = "lblTipoServicoOrcamentoValor";
            lblTipoServicoOrcamentoValor.Size = new Size(288, 22);
            lblTipoServicoOrcamentoValor.TabIndex = 16;
            lblTipoServicoOrcamentoValor.Text = "\"\"\"\"";
            // 
            // lblValorTotalServico
            // 
            lblValorTotalServico.AutoSize = true;
            lblValorTotalServico.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorTotalServico.Location = new Point(22, 194);
            lblValorTotalServico.Name = "lblValorTotalServico";
            lblValorTotalServico.Size = new Size(91, 19);
            lblValorTotalServico.TabIndex = 15;
            lblValorTotalServico.Text = "Valor a pagar";
            lblValorTotalServico.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescricaoOrcamentoServico
            // 
            lblDescricaoOrcamentoServico.AutoSize = true;
            lblDescricaoOrcamentoServico.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricaoOrcamentoServico.Location = new Point(22, 56);
            lblDescricaoOrcamentoServico.Name = "lblDescricaoOrcamentoServico";
            lblDescricaoOrcamentoServico.Size = new Size(70, 19);
            lblDescricaoOrcamentoServico.TabIndex = 14;
            lblDescricaoOrcamentoServico.Text = "Descrição";
            lblDescricaoOrcamentoServico.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 159);
            label8.Name = "label8";
            label8.Size = new Size(82, 19);
            label8.TabIndex = 13;
            label8.Text = "Quantidade";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrecoServico
            // 
            lblPrecoServico.AutoSize = true;
            lblPrecoServico.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecoServico.Location = new Point(22, 124);
            lblPrecoServico.Name = "lblPrecoServico";
            lblPrecoServico.Size = new Size(44, 19);
            lblPrecoServico.TabIndex = 12;
            lblPrecoServico.Text = "Preço";
            lblPrecoServico.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTipoServicoServicos
            // 
            lblTipoServicoServicos.AutoSize = true;
            lblTipoServicoServicos.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoServicoServicos.Location = new Point(22, 25);
            lblTipoServicoServicos.Name = "lblTipoServicoServicos";
            lblTipoServicoServicos.Size = new Size(105, 19);
            lblTipoServicoServicos.TabIndex = 11;
            lblTipoServicoServicos.Text = "Tipo de serviço";
            lblTipoServicoServicos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnGerarServico
            // 
            btnGerarServico.Location = new Point(31, 247);
            btnGerarServico.Name = "btnGerarServico";
            btnGerarServico.Size = new Size(75, 23);
            btnGerarServico.TabIndex = 13;
            btnGerarServico.Text = "&Gerar";
            btnGerarServico.UseVisualStyleBackColor = true;
            // 
            // lblNomeClienteServico
            // 
            lblNomeClienteServico.BackColor = Color.DimGray;
            lblNomeClienteServico.BorderStyle = BorderStyle.Fixed3D;
            lblNomeClienteServico.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeClienteServico.Location = new Point(279, 115);
            lblNomeClienteServico.Name = "lblNomeClienteServico";
            lblNomeClienteServico.Size = new Size(259, 22);
            lblNomeClienteServico.TabIndex = 12;
            lblNomeClienteServico.Text = "\"\"\"\"\"";
            lblNomeClienteServico.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNomeTecnicoServico
            // 
            lblNomeTecnicoServico.BackColor = Color.DimGray;
            lblNomeTecnicoServico.BorderStyle = BorderStyle.Fixed3D;
            lblNomeTecnicoServico.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeTecnicoServico.Location = new Point(279, 221);
            lblNomeTecnicoServico.Name = "lblNomeTecnicoServico";
            lblNomeTecnicoServico.Size = new Size(259, 22);
            lblNomeTecnicoServico.TabIndex = 11;
            lblNomeTecnicoServico.Text = "\"\"\"\"\"";
            lblNomeTecnicoServico.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(279, 186);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 10;
            label7.Text = "Técnico";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAgendamentoServico
            // 
            txtAgendamentoServico.Location = new Point(31, 114);
            txtAgendamentoServico.Name = "txtAgendamentoServico";
            txtAgendamentoServico.Size = new Size(127, 23);
            txtAgendamentoServico.TabIndex = 9;
            // 
            // lblIdAgendamentoServico
            // 
            lblIdAgendamentoServico.AutoSize = true;
            lblIdAgendamentoServico.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdAgendamentoServico.Location = new Point(31, 88);
            lblIdAgendamentoServico.Name = "lblIdAgendamentoServico";
            lblIdAgendamentoServico.Size = new Size(127, 20);
            lblIdAgendamentoServico.TabIndex = 8;
            lblIdAgendamentoServico.Text = "ID-Agendamento";
            lblIdAgendamentoServico.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtIdOrcamentoServico
            // 
            txtIdOrcamentoServico.Location = new Point(31, 218);
            txtIdOrcamentoServico.Name = "txtIdOrcamentoServico";
            txtIdOrcamentoServico.Size = new Size(127, 23);
            txtIdOrcamentoServico.TabIndex = 7;
            // 
            // lblIdOrcamentoServico
            // 
            lblIdOrcamentoServico.AutoSize = true;
            lblIdOrcamentoServico.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdOrcamentoServico.Location = new Point(31, 186);
            lblIdOrcamentoServico.Name = "lblIdOrcamentoServico";
            lblIdOrcamentoServico.Size = new Size(106, 20);
            lblIdOrcamentoServico.TabIndex = 6;
            lblIdOrcamentoServico.Text = "ID-Orçamento";
            lblIdOrcamentoServico.TextAlign = ContentAlignment.MiddleLeft;
            lblIdOrcamentoServico.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(279, 88);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 4;
            label4.Text = "Cliente";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetalhesServico
            // 
            lblDetalhesServico.AutoSize = true;
            lblDetalhesServico.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetalhesServico.Location = new Point(28, 33);
            lblDetalhesServico.Name = "lblDetalhesServico";
            lblDetalhesServico.Size = new Size(160, 21);
            lblDetalhesServico.TabIndex = 1;
            lblDetalhesServico.Text = "Detalhes do serviço";
            // 
            // tabEmAndamentoServicos
            // 
            tabEmAndamentoServicos.Controls.Add(dataGridView5);
            tabEmAndamentoServicos.Location = new Point(4, 24);
            tabEmAndamentoServicos.Name = "tabEmAndamentoServicos";
            tabEmAndamentoServicos.Padding = new Padding(3);
            tabEmAndamentoServicos.Size = new Size(984, 547);
            tabEmAndamentoServicos.TabIndex = 1;
            tabEmAndamentoServicos.Text = "Em andamento";
            tabEmAndamentoServicos.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Columns.AddRange(new DataGridViewColumn[] { IDServico, Tipodeservico, ClienteServico, StatusServico });
            dataGridView5.Location = new Point(1, 0);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(984, 550);
            dataGridView5.TabIndex = 0;
            // 
            // IDServico
            // 
            IDServico.HeaderText = "ID-Serviço";
            IDServico.Name = "IDServico";
            // 
            // Tipodeservico
            // 
            Tipodeservico.HeaderText = "Tipo de serviço";
            Tipodeservico.Name = "Tipodeservico";
            // 
            // ClienteServico
            // 
            ClienteServico.HeaderText = "Cliente";
            ClienteServico.Name = "ClienteServico";
            // 
            // StatusServico
            // 
            StatusServico.HeaderText = "Status do Serviço";
            StatusServico.Name = "StatusServico";
            // 
            // tabReprovadoServico
            // 
            tabReprovadoServico.Controls.Add(dataGridView6);
            tabReprovadoServico.Location = new Point(4, 24);
            tabReprovadoServico.Name = "tabReprovadoServico";
            tabReprovadoServico.Size = new Size(984, 547);
            tabReprovadoServico.TabIndex = 2;
            tabReprovadoServico.Text = "Reprovado";
            tabReprovadoServico.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18 });
            dataGridView6.Location = new Point(0, 0);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.Size = new Size(985, 550);
            dataGridView6.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.HeaderText = "ID-Serviço";
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.HeaderText = "Tipo de serviço";
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.HeaderText = "Cliente";
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // tabAprovadoServico
            // 
            tabAprovadoServico.Controls.Add(dataGridView7);
            tabAprovadoServico.Location = new Point(4, 24);
            tabAprovadoServico.Name = "tabAprovadoServico";
            tabAprovadoServico.Size = new Size(984, 547);
            tabAprovadoServico.TabIndex = 3;
            tabAprovadoServico.Text = "Aprovado";
            tabAprovadoServico.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn19, dataGridViewTextBoxColumn20, dataGridViewTextBoxColumn21 });
            dataGridView7.Location = new Point(0, 0);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.Size = new Size(988, 550);
            dataGridView7.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.HeaderText = "ID-Serviço";
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            dataGridViewTextBoxColumn20.HeaderText = "Tipo de serviço";
            dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewTextBoxColumn21.HeaderText = "Cliente";
            dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // tabTodosServicos
            // 
            tabTodosServicos.Controls.Add(dataGridView8);
            tabTodosServicos.Location = new Point(4, 24);
            tabTodosServicos.Name = "tabTodosServicos";
            tabTodosServicos.Size = new Size(984, 547);
            tabTodosServicos.TabIndex = 4;
            tabTodosServicos.Text = "Todos";
            tabTodosServicos.UseVisualStyleBackColor = true;
            // 
            // dataGridView8
            // 
            dataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView8.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn22, dataGridViewTextBoxColumn23, dataGridViewTextBoxColumn24, dataGridViewTextBoxColumn25, StatusOrcamento });
            dataGridView8.Location = new Point(0, 0);
            dataGridView8.Name = "dataGridView8";
            dataGridView8.Size = new Size(985, 550);
            dataGridView8.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn22
            // 
            dataGridViewTextBoxColumn22.HeaderText = "ID-Serviço";
            dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            dataGridViewTextBoxColumn23.HeaderText = "Tipo de serviço";
            dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            dataGridViewTextBoxColumn24.HeaderText = "Cliente";
            dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            dataGridViewTextBoxColumn25.HeaderText = "Status do Serviço";
            dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // StatusOrcamento
            // 
            StatusOrcamento.HeaderText = "Status do Orçamento";
            StatusOrcamento.Name = "StatusOrcamento";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1170, 681);
            Controls.Add(pnlAgendamentos);
            Controls.Add(pnlClientes);
            Controls.Add(btnSair);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnNovo);
            Controls.Add(btnConsulta);
            Controls.Add(btnFormTecnicos);
            Controls.Add(btnFormServicos);
            Controls.Add(btnFormAgendamentos);
            Controls.Add(btnFormClientes);
            Controls.Add(pnlServicos);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RC System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)listaClientes).EndInit();
            pnlClientes.ResumeLayout(false);
            pnlAgendamentos.ResumeLayout(false);
            pnlTecnico.ResumeLayout(false);
            pnlCriarTecnico.ResumeLayout(false);
            pnlCriarTecnico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTecnicos).EndInit();
            pnlDetalhesAgendamento.ResumeLayout(false);
            pnlDetalhesAgendamento.PerformLayout();
            tabControlAgendamento.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabTodos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            pnlServicos.ResumeLayout(false);
            tabServicos.ResumeLayout(false);
            tabDetalhesServico.ResumeLayout(false);
            tabDetalhesServico.PerformLayout();
            groupBoxDetalhesOrcamento.ResumeLayout(false);
            groupBoxDetalhesOrcamento.PerformLayout();
            tabEmAndamentoServicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            tabReprovadoServico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            tabAprovadoServico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            tabTodosServicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView8).EndInit();
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
        private Panel pnlClientes;
        private TabControl tabControlAgendamento;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DateTimePicker dateTimePicker1;
        private MonthCalendar mesCalendario;
        private TabPage tabPage3;
        private ListBox listHoras;
        private Button btnInserirHora;
        private Panel pnlDetalhesAgendamento;
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
        private TabPage tabPage4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDAgendamento;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn LocalDoServiço;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Hora;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private TabPage tabTodos;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn Status;
        private Panel pnlAgendamentos;
        private Panel pnlServicos;
        private TabControl tabServicos;
        private TabPage tabDetalhesServico;
        private TabPage tabEmAndamentoServicos;
        private TabPage tabReprovadoServico;
        private TabPage tabAprovadoServico;
        private TabPage tabTodosServicos;
        private TextBox txtIdOrcamentoServico;
        private Label lblIdOrcamentoServico;
        private Label label4;
        private Label lblDetalhesServico;
        private TextBox txtAgendamentoServico;
        private Label lblIdAgendamentoServico;
        private Label label7;
        private Label lblNomeTecnicoServico;
        private GroupBox groupBoxDetalhesOrcamento;
        private Label lblValorTotalServico;
        private Label lblDescricaoOrcamentoServico;
        private Label label8;
        private Label lblPrecoServico;
        private Label lblTipoServicoServicos;
        private Button btnGerarServico;
        private Label lblNomeClienteServico;
        private Label lblTipoServicoOrcamentoValor;
        private Label label6;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button btnCancelarServico;
        private Button btnSalvarServico;
        private DataGridView dataGridView5;
        private DataGridViewTextBoxColumn IDServico;
        private DataGridViewTextBoxColumn Tipodeservico;
        private DataGridViewTextBoxColumn ClienteServico;
        private DataGridViewTextBoxColumn StatusServico;
        private DataGridView dataGridView6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridView dataGridView7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridView dataGridView8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn StatusOrcamento;
        private Panel pnlTecnico;
        private ComboBox cmbFormaPagamento;
        private Label lblFormaPagamento;
        private DataGridView dataGridTecnicos;
        private DataGridViewTextBoxColumn IDTecnico;
        private DataGridViewTextBoxColumn NomeTecnico;
        private DataGridViewTextBoxColumn CpfTecnico;
        private Panel pnlCriarTecnico;
        private Label lblTituloCriarTecnico;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label13;
        private Label label12;
        private Label lblNomeTecnico;
        private DataGridViewTextBoxColumn TelefoneTecnico;
        private Button button3;
        private Button btnCadastrar;
    }
}
