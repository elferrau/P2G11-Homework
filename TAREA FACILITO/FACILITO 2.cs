using system;
using system.Collections.Generic;
using system.Linq;
using system.Text;
using system.Threading.Tasks;

namespace facilito2
{
    class program 
    {
        static void Main(string[] args)
        {
            int i = 0;
            decimal x = 0.0m;
            float f = 0.0f;
            double d = 0.0D;
            string cadena = "Hola Mundo";
            bool bandera = false;
            DateTime fecha = DataTime.MinValue;
            console.WriteLine("el valor de i es: {0}, i");
            console.WriteLine("el valor de x es: {0:C}, x");
            console.WriteLine("el valor de f es: {0:F2}, f");
            console.WriteLine("el valor de d es: {0:F2}, d");
            console.WriteLine("el valor de cadena es: " + cadena);
            console.WriteLine("el valor de bandera es: " +bandera.ToString());
            console.ReadKey();
        }
    }
}