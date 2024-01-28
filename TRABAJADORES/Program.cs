namespace TRABAJADORES;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("El siguiente programa calcula la nomina de pagos de varios empleados");
        Console.WriteLine("");
        Console.WriteLine("Ingrese el nombre del empleado por favor");
        Console.Write("Nombre");
        string? nombreEMPLEADO = Console.ReadLine();
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Eliga una de las siguientes opciones de empleado:");
        Console.WriteLine(" 1 = Asalariado");
        Console.WriteLine(" 2 = Empleado x hora");
        Console.WriteLine(" 3 = Empleado x comision");
        Console.WriteLine(" 4 = Empleado Asalariado x comision");

}
