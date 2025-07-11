using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Class
{
    public sealed class Gerencial:Departamentos
    {
        #region Constructor
        private Gerencial() {
            DepartNombre = "Gerencial";
        }
        #endregion;
        #region Atributos
        private static Gerencial gerencia;
        #endregion;
        #region Propiedades
        #endregion;
        #region Metodos
        public static Gerencial Gerencia()
        {
            if (gerencia == null)
            {
                gerencia = new Gerencial();
                
            }

            return gerencia;
        }
        #endregion;

    }
}
