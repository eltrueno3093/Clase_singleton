using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Class
{
    public class Empleado
    {
        #region Constructor
        public Empleado() 
        {
            /*Cedula = cedula;
            Nombre = nombre;
            Departamento = departamento;*/
            NumerosCodigos = 1000;
        }
        #endregion;
        #region Atributos
        private string cedula;
        private string codigo;
        private string nombre;
        private string departamento;
        private int horas_trabajadas;
        private int salario;
        private int numerosCodigos;
        #endregion;
        #region Propiedades
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        public int Horas_Trabajadas
        {
            get { return horas_trabajadas; }
            set { horas_trabajadas = value; }
        }
        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public int NumerosCodigos
        {
            get { return numerosCodigos; }
            set { numerosCodigos = value; }
        }
        #endregion;
        #region Metodos
        public string InfoEmpleado()
        {
            return $"Nombre Empleado: {Nombre}, Cedula: {Cedula}, Codigo: {Codigo}, Departamento: {Departamento}";
        }

        public void GeneraCodigo()
        {
            int letrasDepartamento = 3;
            Codigo = Departamento.Substring(0, letrasDepartamento) + Convert.ToString(NumerosCodigos);
           
            

        }
        #endregion;
    }
}
