decimal[] numbers = new decimal[2];
decimal select = 0;
decimal result = 0;
decimal calificacion = 0;
decimal others = 1;
decimal newNub = 0;
decimal[] othersNumbers;


while (select != 6)
{
    try
    {
        Console.WriteLine("BIENVENIDO A TU CALCULADORA");
        Console.WriteLine("Por favor selecciona tu operacion Matemática");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Dividir");
        Console.WriteLine("4. Multiplicar");
        Console.WriteLine("5. Calificar estudiante");
        Console.WriteLine("6. Salir");

        Console.WriteLine("Selecciona una operación");
        select = int.Parse(Console.ReadLine());

        if (select >= 1 && select <= 4)
        {
            numbers = new decimal[2];

            Console.WriteLine("Ingresa tu primer número");
            numbers[0] = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu segundo número");
            numbers[1] = decimal.Parse(Console.ReadLine());

            others = 1;

            while (others == 1)
            {
                Console.WriteLine("¿Quieres agregar otro número?");
                Console.WriteLine("si o no");

                string ask = Console.ReadLine();

                if (ask == "si")
                {
                    Console.WriteLine("Ingresa otro número");
                    newNub = decimal.Parse(Console.ReadLine());

                    othersNumbers = new decimal[numbers.Length + 1];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        othersNumbers[i] = numbers[i];
                    }

                    othersNumbers[numbers.Length] = newNub;

                    numbers = othersNumbers;
                }
                else if (ask == "no")
                {
                    others = 0;
                }
                else
                {
                    Console.WriteLine("Debes escribir si o no");
                }
            }
        }

        switch (select)
        {
            case 1:

                result = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    result = result + numbers[i];
                }

                Console.WriteLine($"Resultado: {result}");

                break;


            case 2:

                result = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    result = result - numbers[i];
                }

                Console.WriteLine($"Resultado: {result}");

                break;


            case 3:

                try
                {
                    result = numbers[0];

                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (numbers[i] == 0)
                        {
                            throw new DivideByZeroException();
                        }

                        result = result / numbers[i];
                    }

                    Console.WriteLine($"Resultado: {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: No se puede dividir entre 0");
                }

                break;


            case 4:
                try
                { 
                result = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    result = result * numbers[i];
                }

                Console.WriteLine($"Resultado: {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: no se puede dividir entre 0");
                }

                break;

            case 5:

                try
                {
                    Console.WriteLine("Ingrese la nota final del estudiante");
                    calificacion = decimal.Parse(Console.ReadLine());

                    if (calificacion < 0 || calificacion > 100)
                    {
                        Console.WriteLine("Error: La nota debe estar entre 0 al 100");
                    }
                    else if (calificacion >= 70)
                    {
                        Console.WriteLine("Estudiante: Aprobado");
                    }
                    else
                    {
                        Console.WriteLine("Estudiante: Reprobado");
                    }
                }
                catch
                {
                    Console.WriteLine("Error: La nota final debe ser un número");
                }

                break;


            case 6:

                Console.WriteLine("Cerrando el programa");

                break;


            default:

                Console.WriteLine("Opción no válida");

                break;
        }
    }
    catch
    {
        Console.WriteLine("Error: Debes ingresar un número válido");
    }
}