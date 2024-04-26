namespace RC_System
{
    partial class FormExcluir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExcluir));
            lblExcluir = new Label();
            btnExcluirSim = new Button();
            btnExcluirNão = new Button();
            SuspendLayout();
            // 
            // lblExcluir
            // 
            lblExcluir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExcluir.Location = new Point(25, 23);
            lblExcluir.Name = "lblExcluir";
            lblExcluir.Size = new Size(268, 44);
            lblExcluir.TabIndex = 0;
            lblExcluir.Text = "Tem certeza que deseja excluir esse registro?";
            lblExcluir.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnExcluirSim
            // 
            btnExcluirSim.BackColor = Color.PaleGreen;
            btnExcluirSim.Cursor = Cursors.Hand;
            btnExcluirSim.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirSim.ForeColor = SystemColors.ActiveCaptionText;
            btnExcluirSim.Location = new Point(41, 81);
            btnExcluirSim.Name = "btnExcluirSim";
            btnExcluirSim.Size = new Size(95, 34);
            btnExcluirSim.TabIndex = 22;
            btnExcluirSim.Text = "&Sim";
            btnExcluirSim.UseVisualStyleBackColor = false;
            btnExcluirSim.Click += btnExcluirSim_Click;
            // 
            // btnExcluirNão
            // 
            btnExcluirNão.BackColor = Color.IndianRed;
            btnExcluirNão.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluirNão.Location = new Point(173, 81);
            btnExcluirNão.Name = "btnExcluirNão";
            btnExcluirNão.Size = new Size(95, 34);
            btnExcluirNão.TabIndex = 23;
            btnExcluirNão.Text = "&Não";
            btnExcluirNão.UseVisualStyleBackColor = false;
            btnExcluirNão.Click += this.btnExcluirNão_Click;
            // 
            // FormExcluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(316, 134);
            Controls.Add(btnExcluirNão);
            Controls.Add(btnExcluirSim);
            Controls.Add(lblExcluir);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormExcluir";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Excluir registro";
            Load += FormExcluir_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblExcluir;
        private Button btnExcluirSim;
        private Button btnExcluirNão;
    }
}