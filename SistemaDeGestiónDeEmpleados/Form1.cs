namespace SistemaDeGestiónDeEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            string nombre = txtIngresarNombre.Text;
            string departamento = txtIngresarDepartamento.Text;
            string rol = txtIngresarRol.Text;  
            DateTime fechaRegistro = dtpFechaDeRegistro.Value;
            // la siguiente línea está mala
            nuevoRegistro = new Empleados(nombre, departamento, rol, fechaRegistro);
        }
    }
}
