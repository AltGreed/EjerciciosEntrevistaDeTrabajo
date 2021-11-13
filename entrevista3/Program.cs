//Realiza una función o método que reciba un arreglo de números y detecte si todos los números en posición consecutiva están separados por la misma magnitud.
using System;

namespace entrevista3
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
                Console.WriteLine("Ingrese el numero "  +  i  + ":");
                numeros[i] = int.Parse(Console.ReadLine());  
                }
            var(numerosComparar, validacion) = mismaDiferencia(numeros);
            foreach(int i in numerosComparar){
                Console.WriteLine(i);
            }
            Console.WriteLine("¿Existe la misma diferencia? ---->  " + validacion);

            
        }

        public static (int[], Boolean) mismaDiferencia(int [] arreglo){
            int comparativa = 0;
            int [] numerosComparar;
            int mismaDiferencia = 0;
            numerosComparar = new int [arreglo.Length-1];
            for(int i= 0;i<arreglo.Length-1;i++){
                comparativa = arreglo[i+1] - arreglo[i];
                if(comparativa < 0){
                    comparativa=comparativa*-1;
                }
                numerosComparar[i] = comparativa;
                comparativa = 0;
            }


            mismaDiferencia = numerosComparar[1];
            for(int i= 0; i<numerosComparar.Length;i++){
                if(mismaDiferencia != numerosComparar[i]){
                    return (numerosComparar, false);
                }

            }

            return (numerosComparar, true);
            
        }
    }
}
