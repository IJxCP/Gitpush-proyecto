namespace Proyecto_1_Calculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operacion;
        private double resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_cero_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "9";
        }

        private void Ran_Click(object sender, EventArgs e)
        {
            // Añadir un punto decimal
            if (!Pantalla.Text.Contains(","))
            {
                Pantalla.Text += ",";
            }
        }

        private void Btn_Eliminar_caracter_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length > 0)
            {
                Pantalla.Text = Pantalla.Text.Remove(Pantalla.Text.Length - 1, 1);
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void Mas_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Pantalla.Text, out primero))
            {
                operacion = "+";
                Pantalla.Clear();
            }
            else
            {
                Pantalla.Text = "Por favor ingrese un número";
            }
        }

        private void Menos_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Pantalla.Text, out primero))
            {
                operacion = "-";
                Pantalla.Clear();
            }
            else
            {
                Pantalla.Text = "Por favor ingrese un número";
            }
        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Pantalla.Text, out primero))
            {
                operacion = "x";
                Pantalla.Clear();
            }
            else
            {
                Pantalla.Text = "Por favor ingrese un número";
            }
        }

        private void Btn_Division_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Pantalla.Text, out primero))
            {
                operacion = "÷";
                Pantalla.Clear();
            }
            else
            {
                Pantalla.Text = "Por favor ingrese un número";
            }
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Pantalla.Text, out segundo))
            {
                Operacion operacionRealizada = null;

                switch (operacion)
                {
                    case "+":
                        operacionRealizada = new Suma(primero, segundo);
                        break;
                    case "-":
                        operacionRealizada = new Resta(primero, segundo);
                        break;
                    case "x":
                        operacionRealizada = new Multiplicacion(primero, segundo);
                        break;
                    case "÷":
                        operacionRealizada = new Division(primero, segundo);
                        break;
                }

                if (operacionRealizada != null)
                {
                    resultado = operacionRealizada.Calcular();
                    Pantalla.Text = resultado.ToString();
                }
            }
            else
            {
                Pantalla.Text = "Por favor ingrese un número";
            }
        }

        private void Logaritmo_Click(object sender, EventArgs e)
        {
            double numero;
            if (double.TryParse(Pantalla.Text, out numero))
            {
                try
                {
                    var logaritmo = new Logaritmo(numero);
                    Pantalla.Text = logaritmo.Calcular().ToString();
                }
                catch (InvalidOperationException ex)
                {
                    Pantalla.Text = ex.Message;
                }
            }
            else
            {
                Pantalla.Text = "Por favor ingrese un número";
            }
        }

        private void Elevar_al_cuadrado_Click(object sender, EventArgs e)
        {
            double primero;
            if (double.TryParse(Pantalla.Text, out primero))
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Por favor ponga un número para elevarlo a la potencia (y):", "Potencia", "2");
                double y;

                if (double.TryParse(input, out y))
                {
                    var potencia = new Potencia(primero, y);
                    Pantalla.Text = potencia.Calcular().ToString();
                }
                else
                {
                    Pantalla.Text = "Error: Potencia inválida";
                }
            }
            else
            {
                Pantalla.Text = "Por favor ingrese un número";
            }
        }

        private void Base_10_elevada_Click(object sender, EventArgs e)
        {
            double numero;
            if (double.TryParse(Pantalla.Text, out numero))
            {
                var potencia = new Potencia(10, numero);
                Pantalla.Text = potencia.Calcular().ToString();
            }
            else
            {
                Pantalla.Text = "Por favor ingrese un número";
            }
        }

        private void x_elevada_y_Click(object sender, EventArgs e)
        {
            double x;
            if (double.TryParse(Pantalla.Text, out x))
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Por favor ponga un número para la potencia (y):", "Elevar x a y", "2");
                double y;

                if (double.TryParse(input, out y))
                {
                    var potencia = new Potencia(x, y);
                    Pantalla.Text = potencia.Calcular().ToString();
                }
                else
                {
                    Pantalla.Text = "Error: Potencia inválida";
                }
            }
            else
            {
                Pantalla.Text = "Por favor ingrese un número";
            }
        }

        private void Raiz_Click(object sender, EventArgs e)
        {
            double primero;
            if (double.TryParse(Pantalla.Text, out primero))
            {
                try
                {
                    var raiz = new RaizCuadrada(primero);
                    Pantalla.Text = raiz.Calcular().ToString();
                }
                catch (InvalidOperationException ex)
                {
                    Pantalla.Text = ex.Message;
                }
            }
            else
            {
                Pantalla.Text = "Por favor ingrese un número";
            }
        }
    }
}
