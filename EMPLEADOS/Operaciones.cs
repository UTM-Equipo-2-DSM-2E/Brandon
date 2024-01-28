namespace EMPLEADOS;


 public class EMPLEADO //CLASE PADRE EMPLEADO
{
    public class metodos
    {}
    
    private double tipoPago;
    private double Asala;
    private double EmpleXHora; 
    private double EmpleXComision;
    private double AsalaXComision;
    

    public double Asalariados
    {
        get{return Asala;}
        set{Asala = value;}
    }
    public double EmpleadosxHORAS
    {
        get{return EmpleXHora;}
        set{EmpleXHora =  value;}
    }
    public double EmpleadosXCOMISION
    {
        get{return EmpleXComision;}
        set{EmpleXComision = value;}
    }
    public double EmpleadosAsalariadosXCOMISION
    {
        get{return AsalaXComision;}
        set{AsalaXComision = value;}
    }

    public double SUELDOASALARIADOS(double salario)
    {
        return Asala;
    }
    public double SUELDOSXHORAS(double EmpleXHora)
    {
        return EmpleadosxHORAS;

    }
    
    

 
    

    
   

    
}