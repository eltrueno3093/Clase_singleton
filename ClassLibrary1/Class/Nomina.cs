using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ClassLibrary1.Class
{
     public class Nomina
    {
        #region Constructor
        #endregion;
        #region Atributos
        private int ihora;
        private int fhora;
        private int diferencia;
        private double sueldo;
        private int totalhoras;
        #endregion;
        #region Propiedades
        public int Ihora
        {
            get { return ihora; }
            set { ihora = value; }
        }
        public int Fhora
        {
            get { return fhora; }
            set { fhora = value; }
        }

        public int Diferencia
        {
            get { return diferencia; }
            set { diferencia = value; }
        }
        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }
        public int Totalhoras
        {
            get { return totalhoras; }
            set { totalhoras = value; }
        }
        #endregion;
        #region Metodos

       
        public double CalculoSueldo(string Departamento)
        {
            for (Ihora=Ihora; Ihora < Fhora; Ihora++)
            {
                Totalhoras ++;
            }
            switch (Departamento)
            {
                case "Administactivo":
                    Sueldo = 50;
                    break;
                case "Gerencial":
                    Sueldo = 75;
                    break;
                case "Operativo":
                    Sueldo = 100;
                    break;
                default:
                    throw new ArgumentException("Departamento no reconocido");
                    break;
            }

            return Sueldo = Sueldo * Totalhoras;
        }


        #endregion;


    }
}
