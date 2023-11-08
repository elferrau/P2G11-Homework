using system;
using system.Collections.Generic;
using system.Linq;
using system.Text;
using system.Threading.Tasks;

namespace facilito3
{
    class program
    {
        static void Main(string[] args)
        {
            int i = 10;
            decimal x = 12.2m;
            bool bandera = true;
            string cadena = "12344";
            DateTime fecha = DateTime.MinValue;
            i = convert.ToInt32(cadena);
            console.WriteLine("el valor de i es: {0}", i);
            console.WriteLine("el valor de x es: {0:C}", x);
            console.WriteLine("el valor de bandera es: " + bandera.ToString());
            console.WriteLine("el valor de cadena es: " + cadena);
            console.WriteLine("el valor de fecha es: " + fecha.ToShortDateString());
            console.ReadKey();
        }
    }
}