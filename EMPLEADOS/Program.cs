using System.Reflection.Emit;

namespace EMPLEADOS;

class Program
{
    private double Asala;
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
        double respuesta = double.Parse(Console.ReadLine());

            EMPLEADO obj = new EMPLEADO();
        if(respuesta == 1)
        {
            Console.WriteLine("Ingrese el salario fijo del trabajador");
            double Asala = double.Parse(Console.ReadLine());
            
            double resfinal =obj.SUELDOASALARIADOS(Asala);
            Console.WriteLine("es este "+resfinal);
        }
        if (respuesta== 2)
        {
            Console.WriteLine("Ingrese el salario x hora del trabajador");
            double EmpleXHora = double.Parse(Console.ReadLine());
            double resfinal2 = obj.SUELDOSXHORAS(EmpleXHora);

            Console.WriteLine("es este otro de: "+resfinal2);
            
        }


        

    }   
}
