using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad4OrtizProfumieriUnzaga
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2.Crear una función que pida el peso de 5 personas guardando en un arreglo los valores,
            //luego recorrer el arreglo y mostrar el mas pesado y el mas liviano.
            //PedirPeso();

            //3.Hacer una función que ingresen las notas de los alumnos y los guarde en un ArrayList.
            //Luego calcular y mostrar el promedio, nota máxima y mínima.
            // CalcularNotasAlumnos();
            //4.Hacer una función que actúe como un diccionario en donde el usuario ingresa una palabra y
            //nos devuelve la definición usando la colección Hashtable(inicializar con al menos 5 palabras).
            Hashtable diccionario = new Hashtable();
            diccionario["csharp"] = "Lenguaje de programación desarrollado por Microsoft.";
            diccionario["variable"] = "Espacio de memoria que guarda un valor.";
            diccionario["funcion"] = "Bloque de código que realiza una tarea específica.";
            diccionario["compilador"] = "Programa que traduce código fuente a lenguaje máquina.";
            diccionario["objeto"] = "Instancia de una clase en programación orientada a objetos.";
            BuscarDefinicion(diccionario);
            //5.Hacer un función que le solicite al usuario 4 números y luego los muestre en orden descendente.
            //descendente();
            Console.ReadKey();
        }


        private static void PedirPeso()
        {
            int cantidad = 5;
            double maxima = 0;
            double minima = 200;
            double[] pesoPersonas = new double[cantidad];
            for (int i = 0; i < pesoPersonas.Length; i++)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out double peso))
                {
                    pesoPersonas[i] = peso;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Ingrese un número válido.");
                }
            }
            for (int i = 0; i < pesoPersonas.Length; i++)
            {
                if (pesoPersonas[i] < minima)
                    minima = pesoPersonas[i];
            }
            for (int i = 0; i < pesoPersonas.Length; i++)
            {
                if (pesoPersonas[i] > minima)
                    maxima = pesoPersonas[i];
            }
            Console.WriteLine("minima " + minima + "kg");
            Console.WriteLine("maxima " + maxima + "kg");

        }
        private static void CalcularNotasAlumnos()
        {
            int cantidad = 0;
            ArrayList notasAlumnos = new ArrayList();

            Console.Write("Ingrese la cantidad de alumnos: ");
            string input = Console.ReadLine();
            cantidad = Convert.ToInt32(input);

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("ingrese la nota del alumno " + i);
                string inputNotas = Console.ReadLine();
                notasAlumnos.Add(Convert.ToDouble(inputNotas));
            }

            //for (int i = 0; i < notasAlumnos.Count; i++)
            //{
            //    Console.WriteLine(notasAlumnos[i]);
            //}
        }
        public static void descendente()
        {
            int[] numeros = new int[4];

            Console.WriteLine("INGRESE 4 NUMEROS");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);
            Array.Reverse(numeros);
            Console.WriteLine("Números en orden descendente:");
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void BuscarDefinicion(Hashtable diccionario)
        {
            Console.Write("Ingrese una palabra para buscar su definición: ");
            string palabra = Console.ReadLine().ToLower();

            if (diccionario.ContainsKey(palabra))
            {
                Console.WriteLine($"Definición de '{palabra}': {diccionario[palabra]}");
            }
            else
            {
                Console.WriteLine($"La palabra '{palabra}' no se encuentra en el diccionario.");
            }
        }
    }
}
