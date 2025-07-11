using ClassLibrary1.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace capapresentacion
{
    public partial class Form1 : Form
    {
        Empleado Empleado = new Empleado();
        Gerencial gerencia = Gerencial.Gerencia();
        Operativo Operativo = new Operativo();
        Administactivo Administrativo = new Administactivo();
        Nomina nomina = new Nomina();


        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Administactivo");
            comboBox1.Items.Add("Gerencial");
            comboBox1.Items.Add("Operativo");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Empleado.Nombre = nombrebox.Text;
            Empleado.Cedula = cedulabox.Text;

            switch (comboBox1.SelectedItem)
            {
                case "Administactivo":
                    
                    Empleado.Departamento = Administrativo.DepartNombre;
                    break;

                case "Gerencial":

                    
                    Empleado.Departamento = gerencia.DepartNombre;
                    break;
                case "Operativo":
                    
                    Empleado.Departamento = Operativo.DepartNombre; 
                    break;

                default:
                    string error = "erorr";
                    break;


            }

            Empleado.GeneraCodigo();

            listBox1.Items.Add(Empleado.Departamento);
            
           listBox1.Items.Add(Empleado.InfoEmpleado());

            nomina.Totalhoras = 0;

            Empleado.NumerosCodigos = Empleado.NumerosCodigos + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nomina.Ihora = Convert.ToInt32(ihorabox.Text);
            nomina.Fhora = Convert.ToInt32(fhorabox.Text);
           
            listBox1.Items.Add($"Sueldo del Empleado {Empleado.Nombre}: {nomina.CalculoSueldo(Empleado.Departamento)}");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            nombrebox.Clear();
            cedulabox.Clear();
            ihorabox.Clear();
            fhorabox.Clear();
            nombrebox.Focus();
            cedulabox.Focus();
            ihorabox.Focus();
            fhorabox.Focus();
        }
    }
}
