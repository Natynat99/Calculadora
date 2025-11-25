using System;

class Calculadora
{
    static void Main()
    {
        double num1, num2;

        while (true)
        {
            Console.Write("Introduce el primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 >= 0 && num2 >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Alguno de los números no es positivo. Vuelve a introducir ambos números.\n");
            }
        }

        int opcion; 

        do
        {
            Console.WriteLine("\n--- MENÚ CALCULADORA ---");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Resultado de la suma: {num1 + num2}");
                    break;

                case 2:
                    Console.WriteLine($"Resultado de la resta: {num1 - num2}");
                    break;

                case 3:
                    Console.WriteLine($"Resultado de la multiplicación: {num1 * num2}");
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: no se puede dividir entre 0.");
                    }
                    else
                    {
                        Console.WriteLine($"Resultado de la división: {num1 / num2}");
                    }
                    break;

                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }

        } while (opcion != 5);
    }
}


