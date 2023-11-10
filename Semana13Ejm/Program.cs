using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana13Ejm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int cont =0;
            int[]arreglo=new int[6];
            do {
                Console.WriteLine("ingresa valor: ");
                string valorTexto=Console.ReadLine();
                valor=int.Parse(valorTexto);
                if(valor != -1)
                if (cont < arreglo.Length)
                {
                    arreglo[cont] = valor;

                }
                else {
                    int[]nuevoArreglo=new int[arreglo.Length+3];
                    for (int i = 0; i < arreglo.Length; i++)
                    {
                        nuevoArreglo[i] = arreglo[i];
                    }
                    nuevoArreglo[cont] = valor;
                    arreglo = nuevoArreglo;
                }  

                cont++;
            } while (valor!=-1);
            for (int i = 0; i < arreglo.Length; i++) {
                Console.Write(arreglo[i]+ " | ");
            }
        Console.ReadKey();
        }
    }
}
