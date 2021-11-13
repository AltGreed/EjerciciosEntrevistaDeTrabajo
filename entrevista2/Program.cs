//Realiza una función o método que reciba un arreglo y regresa la mayor diferencia entre cualquier par de números, independientemente de su posición.
using System;
using System.Collections.Generic;

namespace entrevista2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros;
            int tamanio = 0;
            Console.WriteLine("Ingrese el tamaño del arreglo");
            tamanio = int.Parse(Console.ReadLine());
            numeros = new int[tamanio];
            for(int i = 0; i<tamanio ;i++){
                Console.WriteLine("Ingrese el numero "  + i  + ":");
                numeros[i] = int.Parse(Console.ReadLine());  
                }

            var (diferencias, mayorValor) = mayorDiferencia(numeros);
            foreach(int i in diferencias)
            {
                Console.WriteLine(i);
            }
                Console.WriteLine("La mayor diferencia es: " + mayorValor + ".");
        }
        public static (int[,] , int) mayorDiferencia(int [] arreglo){
            int tamanioArray = arreglo.Length;
            int [,] diferencias;
            diferencias = new int[arreglo.Length , arreglo.Length];

            for(int i=0;i<tamanioArray;i++){
                for(int j=0 ;j < tamanioArray; j++){
                    diferencias[j,i] = (arreglo[i]-arreglo[j]);
                }
            }
            int mayorValor = 0;
            for(int i=0;i<tamanioArray;i++){
                for(int j=0 ;j < tamanioArray; j++){
                    if(mayorValor<diferencias[i,j]){
                        mayorValor = diferencias[i,j];
                    }
                }
            }
        return (diferencias, mayorValor);
        }       
    }
}
