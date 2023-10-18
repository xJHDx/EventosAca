using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (text_nombres.Text.Length > 0 && text_identificacion.Text.Length > 0 && text_edad.Text.Length > 0 && combo_ocupacion.Text.Length > 0)
            {

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

    }
}
