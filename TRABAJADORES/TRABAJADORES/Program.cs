namespace TRABAJADORES;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------------------------------");  //<---esto es lo que se le mostrara al usuario 
        Console.WriteLine("El siguiente programa calcula la nomina de pagos de varios empleados");
        Console.WriteLine("");
        Console.WriteLine("Ingrese el nombre del empleado por favor");
        Console.Write("Nombre");
        string? nombre = Console.ReadLine();
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Eliga una de las siguientes opciones de empleado:");
        Console.WriteLine(" 1 = Asalariado");
        Console.WriteLine(" 2 = Empleado x hora");
        Console.WriteLine(" 3 = Empleado x comision");
        Console.WriteLine(" 4 = Empleado Asalariado x comision");
        int TipoEMPLE = int.Parse(Console.ReadLine());

        Empleado empleado;

        switch (TipoEMPLE)
        {
            case 1:
            empleado = new EmpleadosASALARIADOS();
            Console.Write("Salario semanal fijo: ");
            ((EmpleadosASALARIADOS)empleado).SalarioASALAR = double.Parse(Console.ReadLine());
            break;
            case 2:
            empleado = new EmpleadosXHORAS();
            Console.Write("Sueldo x horas: ");
            ((EmpleadosXHORAS)empleado).SueldoXHORAS = double.Parse(Console.ReadLine());
            Console.Write("Horas ya trabajadas: ");
            ((EmpleadosXHORAS)empleado).HorasTRABAJADAS = double.Parse(Console.ReadLine());
            break;
            case 3:
            empleado = new EmpleadosXCOMISION();
            Console.Write("Ventas Realizadas: ");
            ((EmpleadosXCOMISION)empleado).PorcentajeXCOMISION = double.Parse(Console.ReadLine());
            Console.Write("Porcentaje de la comision: ");
            ((EmpleadosXCOMISION)empleado).PorcentajeXCOMISION = double.Parse(Console.ReadLine());
            break;
            case 4:
            empleado = new EmpleadosASALARIADOSXCOMISION();
            Console.Write("Salario normal fijo: ");
            ((EmpleadosASALARIADOSXCOMISION)empleado).SalarioNORMAL = double.Parse(Console.ReadLine());
            Console.Write("Ventas realizadas: ");
            ((EmpleadosASALARIADOSXCOMISION)empleado).VentasEmpleados = double.Parse(Console.ReadLine());
            Console.Write("Porcentajes de la comision: ");
            ((EmpleadosASALARIADOSXCOMISION)empleado).PorcentajeXCOMISION = double.Parse(Console.ReadLine());
            break;
            default:
            Console.WriteLine("Esa opcion no es valida :c");
            return;
        }
        empleado.nombreEMPLEADO = nombre;

        Console.WriteLine($"El salario del {empleado.nombreEMPLEADO} es: {empleado.CALCULARPAGO()}"); //<----- esto se le mostrara al usuario
        Console.WriteLine("Tenga un buen dia :D");

}
