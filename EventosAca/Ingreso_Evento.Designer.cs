namespace EventosAca
{
    partial class Ingreso_Evento
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_registrar = new Button();
            combo_ocupacion = new ComboBox();
            text_nombres = new TextBox();
            text_identificacion = new TextBox();
            text_edad = new TextBox();
            btn_menu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(87, 43);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 0;
            label1.Text = "Registo de evento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 92);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 136);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Identificacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 179);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "Ocupacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 222);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "Edad";
            // 
            // btn_registrar
            // 
            btn_registrar.Location = new Point(103, 261);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(121, 23);
            btn_registrar.TabIndex = 6;
            btn_registrar.Text = "Registrar Entrada";
            btn_registrar.UseVisualStyleBackColor = true;
            btn_registrar.Click += button2_Click;
            // 
            // combo_ocupacion
            // 
            combo_ocupacion.FormattingEnabled = true;
            combo_ocupacion.Items.AddRange(new object[] { "Estudiante", "Empleado", "Independiente", "Otros" });
            combo_ocupacion.Location = new Point(106, 176);
            combo_ocupacion.Name = "combo_ocupacion";
            combo_ocupacion.Size = new Size(167, 23);
            combo_ocupacion.TabIndex = 7;
            // 
            // text_nombres
            // 
            text_nombres.Location = new Point(106, 89);
            text_nombres.Name = "text_nombres";
            text_nombres.Size = new Size(167, 23);
            text_nombres.TabIndex = 8;
            // 
            // text_identificacion
            // 
            text_identificacion.Location = new Point(106, 133);
            text_identificacion.Name = "text_identificacion";
            text_identificacion.Size = new Size(167, 23);
            text_identificacion.TabIndex = 9;
            // 
            // text_edad
            // 
            text_edad.Location = new Point(106, 214);
            text_edad.Name = "text_edad";
            text_edad.Size = new Size(167, 23);
            text_edad.TabIndex = 10;
            text_edad.KeyPress += text_edad_KeyPress;
            // 
            // btn_menu
            // 
            btn_menu.Location = new Point(12, 12);
            btn_menu.Name = "btn_menu";
            btn_menu.Size = new Size(49, 23);
            btn_menu.TabIndex = 11;
            btn_menu.Text = "Menu";
            btn_menu.UseVisualStyleBackColor = true;
            btn_menu.Click += btn_menu_Click;
            // 
            // Ingreso_Evento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 304);
            Controls.Add(btn_menu);
            Controls.Add(text_edad);
            Controls.Add(text_identificacion);
            Controls.Add(text_nombres);
            Controls.Add(combo_ocupacion);
            Controls.Add(btn_registrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ingreso_Evento";
            Text = "Ingreso Eventos Publicos";
            ResumeLayout(false);
            PerformLayout();
        }

        private void text_edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos (números) y la tecla Backspace (para borrar).
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter ingresado.
            }
        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_registrar;
        private ComboBox combo_ocupacion;
        private TextBox text_nombres;
        private TextBox text_identificacion;
        private TextBox text_edad;
        private Button btn_menu;
    }
}