using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColas.Logic
{
    internal class Colas
    {
        private int[] num;
        private int inicio;
        private int re;

        public Colas(int dim)
        {
            num = new int[dim];
            inicio = -1;
            re = -1;
        }

        public void Entrar(int numero)
        {
            if (re == num.Length - 1)
            {
                throw new InvalidOperationException("La cola esta llena");
            }
            num[++re] = numero;
            if (inicio == -1)
            {
                inicio = 0;
            }
        }

        public int Salir()
        {
            if (inicio == -1)
            {
                throw new InvalidOperationException("La cola esta vacia");
            }
            int numero = num[inicio];
            if (inicio == re)
            {
                inicio = re = -1;
            }
            else
            {
                inicio++;
            }
            return numero;
        }
    }
}
