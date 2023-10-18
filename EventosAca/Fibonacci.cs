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
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_MENU menu = new F_MENU();
            menu.Show();
        }

        private void para_Click(object sender, EventArgs e)
        {

        }

        private void mientras_Click(object sender, EventArgs e)
        {
            String _num = text_numero.Text;
            label_respuesta.Text = _num;

        }

    }
}
