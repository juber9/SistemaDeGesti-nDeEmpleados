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
    public string RegistrarEmpleados(string departamento, string nombre, string rol, DateTime fechaRegistro)
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

    // Método para mostrar los empleados 
    public string MostrarEmpleados()
    {
        if (contadorEmpleados == 0)
        {
            return $"No hay empleados registrados";
        }

        string mostrar = "Empleados registrados: \n";


        for (int i = 0; i < contadorEmpleados; i++) 
        {
            Empleados empleado = registroDeEmpleados[i];   
            mostrar += $"Nombre del empleado: {empleado.nombre}, departamento: {empleado.departamento}, rol: {empleado.rol}, fecha de registro: {empleado.fechaRegistro}";
        }

        return mostrar;
    }
}
