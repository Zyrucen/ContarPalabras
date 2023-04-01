using System;

namespace ContarPalabras
{
    internal class Program

    /*  Este es un programa que pide al usuario una cadena de texto y
     *  le muestra cuántas palabras hay en la cadena.
     */
    {
        static void Main(string[] args)
        {

            string texto;

            Console.WriteLine("Este programa está diseñado para contar las palabras.\n" +
                "Por favor, escribe el texto que quieras:");

            texto = Console.ReadLine();

            string [] palabras = texto.Split(' ');

            Console.WriteLine(palabras.Length);

        }
    }
}
