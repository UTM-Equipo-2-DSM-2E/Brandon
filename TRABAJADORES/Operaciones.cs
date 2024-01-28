namespace TRABAJADORES;

public class Empleado    //<-------- este es la Clase base o clase padre segun yo
{
    private string NombreEMPLE {get; set;}
    private string ApellidoEMPLE {get; set;}
    private string TipoEMPLE {get; set;}

    public virtual double CALCULARPAGO()
    {
        return 0;
    }
    class EmpleadosASALARIADOS : Empleado
    {
        public double Salarios {get; set;}
        public override double CALCULARPAGO()
        {
            return Salarios;
        }
    }
    class EmpleadosXHORAS : Empleado
    {
        public double SueldosXHORAS {get; set;}
        public double HorasTRABAJADAS {get; set;}
        public override double CALCULARPAGO()
        {
            if (HorasTRABAJADAS <= 40)
            {
                return SueldosXHORAS * HorasTRABAJADAS;
                
            }
            else
            {
                return (SueldosXHORAS * 40) + (HorasTRABAJADAS - 40) * (SueldosXHORAS * 1.5);
            }
        }

    }
    class EmpleadosXCOMISIONI : Empleado
    {
        public double VentasdeEmple {get; set;}
        public double Porcentajedelacomision {get; set;}
        public override double CALCULARPAGO()
        {
            return base.CALCULARPAGO() + VentasdeEmple * (Porcentajedelacomision / 100) * 1;
        }

    }


}