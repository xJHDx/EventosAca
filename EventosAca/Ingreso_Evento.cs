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

            string message;
            string caption;

            if (text_nombres.Text.Length > 0 && text_identificacion.Text.Length > 0 && text_edad.Text.Length > 0 && combo_ocupacion.Text.Length > 0)
            {
                if (edad < 16)
                {
                    message = "No pude Ingresar es Mejor de 16 Años";
                    caption = "Ingreso no Autorizado";
                }
                else if (edad > 16 && edad < 21 && selectedValue == "Estudiante")
                {
                    message = "Ingreso Autorizado, El estudiantes " + text_nombres.Text + " Ingresa Gratis";
                    caption = "Ingreso Gratis";
                }
                else 
                {
                    message = "Ingreso Autorizado, El Usuario " + text_nombres.Text + "debe de pagar la Entrada de Valor: $30.000";
                    caption = "Ingreso De Pago";
                }
            }
            else
            {
                message = "Por favor, complete todos los campos antes de continuar.";
                caption = "Campos Incompletos";
            }
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
