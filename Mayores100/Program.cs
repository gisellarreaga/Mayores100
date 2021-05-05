using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayores100
{
    class Mayores100
    {
        private int[] vec;

        public void Cargar()
        {
            Console.WriteLine("Cantidad de elementos: ");
            int n = int.Parse(Console.ReadLine());
            vec = new int[n];
            for (int f = 0; f < vec.Length; f++)
            {
                Console.WriteLine("Ingrese el valor del componente: ");
                String linea;
                linea = Console.ReadLine();
                vec[f] = int.Parse(linea);
            }
        }

        public void Imprimir()
        {
            int cant = 0;
            foreach (var valor in vec)
            {
                if (valor > 100)
                {
                    cant++;
                }
            }

            Console.WriteLine("La Cantidad de elementos mayores a 100 son: " + cant);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Mayores100 m = new Mayores100();
            m.Cargar();
            m.Imprimir();
        }
    }
}