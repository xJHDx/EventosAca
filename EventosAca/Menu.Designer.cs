namespace EventosAca
{
    partial class F_MENU
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titulo_menu = new Label();
            btn_evento = new Button();
            btn_para = new Button();
            SuspendLayout();
            // 
            // titulo_menu
            // 
            titulo_menu.AutoSize = true;
            titulo_menu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titulo_menu.Location = new Point(32, 18);
            titulo_menu.Name = "titulo_menu";
            titulo_menu.Size = new Size(154, 21);
            titulo_menu.TabIndex = 0;
            titulo_menu.Text = "Oscar Torres #12343";
            titulo_menu.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btn_evento
            // 
            btn_evento.Location = new Point(42, 65);
            btn_evento.Name = "btn_evento";
            btn_evento.Size = new Size(135, 23);
            btn_evento.TabIndex = 0;
            btn_evento.Text = "Ingreso Evento";
            btn_evento.UseVisualStyleBackColor = true;
            btn_evento.Click += evento_Click;
            // 
            // btn_para
            // 
            btn_para.Location = new Point(42, 108);
            btn_para.Name = "btn_para";
            btn_para.Size = new Size(135, 23);
            btn_para.TabIndex = 1;
            btn_para.Text = "Fibonacci";
            btn_para.UseVisualStyleBackColor = true;
            btn_para.Click += fibonacci_Click;
            // 
            // F_MENU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 159);
            Controls.Add(btn_para);
            Controls.Add(btn_evento);
            Controls.Add(titulo_menu);
            Name = "F_MENU";
            Text = "MENU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo_menu;
        private Button btn_evento;
        private Button btn_para;
    }
}