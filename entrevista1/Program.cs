using System;

namespace entrevista1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanio = 0;
            int[] numeros;
            int busqueda = 0;
            int repeticiones = 0;

            Console.WriteLine("Ingrese el tamaño del arreglo");
            tamanio = int.Parse(Console.ReadLine());
            numeros = new int[tamanio];
            for(int i = 0; i<tamanio ;i++){
                Console.WriteLine("Ingrese el numero "  + i  + ":");
                numeros[i] = int.Parse(Console.ReadLine());  
                }
                  
            Console.WriteLine("Ingrese el numero a buscar");
            busqueda = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de repeticiones");
            repeticiones = int.Parse(Console.ReadLine());
            Console.WriteLine(buscar(numeros,busqueda,repeticiones));
        }

        public static Boolean buscar(int[] arreglo, int busqueda,int repeticiones){
            int contador = 0;
            for(int i = 0 ; i< arreglo.Length; i++){
                if(arreglo[i] == busqueda){
                    contador = contador+1;
                    if(contador==repeticiones){
                        return true;
                    }
                }
            }
            return false;
            }
        }
       
    }

