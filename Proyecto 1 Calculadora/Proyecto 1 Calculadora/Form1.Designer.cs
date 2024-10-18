
namespace Proyecto_1_Calculadora
{
    partial class Form1
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
            Pantalla = new TextBox();
            Raiz = new Button();
            Btn_eliminar = new Button();
            Btn_Eliminar_caracter = new Button();
            Btn_Division = new Button();
            Elevar_al_cuadrado = new Button();
            Btn7 = new Button();
            btn8 = new Button();
            Btn9 = new Button();
            Mas = new Button();
            Btn4 = new Button();
            Base_10_elevada = new Button();
            Btn5 = new Button();
            Btn6 = new Button();
            Menos = new Button();
            Logaritmo = new Button();
            Btn1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            Multiplicacion = new Button();
            x_elevada_y = new Button();
            Ran = new Button();
            Btn_cero = new Button();
            Igual = new Button();
            SuspendLayout();
            // 
            // Pantalla
            // 
            Pantalla.Location = new Point(14, 13);
            Pantalla.Name = "Pantalla";
            Pantalla.ReadOnly = true;
            Pantalla.Size = new Size(318, 23);
            Pantalla.TabIndex = 0;
            Pantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // Raiz
            // 
            Raiz.Location = new Point(14, 52);
            Raiz.Name = "Raiz";
            Raiz.Size = new Size(75, 47);
            Raiz.TabIndex = 1;
            Raiz.Text = "√x";
            Raiz.UseVisualStyleBackColor = true;
            Raiz.Click += Raiz_Click;
            // 
            // Btn_eliminar
            // 
            Btn_eliminar.Location = new Point(95, 52);
            Btn_eliminar.Name = "Btn_eliminar";
            Btn_eliminar.Size = new Size(75, 47);
            Btn_eliminar.TabIndex = 1;
            Btn_eliminar.Text = "C";
            Btn_eliminar.UseVisualStyleBackColor = true;
            Btn_eliminar.Click += Btn_eliminar_Click;
            // 
            // Btn_Eliminar_caracter
            // 
            Btn_Eliminar_caracter.Location = new Point(257, 53);
            Btn_Eliminar_caracter.Name = "Btn_Eliminar_caracter";
            Btn_Eliminar_caracter.Size = new Size(156, 47);
            Btn_Eliminar_caracter.TabIndex = 1;
            Btn_Eliminar_caracter.Text = "⌫";
            Btn_Eliminar_caracter.UseVisualStyleBackColor = true;
            Btn_Eliminar_caracter.Click += Btn_Eliminar_caracter_Click;
            // 
            // Btn_Division
            // 
            Btn_Division.Location = new Point(176, 52);
            Btn_Division.Name = "Btn_Division";
            Btn_Division.Size = new Size(75, 47);
            Btn_Division.TabIndex = 1;
            Btn_Division.Text = "÷";
            Btn_Division.UseVisualStyleBackColor = true;
            Btn_Division.Click += Btn_Division_Click;
            // 
            // Elevar_al_cuadrado
            // 
            Elevar_al_cuadrado.Location = new Point(12, 264);
            Elevar_al_cuadrado.Name = "Elevar_al_cuadrado";
            Elevar_al_cuadrado.Size = new Size(75, 47);
            Elevar_al_cuadrado.TabIndex = 1;
            Elevar_al_cuadrado.Text = " x²";
            Elevar_al_cuadrado.UseVisualStyleBackColor = true;
            Elevar_al_cuadrado.Click += Elevar_al_cuadrado_Click;
            // 
            // Btn7
            // 
            Btn7.Location = new Point(95, 105);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(75, 47);
            Btn7.TabIndex = 1;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = true;
            Btn7.Click += Btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(176, 105);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 47);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Btn8_Click;
            // 
            // Btn9
            // 
            Btn9.Location = new Point(257, 106);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(75, 47);
            Btn9.TabIndex = 1;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = true;
            Btn9.Click += Btn9_Click;
            // 
            // Mas
            // 
            Mas.Location = new Point(338, 158);
            Mas.Name = "Mas";
            Mas.Size = new Size(75, 47);
            Mas.TabIndex = 1;
            Mas.Text = "+";
            Mas.UseVisualStyleBackColor = true;
            Mas.Click += Mas_Click;
            // 
            // Btn4
            // 
            Btn4.Location = new Point(93, 158);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(75, 47);
            Btn4.TabIndex = 1;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = true;
            Btn4.Click += Btn4_Click;
            // 
            // Base_10_elevada
            // 
            Base_10_elevada.Location = new Point(12, 158);
            Base_10_elevada.Name = "Base_10_elevada";
            Base_10_elevada.Size = new Size(75, 47);
            Base_10_elevada.TabIndex = 1;
            Base_10_elevada.Text = " 10^x";
            Base_10_elevada.UseVisualStyleBackColor = true;
            Base_10_elevada.Click += Base_10_elevada_Click;
            // 
            // Btn5
            // 
            Btn5.Location = new Point(176, 158);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(75, 47);
            Btn5.TabIndex = 1;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = true;
            Btn5.Click += Btn5_Click;
            // 
            // Btn6
            // 
            Btn6.Location = new Point(257, 159);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(75, 47);
            Btn6.TabIndex = 1;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = true;
            Btn6.Click += Btn6_Click;
            // 
            // Menos
            // 
            Menos.Location = new Point(338, 105);
            Menos.Name = "Menos";
            Menos.Size = new Size(75, 47);
            Menos.TabIndex = 1;
            Menos.Text = "-";
            Menos.UseVisualStyleBackColor = true;
            Menos.Click += Menos_Click;
            // 
            // Logaritmo
            // 
            Logaritmo.Location = new Point(14, 211);
            Logaritmo.Name = "Logaritmo";
            Logaritmo.Size = new Size(75, 47);
            Logaritmo.TabIndex = 1;
            Logaritmo.Text = "log";
            Logaritmo.UseVisualStyleBackColor = true;
            Logaritmo.Click += Logaritmo_Click;
            // 
            // Btn1
            // 
            Btn1.Location = new Point(95, 211);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(75, 47);
            Btn1.TabIndex = 1;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Btn1_Click;
            // 
            // Btn2
            // 
            Btn2.Location = new Point(176, 211);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(75, 47);
            Btn2.TabIndex = 1;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += Btn2_Click;
            // 
            // Btn3
            // 
            Btn3.Location = new Point(257, 212);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(75, 47);
            Btn3.TabIndex = 1;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += Btn3_Click;
            // 
            // Multiplicacion
            // 
            Multiplicacion.Location = new Point(257, 265);
            Multiplicacion.Name = "Multiplicacion";
            Multiplicacion.Size = new Size(75, 47);
            Multiplicacion.TabIndex = 1;
            Multiplicacion.Text = "x";
            Multiplicacion.UseVisualStyleBackColor = true;
            Multiplicacion.Click += Multiplicacion_Click;
            // 
            // x_elevada_y
            // 
            x_elevada_y.Location = new Point(12, 105);
            x_elevada_y.Name = "x_elevada_y";
            x_elevada_y.Size = new Size(75, 47);
            x_elevada_y.TabIndex = 1;
            x_elevada_y.Text = " x^y";
            x_elevada_y.UseVisualStyleBackColor = true;
            x_elevada_y.Click += x_elevada_y_Click;
            // 
            // Ran
            // 
            Ran.Location = new Point(95, 264);
            Ran.Name = "Ran";
            Ran.Size = new Size(75, 47);
            Ran.TabIndex = 1;
            Ran.Text = ".";
            Ran.UseVisualStyleBackColor = true;
            Ran.Click += Ran_Click;
            // 
            // Btn_cero
            // 
            Btn_cero.Location = new Point(176, 264);
            Btn_cero.Name = "Btn_cero";
            Btn_cero.Size = new Size(75, 47);
            Btn_cero.TabIndex = 1;
            Btn_cero.Text = "0";
            Btn_cero.UseVisualStyleBackColor = true;
            Btn_cero.Click += Btn_cero_Click;
            // 
            // Igual
            // 
            Igual.Location = new Point(338, 211);
            Igual.Name = "Igual";
            Igual.Size = new Size(75, 100);
            Igual.TabIndex = 1;
            Igual.Text = "=";
            Igual.UseVisualStyleBackColor = true;
            Igual.Click += Igual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 319);
            Controls.Add(Igual);
            Controls.Add(Multiplicacion);
            Controls.Add(Btn3);
            Controls.Add(Menos);
            Controls.Add(Btn6);
            Controls.Add(Btn_cero);
            Controls.Add(Mas);
            Controls.Add(Btn2);
            Controls.Add(Btn9);
            Controls.Add(Btn5);
            Controls.Add(Ran);
            Controls.Add(Btn1);
            Controls.Add(btn8);
            Controls.Add(Base_10_elevada);
            Controls.Add(x_elevada_y);
            Controls.Add(Btn_Division);
            Controls.Add(Logaritmo);
            Controls.Add(Btn7);
            Controls.Add(Btn4);
            Controls.Add(Btn_Eliminar_caracter);
            Controls.Add(Elevar_al_cuadrado);
            Controls.Add(Btn_eliminar);
            Controls.Add(Raiz);
            Controls.Add(Pantalla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox Pantalla;
        private Button Raiz;
        private Button Btn_eliminar;
        private Button Btn_Eliminar_caracter;
        private Button Btn_Division;
        private Button Elevar_al_cuadrado;
        private Button Btn7;
        private Button btn8;
        private Button Btn9;
        private Button Mas;
        private Button Btn4;
        private Button Base_10_elevada;
        private Button Btn5;
        private Button Btn6;
        private Button Menos;
        private Button Logaritmo;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Button Multiplicacion;
        private Button x_elevada_y;
        private Button Ran;
        private Button Btn_cero;
        private Button Igual;
    }
}
