namespace EMPLEADOS;



abstract class EMPLEADO //CLASE PADRE EMPLEADO
{
    protected double tipoPago;
    protected double Asala;
    protected double EmpleXHora; 
    protected double EmpleXComision;
    protected double AsalaXComision;
    protected double respuestaUsuario;

    public virtual double SueldoAsalario
    {
        get;
        set;
    }
    public virtual double SueldoXHora
    {
        get;
        set;
    }
    public virtual double SueldoEmpleXComi
    {
        get;
        set;
    }
    public virtual double SueldoAsalariXComi
    {
        get;
        set;
    }
    public virtual double respUesuario
    {
        get;
        set;
    }//<----------------------- Aqui finaliza la clase padre y abajo comienzan las clases hijo o clases heredadas...

    class EmpleadosAsalariados : EMPLEADO
    {
        public override double SueldoAsalario { get => base.SueldoAsalario; set => base.SueldoAsalario = value; }
    }
    class Empleadosxhoras : EMPLEADO
    {
        public override double SueldoXHora { get => base.SueldoXHora; set => base.SueldoXHora = value; }
    }
    class Empleadosxcomision : EMPLEADO
    {
        public override double SueldoEmpleXComi { get => base.SueldoEmpleXComi; set => base.SueldoEmpleXComi = value; }
    }
    class Empleadosasalariadosxcomision : EMPLEADO
    {
        public override double SueldoAsalariXComi { get => base.SueldoAsalariXComi; set => base.SueldoAsalariXComi = value; }
    }
    public class opciones : EMPLEADO
    {
        public override double respUesuario { get => base.respUesuario; set => base.respUesuario = value; }
    }
    
    public class Operaciones 
    {
        EmpleadosAsalariados SueldoASALARIOS = new EmpleadosAsalariados();
        Empleadosxhoras SueldoXHORAS = new Empleadosxhoras();
        Empleadosxcomision SueldoXCOMISION = new Empleadosxcomision();
        Empleadosasalariadosxcomision SueldoASALARXCOMISION = new Empleadosasalariadosxcomision();

    }

    
   

    
}