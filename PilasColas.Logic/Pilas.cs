using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColas.Logic
{
    public class Pilas
    {
        private int[] num;
        private int inicio;

        public Pilas(int dim)
        {
            num = new int[dim];
            inicio = -1;
        }

        public void Entrada(int item)
        {
            if (inicio == num.Length - 1)
            {
                throw new InvalidOperationException("La pila esta llena");
            }
            num[++inicio] = item;
        }

        public int Salida()
        {
            if (inicio == -1)
            {
                throw new InvalidOperationException("La pila esta vacia");
            }
            return num[inicio--];
        }
    }
}
