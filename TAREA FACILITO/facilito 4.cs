using system;
using system.Collections.Generic;
using system.Linq;
using system.Text;
using system.Threading.Tasks;

namespace facilito4
{
    class program
    {
        static void Main(string[] args)
        {
            int valor1 = 0, valor2 = 0;
            string cadena;
            console.WriteLine("dame el primer valor: ");
            cadena = console.ReadLine();
            valor1 = convert.ToInt32(cadena);
            console.WriteLine("Dame el segundo valor; ");
            cadena = console.ReadLine();
            valor2 = convert.ToInt32(cadena);
            if (valor1 <= valor2)
            {
                if (valor1 == valor2)
                    console.WriteLine("el valor 1 es mayor al valor 2")
                else
                    console.WriteLine("el valor 2 es mayor al valor 1")     
            }
            else
                console.WriteLine("el valor 1 es mayor que el valor 2")
            console.ReadKey();       
        }
    }
}