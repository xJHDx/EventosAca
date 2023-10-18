namespace EventosAca
{
    public partial class Ingreso_Evento : Form
    {
        public Ingreso_Evento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(text_edad.Text, out int edad);
            string? selectedValue = combo_ocupacion.SelectedItem as string;

            if (text_nombres.Text.Length > 0 && text_identificacion.Text.Length > 0 && text_edad.Text.Length > 0 && combo_ocupacion.Text.Length > 0)
            {
                if (edad < 16)
                {
                    /// mensaje de que no puede ingresar es mejor que 16. 
                }
                else if (edad > 16 && edad < 21 && selectedValue == "Estudiante")
                {
                    // Mensaje de Ingresan Gratis.
                }
                else 
                { 
                    // Mensaje que debe pagar una entrada.
                }
            }
            else
            {
                const string message = "Por favor, complete todos los campos antes de continuar.";
                const string caption = "Campos Incompletos";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_MENU menu = new F_MENU();
            menu.Show();
        }

        private void Ingreso_Evento_Load(object sender, EventArgs e)
        {

        }
    }
}
