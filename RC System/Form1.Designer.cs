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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            GuiaMenuClientes = new ToolStripMenuItem();
            serviçosToolStripMenuItem = new ToolStripMenuItem();
            agendamentosToolStripMenuItem = new ToolStripMenuItem();
            técnicosToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            toolStripSeparator1 = new ToolStripSeparator();
            btnConsultaCliente = new Button();
            btnNovoCliente = new Button();
            btnAlterarCliente = new Button();
            btnExcluirCliente = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { GuiaMenuClientes, serviçosToolStripMenuItem, agendamentosToolStripMenuItem, técnicosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // GuiaMenuClientes
            // 
            GuiaMenuClientes.Name = "GuiaMenuClientes";
            GuiaMenuClientes.Size = new Size(61, 20);
            GuiaMenuClientes.Text = "Clientes";
            GuiaMenuClientes.TextDirection = ToolStripTextDirection.Horizontal;
            GuiaMenuClientes.Click += toolStripMenuItem1_Click;
            // 
            // serviçosToolStripMenuItem
            // 
            serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            serviçosToolStripMenuItem.Size = new Size(62, 20);
            serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // agendamentosToolStripMenuItem
            // 
            agendamentosToolStripMenuItem.Name = "agendamentosToolStripMenuItem";
            agendamentosToolStripMenuItem.Size = new Size(100, 20);
            agendamentosToolStripMenuItem.Text = "Agendamentos";
            // 
            // técnicosToolStripMenuItem
            // 
            técnicosToolStripMenuItem.Name = "técnicosToolStripMenuItem";
            técnicosToolStripMenuItem.Size = new Size(64, 20);
            técnicosToolStripMenuItem.Text = "Técnicos";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { toolStripSeparator1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 10);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(57, 6);
            // 
            // btnConsultaCliente
            // 
            btnConsultaCliente.Location = new Point(12, 41);
            btnConsultaCliente.Name = "btnConsultaCliente";
            btnConsultaCliente.Size = new Size(86, 33);
            btnConsultaCliente.TabIndex = 5;
            btnConsultaCliente.Text = "&Consulta";
            btnConsultaCliente.UseVisualStyleBackColor = true;
            btnConsultaCliente.Click += button1_Click;
            // 
            // btnNovoCliente
            // 
            btnNovoCliente.Cursor = Cursors.Hand;
            btnNovoCliente.Location = new Point(121, 41);
            btnNovoCliente.Name = "btnNovoCliente";
            btnNovoCliente.Size = new Size(86, 33);
            btnNovoCliente.TabIndex = 6;
            btnNovoCliente.Text = "&Novo";
            btnNovoCliente.UseVisualStyleBackColor = true;
            // 
            // btnAlterarCliente
            // 
            btnAlterarCliente.Location = new Point(230, 41);
            btnAlterarCliente.Name = "btnAlterarCliente";
            btnAlterarCliente.Size = new Size(86, 33);
            btnAlterarCliente.TabIndex = 7;
            btnAlterarCliente.Text = "&Alterar";
            btnAlterarCliente.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCliente
            // 
            btnExcluirCliente.Location = new Point(341, 41);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.Size = new Size(86, 33);
            btnExcluirCliente.TabIndex = 8;
            btnExcluirCliente.Text = "&Excluir";
            btnExcluirCliente.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(126, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnExcluirCliente);
            Controls.Add(btnAlterarCliente);
            Controls.Add(btnNovoCliente);
            Controls.Add(btnConsultaCliente);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "ClienteForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem GuiaMenuClientes;
        private ToolStripMenuItem serviçosToolStripMenuItem;
        private ToolStripMenuItem agendamentosToolStripMenuItem;
        private ToolStripMenuItem técnicosToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripSeparator toolStripSeparator1;
        private Button btnConsultaCliente;
        private Button btnNovoCliente;
        private Button btnAlterarCliente;
        private Button btnExcluirCliente;
        private DataGridView dataGridView1;
    }
}
