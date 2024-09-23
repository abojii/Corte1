using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1.Registro
{
    internal class registro
    {
        private string[] nombres = new string[30];
        private string[] apellidos = new string[30];
        private DateTime[] fechasNacimiento = new DateTime[30];
        private string[] ciudades = new string[30];
        private int contador = 0;

        public void AgregarPersona(string nombre, string apellido, DateTime fechaNacimiento, string ciudad)
        {
            if (contador < 30)
            {
                nombres[contador] = nombre;
                apellidos[contador] = apellido;
                fechasNacimiento[contador] = fechaNacimiento;
                ciudades[contador] = ciudad;
                contador++;

            }
            else
            {
                MessageBox.Show("No puede agregar más personas");
            }
        }

        public string[] GetNombres()
        {
            return nombres.Take(contador).ToArray();
        }

        public string[] GetApellidos()
        {

        }
    }
}
