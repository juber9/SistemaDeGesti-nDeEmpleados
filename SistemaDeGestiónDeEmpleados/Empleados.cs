class Empleados
{
    private string departamento;
    private string nombre;
    private string rol;
    private DateTime fechaRegistro;

    public Empleados(string departamento, string nombre, string rol, DateTime fechaRegistro)
    {
        this.departamento = departamento;
        this.nombre = nombre; 
        this.rol = rol;
        this.fechaRegistro = fechaRegistro;
    }

    //Clase para registrar los empleados 
    private class Registro
    {
        public string Departamento { get; set; }
        public string Nombre { get; set; }
        public string rol { get; set; }
    }
}
