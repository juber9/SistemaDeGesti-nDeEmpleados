public class Empleados
{
    private string departamento;
    private string nombre;
    private string rol;
    private DateTime fechaRegistro;
    private static Empleados[] registroDeEmpleados = new Empleados[5];
    private static int contadorEmpleados = 0;

    public Empleados(string departamento, string nombre, string rol, DateTime fechaRegistro)
    {
        this.departamento = departamento;
        this.nombre = nombre;
        this.rol = rol;
        this.fechaRegistro = fechaRegistro;
    }

    private class Registro
    {
        public string Departamento { get; set; }
        public string Nombre { get; set; }
        public string rol { get; set; }
    }

    // Método para registrar empleados 
    public static string RegistrarEmpleados(string departamento, string nombre, string rol, DateTime fechaRegistro)
    {
        try
        {
            if (contadorEmpleados == registroDeEmpleados.Length)
            {
                return $"El arreglo está lleno";
            }

            Empleados nuevoRegistro = new Empleados(departamento, nombre, rol, fechaRegistro);
            registroDeEmpleados[contadorEmpleados] = nuevoRegistro;
            contadorEmpleados++;

            return $"Registro de empleados exitoso: {nombre}, {departamento}, {rol}, {fechaRegistro}";
        }
        catch (Exception ex)
        {
            return $"Error al registrar empleado: {ex.Message}";
        }
        
    }

    // Método para mostrar los empleados 
    public static string[] MostrarEmpleados()
    {
        if (contadorEmpleados == 0)
        {
            return new string[] { "No hay empleados registrados." };
        }

        // Creamos un arreglo de cadenas para almacenar los detalles de los empleados
        string[] listaEmpleados = new string[contadorEmpleados];

        // Rellenamos el arreglo con la información de cada empleado
        for (int i = 0; i < contadorEmpleados; i++)
        {
            Empleados empleado = registroDeEmpleados[i];
            listaEmpleados[i] = $"Nombre del empleado: {empleado.nombre}, Departamento: {empleado.departamento}, Rol: {empleado.rol}, Fecha de registro: {empleado.fechaRegistro.ToShortDateString()}";
        }

        return listaEmpleados;
    }

}