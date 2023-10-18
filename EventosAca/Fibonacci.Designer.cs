namespace EventosAca
{
    partial class Fibonacci
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            text_numero = new TextBox();
            label2 = new Label();
            label_respuesta = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(49, 23);
            button1.TabIndex = 0;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += menu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 51);
            label1.Name = "label1";
            label1.Size = new Size(256, 21);
            label1.TabIndex = 1;
            label1.Text = "Calculadora de la serie de Fibonacci";
            // 
            // button2
            // 
            button2.Location = new Point(139, 91);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "PARA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += para_Click;
            // 
            // button3
            // 
            button3.Location = new Point(220, 92);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "MIENTRAS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += mientras_Click;
            // 
            // text_numero
            // 
            text_numero.Location = new Point(84, 91);
            text_numero.Name = "text_numero";
            text_numero.Size = new Size(49, 23);
            text_numero.TabIndex = 4;
            text_numero.KeyPress += text_number_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 96);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Numero";
            // 
            // label_respuesta
            // 
            label_respuesta.AutoSize = true;
            label_respuesta.Location = new Point(78, 140);
            label_respuesta.Name = "label_respuesta";
            label_respuesta.Size = new Size(0, 15);
            label_respuesta.TabIndex = 6;
            // 
            // Fibonacci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 320);
            Controls.Add(label_respuesta);
            Controls.Add(label2);
            Controls.Add(text_numero);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Fibonacci";
            Text = "Fibonacci";
            ResumeLayout(false);
            PerformLayout();
        }

        private void text_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos (números) y la tecla Backspace (para borrar).
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter ingresado.
            }
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private TextBox text_numero;
        private Label label2;
        private Label label_respuesta;
    }
}