namespace EMPLEADOS;

class Program
{
    static void Main(string[] args)

    {  

        Console.Clear();
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("El siguiente programa calcula la nomina de pagos de varios empleados");
        Console.WriteLine("");
        Console.WriteLine("Eliga una de las siguientes opciones:");
        Console.WriteLine(" 1 = Asalariado");
        Console.WriteLine(" 2 = Empleado x hora");
        Console.WriteLine(" 3 = Empleado x comision");
        Console.WriteLine(" 4 = Empleado Asalariado x comision");
        double respuestaUsuario = double.Parse(Console.ReadLine()); //¿Lo hizo Chat GPT?, porque asi declara las variables.

    }   
}
