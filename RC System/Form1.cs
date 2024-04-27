using System.DirectoryServices.ActiveDirectory;

namespace RC_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlClientes.Visible = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroCliente open = new FormCadastroCliente();
            open.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FormExcluir open = new FormExcluir();
            open.Show();
        }

        private void btnFormClientes_Click(object sender, EventArgs e)
        {
            pnlAgendamentos.Visible = false;
            pnlDetalhesAgendamento.Visible = false;
            pnlServicos.Visible = false;
            pnlTecnico.Visible = false;
            pnlCriarTecnico.Visible = false;
            pnlClientes.Visible = true;
        }

        private void listaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFormAgendamentos_Click(object sender, EventArgs e)
        {

            pnlServicos.Visible = false;
            pnlTecnico.Visible = false;
            pnlCriarTecnico.Visible = false;
            pnlClientes.Visible = true;
            pnlAgendamentos.Visible = true;
            pnlDetalhesAgendamento.Visible = true;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (pnlClientes.Visible == true)
            {
                FormCadastroCliente open = new FormCadastroCliente();
                open.Show();
            }

            if (pnlServicos.Visible == true)
            {

                AlterarServico change = new AlterarServico();
                change.Show();
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Create a new DateTimePicker control and initialize it.
            DateTimePicker dateTimePicker1 = new DateTimePicker();

            // Set the MinDate and MaxDate.
            dateTimePicker1.MinDate = new DateTime(1985, 6, 20);
            dateTimePicker1.MaxDate = DateTime.Today;

            // Set the CustomFormat string.
            dateTimePicker1.CustomFormat = "dd/MM/yy - HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            MontarHorarios();
        }

        private void MontarHorarios()
        {
            var horarioInicio = new TimeSpan(8, 0, 0);
            var incremento = new TimeSpan(0, 30, 0);
            var horarioFim = new TimeSpan(20, 0, 0);

            for (int i = 0; i <= horarioFim.Hours; i++)
            {
                listHoras.Items.Add(horarioInicio.ToString().Substring(0, 5).PadLeft(10));
                horarioInicio += incremento;
            }

        }

        private void listHoras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mesCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            MontarHorarios();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblDataSelecionada_Click(object sender, EventArgs e)
        {

        }

        private void tabControlAgendamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFormServicos_Click(object sender, EventArgs e)
        {
            pnlTecnico.Visible = false;
            pnlCriarTecnico.Visible = false;
            pnlClientes.Visible = false;
            pnlAgendamentos.Visible = false;
            pnlDetalhesAgendamento.Visible = false;
            pnlServicos.Visible = true;


        }

        private void btnFormTecnicos_Click(object sender, EventArgs e)
        {
            pnlClientes.Visible = false;
            pnlAgendamentos.Visible = false;
            pnlDetalhesAgendamento.Visible = false; 
            pnlServicos.Visible = false;
            pnlTecnico.Visible = true;
            pnlCriarTecnico.Visible = true;

        }


        private void pnlServicos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabDetalhesServico_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridTecnicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlTecnico_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
