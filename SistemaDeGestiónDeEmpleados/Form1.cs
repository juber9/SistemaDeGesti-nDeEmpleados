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
            lstMostrarDescripcion.Items.Clear();

            string[] empleados = Empleados.MostrarEmpleados();

            foreach (string empleado in empleados)
            {
                lstMostrarDescripcion.Items.Add(empleado);
            }
        }

        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            string nombre = txtIngresarNombre.Text;
            string departamento = txtIngresarDepartamento.Text;
            string rol = txtIngresarRol.Text;
            DateTime fechaRegistro = dtpFechaDeRegistro.Value;
            Empleados nuevoRegistro = new Empleados(nombre, departamento, rol, fechaRegistro);

            string resultado = Empleados.RegistrarEmpleados(departamento, nombre, rol, fechaRegistro);

            MessageBox.Show(resultado);
        }
    }
}
