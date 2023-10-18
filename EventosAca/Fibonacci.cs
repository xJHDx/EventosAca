using System.Text;


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
            int.TryParse(text_numero.Text, out int _num);
            if (_num <= 0)
            {
               // textBoxResultado.Text = "Por favor, ingrese un número positivo.";
            }
            else
            {
                int first = 0;
                int second = 1;
                StringBuilder fibonacciSequence = new StringBuilder();
                for (int i = 0; i < _num; i++)
                {
                    fibonacciSequence.Append(first + " ");
                    int next = first + second;
                    first = second;
                    second = next;
                }
               // textBoxResultado.Text = "Los primeros " + n + " números de la serie de Fibonacci son:\r\n" + fibonacciSequence.ToString();
            }
        }

        private void mientras_Click(object sender, EventArgs e)
        {
            int.TryParse(text_numero.Text, out int _num);
            if (_num <= 0)
            {
                // textBoxResultado.Text = "Por favor, ingrese un número positivo.";
            }
            else 
            {
                int first = 0;
                int second = 1;
                StringBuilder fibonacciSequence = new StringBuilder();

                int i = 0;
                while (i < _num)
                {
                    fibonacciSequence.Append(first + " ");
                    int next = first + second;
                    first = second;
                    second = next;
                    i++;
                }

               // textBoxResultado.Text = "Los primeros " + n + " números de la serie de Fibonacci son:\r\n" + fibonacciSequence.ToString();
            }

        }

    }
}
