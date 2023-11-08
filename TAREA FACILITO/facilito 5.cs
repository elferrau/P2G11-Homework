using system;
using system.Collections.Generic;
using system.Linq;
using system.Text;
using system.Threading.Tasks;

namespace facilito5
{
    class program
    {
        static void Main(string[] args)
        {
            clsEmpleados empleado;
            //empleado = new clsEmpleados();
            empleado.Edad = 25;
            empleado.Nombre = "Marcos Hernandez";
            empleado.SueldoDiario = 12.5m;
            decimal total;
            total = empleado.CalculoSalario(30);
            console.WriteLine("el salario mensual del empleado " + empleado.Nombre);
            console.WriteLine("es: " + total.ToString("C"));
            console.ReadKey();
        }
    }
}