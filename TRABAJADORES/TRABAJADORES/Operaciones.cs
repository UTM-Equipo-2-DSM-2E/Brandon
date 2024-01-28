using System.Dynamic;

namespace TRABAJADORES;
    public abstract class Empleado    //<-------- este es la Clase base o clase padre segun yo
{
    public string nombreEMPLEADO {get; set;}
    public string ApellEMPLEADO {get; set;}
    public int TipoEMPLE {get; set;}
    public abstract double CALCULARPAGO();
}
    public class EmpleadosASALARIADOS : Empleado  //<-----este es clase heredada o clase hijo para los empleados asalariados
    {
    public double SalarioASALAR {get; set;}
    public override double CALCULARPAGO()
    {
        return SalarioASALAR;
    }

    }
    public class EmpleadosXHORAS : Empleado  //<----este es clase heredada o clase hijo para los empleados xhoras
    {
        public double SueldoXHORAS {get; set;}
        public double HorasTRABAJADAS {get; set;}
        public override double CALCULARPAGO()
        {
            if (HorasTRABAJADAS <= 40)
            {
                return SueldoXHORAS * HorasTRABAJADAS;
            }
            else
            {
                double SalarioSFIJO = SueldoXHORAS * 40;
                double SalarioSEXTRA = (HorasTRABAJADAS - 40) * (SueldoXHORAS * 1.5);
                return SalarioSFIJO + SalarioSEXTRA;
            }
        }
    }
    public class EmpleadosXCOMISION : Empleado  //<--------este es clase heredada o clase hijo para los empleados xcomision
    {
        public double VentasEMPLEADOS {get; set;}
        public double PorcentajeXCOMISION {get; set;}
        public override double CALCULARPAGO()
        {
            return VentasEMPLEADOS * (PorcentajeXCOMISION / 100);
        }
    }
    public class EmpleadosASALARIADOSXCOMISION : Empleado  //<-------este es clase heredada o clase hijo para los empleados asalriados que tienen comision
    {
            public double SalarioNORMAL {get; set;}
            public override double CALCULARPAGO()
            {
                double SalariosCONCOMISION = CALCULARPAGO();
                return SalarioNORMAL + SalariosCONCOMISION;
            }
    }
    



