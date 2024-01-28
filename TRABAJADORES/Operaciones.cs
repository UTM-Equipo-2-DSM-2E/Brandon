namespace TRABAJADORES;

public class Empleado    //<-------- este es la Clase base o clase padre segun yo
{
    private string NombreEMPLE {get; set;} //El get y set deben de ir en un metodo de acceso
    private string ApellidoEMPLE {get; set;}
    private string TipoEMPLE {get; set;}

    public virtual double CALCULARPAGO() //¿Para que usaste virtual si es una clase publica?
    {
        return 0;
    }
    class EmpleadosASALARIADOS : Empleado //¿Porque esta dentro de la clase padre?
    {
        public double Salarios {get; set;} //Esto es un metodo de acceso, ¿Pero donde declaraste la variable?
        public override double CALCULARPAGO()
        {
            return Salarios;
        }
    }
    class EmpleadosXHORAS : Empleado //Clase hijo, ¿Porque esta dentro de la clase padre?
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
    class EmpleadosXCOMISIONI : Empleado //esta dentro de la clase padre
    {
        public double VentasdeEmple {get; set;} //Donde declaraste la variable privada?
        public double Porcentajedelacomision {get; set;} //Donde declaraste la variable privada?, no esta en la clase padre.
        public override double CALCULARPAGO()
        {
            return base.CALCULARPAGO() + VentasdeEmple * (Porcentajedelacomision / 100) * 1;
        }

    }


}
