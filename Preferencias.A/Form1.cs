namespace Preferencias.A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //==========================
            //1.-Validar el nombre
            //==========================
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show(
                    "Por favor escribe tu nombre.", "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtnombre.Focus();
            }
            //=========================
            //2.-Ontener las actividades seleccionadas
            //===========================
            List<string> actividades = new List<string>();
            if (chkDeportes.Checked)
            {
                actividades.Add("Deportes");
            }
            if (chkMusica.Checked)
            {
                actividades.Add("Música");
            }
            if (chkArte.Checked)
            {
                actividades.Add("Arte");
            }
            if (chkProgramacion.Checked)
            {
                actividades.Add("Programación");
            }
            if (chkLectura.Checked)
            {
                actividades.Add("Lectura");
            }
            //==================================
            //3.-COMPROBAR QUE SE SELECCION
            //AL MENOS UNA ACTIVIDAD
            //==================================
            if (actividades.Count == 0)
            {
                MessageBox.Show(
                    "Por favor selecciona al menos una actividad.", "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            //=========================
            //2.-Ontener la modalidad seleccionada
            //===========================
            string modalidad = "";
            if (rdPresencial.Checked)
            {
                modalidad = "Presencial";
            }
            else if (rdHibrida.Checked)
            {
                modalidad = "Híbrida";
            }
            else if (rdEnlinea.Checked)
            {
                modalidad = "En línea";
            }
            else
            {
                MessageBox.Show(
                    "Selecciona una modalidad.", "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            //========================
            //5.CREAR EL RESUMEN
            //========================
            string resumen =
                "RESUMEN DE PREFERENCIAS\r\n" +
                "-----------------------\r\n" +
                "Nombre: " + txtnombre.Text + "\r\n" +
                "Actividades: " + string.Join(", ", actividades) + "\r\n" +
                "Modalidad: " + modalidad;
            txtresumen.Text = resumen;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpiar nombre
            txtnombre.Clear(); //txtNombre="";
            //Limpiar actividades
            chkDeportes.Checked = false;
            chkMusica.Checked = false;
            chkArte.Checked = false;
            chkProgramacion.Checked = false;
            chkLectura.Checked = false;
            //Limpiar modalidad
            rdPresencial.Checked = false;
            rdHibrida.Checked = false;
            rdEnlinea.Checked = false;
            //Limpiar resumen
            txtresumen.Clear();
            //Regresamos el cursos al campo nombre
            txtnombre.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
