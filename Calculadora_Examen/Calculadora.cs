namespace Calculadora_Examen
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operacion;

        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.ClaseSuma objeto1 = new Clases.ClaseSuma();
        Clases.ClaseResta objeto2 = new Clases.ClaseResta();
        Clases.ClaseMultipliacion objeto3 = new Clases.ClaseMultipliacion();
        Clases.ClaseDivision objeto4 = new Clases.ClaseDivision();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtPantalla.Text);

            double Sum;
            double Rest;
            double Mul;
            double Div;

            switch(operacion)
            {
                case "+":
                    Sum = objeto1.Suma((primero), (segundo));
                    txtPantalla.Text = Sum.ToString();
                    break;
                case "-":
                    Rest = objeto2.Resta((primero), (segundo));
                    txtPantalla.Text = Rest.ToString();
                    break;
                case "*":
                    Mul = objeto3.Multiplicar((primero), (segundo));
                    txtPantalla.Text = Mul.ToString();
                    break;
                case "/":
                    Div = objeto4.Division((primero), (segundo));
                    txtPantalla.Text = Div.ToString();
                    break;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length == 1)
                txtPantalla.Text = "";
            else
                txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1);
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "1";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "2";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "3";
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "4";
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "5";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "6";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "7";
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "9";
        }
    }
}