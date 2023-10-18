namespace EventosAca
{
    public partial class F_MENU : Form
    {
        public F_MENU()
        {
            InitializeComponent();
        }

        private void fibonacci_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.Show();
        }

        private void evento_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingreso_Evento ingreso = new Ingreso_Evento();
            ingreso.Show();
        }
    }
}