using System;

namespace Uso_Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adivinar un numero");
            int numero;

            try
            {
                numero = int.Parse(Console.ReadLine());

            }
            
              catch(FormatException e)
            {
                Console.WriteLine("No se pudo ejecutar");
                numero = 0;
            }

            catch(OverflowException e)
            {
                Console.WriteLine("No se pudo ejecutar por un tamaño muy grande");
                numero = 0;
            }

            //Para cuando quieras que un error no lo marque hacemos un filtro

            catch (Exception e) when (e.GetType () != typeof(ArgumentOutOfRangeException))
            {
                Console.WriteLine("No se pudo ejecutar por cualquier tipo de problema" );
                numero = 0;
                Console.WriteLine(e.Message);

            }


            int numb,i = 0;
            do
            {
                numb = numero - i;
                i++;
            }
            while (numb != 0);
            Console.WriteLine($"Adivinaste, el numero es: {numero} en {i} interaciones.");
        }       
    }
}
