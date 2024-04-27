namespace RC_System
{
    partial class AlterarServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarServico));
            lblIdOrcamentoServico = new Label();
            lblCpf = new Label();
            lblNomeClienteAlterarOcamento = new Label();
            lblClienteAlterarOrcamento = new Label();
            cmbFormaPagamento = new ComboBox();
            lblFormaPagamento = new Label();
            cmbBoxTipoServico = new ComboBox();
            lblTipoServicoAlterarOrcamento = new Label();
            lblNomeTecnicoAlterarOrcamento = new Label();
            lblTecnicoAlterarOrcamento = new Label();
            lblDescricaoAlterarOrcamento = new Label();
            lblQuantidadeAlterarOrcamento = new Label();
            txtIdOrcamentoServico = new TextBox();
            textBox1 = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblIdOrcamentoServico
            // 
            lblIdOrcamentoServico.AutoSize = true;
            lblIdOrcamentoServico.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdOrcamentoServico.Location = new Point(50, 52);
            lblIdOrcamentoServico.Name = "lblIdOrcamentoServico";
            lblIdOrcamentoServico.Size = new Size(106, 20);
            lblIdOrcamentoServico.TabIndex = 7;
            lblIdOrcamentoServico.Text = "ID-Orçamento";
            lblIdOrcamentoServico.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.BackColor = Color.Transparent;
            lblCpf.Font = new Font("Segoe UI", 11F);
            lblCpf.Location = new Point(162, 52);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(76, 20);
            lblCpf.TabIndex = 13;
            lblCpf.Text = "ORC-1000";
            lblCpf.Click += lblCpf_Click;
            // 
            // lblNomeClienteAlterarOcamento
            // 
            lblNomeClienteAlterarOcamento.AutoSize = true;
            lblNomeClienteAlterarOcamento.BackColor = Color.Transparent;
            lblNomeClienteAlterarOcamento.Font = new Font("Segoe UI", 11F);
            lblNomeClienteAlterarOcamento.Location = new Point(162, 89);
            lblNomeClienteAlterarOcamento.Name = "lblNomeClienteAlterarOcamento";
            lblNomeClienteAlterarOcamento.Size = new Size(120, 20);
            lblNomeClienteAlterarOcamento.TabIndex = 15;
            lblNomeClienteAlterarOcamento.Text = "Nome do cliente";
            // 
            // lblClienteAlterarOrcamento
            // 
            lblClienteAlterarOrcamento.AutoSize = true;
            lblClienteAlterarOrcamento.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClienteAlterarOrcamento.Location = new Point(50, 89);
            lblClienteAlterarOrcamento.Name = "lblClienteAlterarOrcamento";
            lblClienteAlterarOrcamento.Size = new Size(56, 20);
            lblClienteAlterarOrcamento.TabIndex = 14;
            lblClienteAlterarOrcamento.Text = "Cliente";
            lblClienteAlterarOrcamento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.FormattingEnabled = true;
            cmbFormaPagamento.Items.AddRange(new object[] { "Cartão de crédito", "Cartão de débito", "Transferência bancária" });
            cmbFormaPagamento.Location = new Point(510, 86);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(159, 23);
            cmbFormaPagamento.TabIndex = 29;
            // 
            // lblFormaPagamento
            // 
            lblFormaPagamento.AutoSize = true;
            lblFormaPagamento.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormaPagamento.Location = new Point(348, 89);
            lblFormaPagamento.Name = "lblFormaPagamento";
            lblFormaPagamento.Size = new Size(156, 20);
            lblFormaPagamento.TabIndex = 28;
            lblFormaPagamento.Text = "Forma de pagamento";
            lblFormaPagamento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbBoxTipoServico
            // 
            cmbBoxTipoServico.FormattingEnabled = true;
            cmbBoxTipoServico.Items.AddRange(new object[] { "Cartão de crédito", "Cartão de débito", "Transferência bancária" });
            cmbBoxTipoServico.Location = new Point(510, 49);
            cmbBoxTipoServico.Name = "cmbBoxTipoServico";
            cmbBoxTipoServico.Size = new Size(159, 23);
            cmbBoxTipoServico.TabIndex = 31;
            // 
            // lblTipoServicoAlterarOrcamento
            // 
            lblTipoServicoAlterarOrcamento.AutoSize = true;
            lblTipoServicoAlterarOrcamento.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoServicoAlterarOrcamento.Location = new Point(348, 52);
            lblTipoServicoAlterarOrcamento.Name = "lblTipoServicoAlterarOrcamento";
            lblTipoServicoAlterarOrcamento.Size = new Size(113, 20);
            lblTipoServicoAlterarOrcamento.TabIndex = 30;
            lblTipoServicoAlterarOrcamento.Text = "Tipo de serviço";
            lblTipoServicoAlterarOrcamento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNomeTecnicoAlterarOrcamento
            // 
            lblNomeTecnicoAlterarOrcamento.AutoSize = true;
            lblNomeTecnicoAlterarOrcamento.BackColor = Color.Transparent;
            lblNomeTecnicoAlterarOrcamento.Font = new Font("Segoe UI", 11F);
            lblNomeTecnicoAlterarOrcamento.Location = new Point(162, 122);
            lblNomeTecnicoAlterarOrcamento.Name = "lblNomeTecnicoAlterarOrcamento";
            lblNomeTecnicoAlterarOrcamento.Size = new Size(76, 20);
            lblNomeTecnicoAlterarOrcamento.TabIndex = 33;
            lblNomeTecnicoAlterarOrcamento.Text = "ORC-1000";
            // 
            // lblTecnicoAlterarOrcamento
            // 
            lblTecnicoAlterarOrcamento.AutoSize = true;
            lblTecnicoAlterarOrcamento.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTecnicoAlterarOrcamento.Location = new Point(50, 122);
            lblTecnicoAlterarOrcamento.Name = "lblTecnicoAlterarOrcamento";
            lblTecnicoAlterarOrcamento.Size = new Size(60, 20);
            lblTecnicoAlterarOrcamento.TabIndex = 32;
            lblTecnicoAlterarOrcamento.Text = "Técnico";
            lblTecnicoAlterarOrcamento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescricaoAlterarOrcamento
            // 
            lblDescricaoAlterarOrcamento.AutoSize = true;
            lblDescricaoAlterarOrcamento.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricaoAlterarOrcamento.Location = new Point(50, 197);
            lblDescricaoAlterarOrcamento.Name = "lblDescricaoAlterarOrcamento";
            lblDescricaoAlterarOrcamento.Size = new Size(75, 20);
            lblDescricaoAlterarOrcamento.TabIndex = 34;
            lblDescricaoAlterarOrcamento.Text = "Descrição";
            lblDescricaoAlterarOrcamento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblQuantidadeAlterarOrcamento
            // 
            lblQuantidadeAlterarOrcamento.AutoSize = true;
            lblQuantidadeAlterarOrcamento.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidadeAlterarOrcamento.Location = new Point(348, 122);
            lblQuantidadeAlterarOrcamento.Name = "lblQuantidadeAlterarOrcamento";
            lblQuantidadeAlterarOrcamento.Size = new Size(89, 20);
            lblQuantidadeAlterarOrcamento.TabIndex = 35;
            lblQuantidadeAlterarOrcamento.Text = "Quantidade";
            lblQuantidadeAlterarOrcamento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtIdOrcamentoServico
            // 
            txtIdOrcamentoServico.Location = new Point(510, 119);
            txtIdOrcamentoServico.Name = "txtIdOrcamentoServico";
            txtIdOrcamentoServico.Size = new Size(58, 23);
            txtIdOrcamentoServico.TabIndex = 36;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 220);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(454, 128);
            textBox1.TabIndex = 37;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.PaleGreen;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ActiveCaptionText;
            btnSalvar.Location = new Point(554, 273);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(95, 34);
            btnSalvar.TabIndex = 39;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // AlterarServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(700, 360);
            Controls.Add(btnSalvar);
            Controls.Add(textBox1);
            Controls.Add(txtIdOrcamentoServico);
            Controls.Add(lblQuantidadeAlterarOrcamento);
            Controls.Add(lblDescricaoAlterarOrcamento);
            Controls.Add(lblNomeTecnicoAlterarOrcamento);
            Controls.Add(lblTecnicoAlterarOrcamento);
            Controls.Add(cmbBoxTipoServico);
            Controls.Add(lblTipoServicoAlterarOrcamento);
            Controls.Add(cmbFormaPagamento);
            Controls.Add(lblFormaPagamento);
            Controls.Add(lblNomeClienteAlterarOcamento);
            Controls.Add(lblClienteAlterarOrcamento);
            Controls.Add(lblCpf);
            Controls.Add(lblIdOrcamentoServico);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AlterarServico";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterar Serviço";
            Load += AlterarServico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdOrcamentoServico;
        private Label lblCpf;
        private Label lblNomeClienteAlterarOcamento;
        private Label lblClienteAlterarOrcamento;
        private ComboBox cmbFormaPagamento;
        private Label lblFormaPagamento;
        private ComboBox cmbBoxTipoServico;
        private Label lblTipoServicoAlterarOrcamento;
        private Label lblNomeTecnicoAlterarOrcamento;
        private Label lblTecnicoAlterarOrcamento;
        private Label lblDescricaoAlterarOrcamento;
        private Label lblQuantidadeAlterarOrcamento;
        private TextBox txtIdOrcamentoServico;
        private TextBox textBox1;
        private Button btnSalvar;
    }
}