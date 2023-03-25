int num1 = 0;
int num2 = 0;
int opcion = 0;
bool prueba = false;

do
{
    Console.WriteLine("Qué deseas hacer?");
    Console.WriteLine("1 - Suma");
    Console.WriteLine("2 - Resta");
    Console.WriteLine("3 - Division");
    Console.WriteLine("4 - Multiplicación");
    Console.WriteLine("5 - Salir");

    while (opcion <= 0 || opcion > 5)
    {
        Console.WriteLine("Digite alguna de las opciones: ");

        try
        {
            opcion = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Opcion incorrecta");
        }
    }

    switch (opcion)
    {
        case 1:
            {
                Console.WriteLine("Digite el numero 1: ");

                while (prueba == false)
                {
                    try
                    {
                        num1 = int.Parse(Console.ReadLine());
                        prueba = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Digite solo un numero entero: ");
                    }
                }

                Console.WriteLine("Digite el numero 2: ");

                while (prueba == true)
                {
                    try
                    {
                        num2 = int.Parse(Console.ReadLine());
                        prueba = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Digite solo un numero entero: ");
                    }
                }

                Console.WriteLine("La suma de esos numeros es: " /*+ suma(int num1, int num2)*/);
                opcion = 0;

                break;
            }
        case 2:
            {
                Console.WriteLine("Digite el numero 1: ");

                while (prueba == false)
                {
                    try
                    {
                        num1 = int.Parse(Console.ReadLine());
                        prueba = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Digite solo un numero entero: ");
                    }
                }

                Console.WriteLine("Digite el numero 2: ");

                while (prueba == true)
                {
                    try
                    {
                        num2 = int.Parse(Console.ReadLine());
                        prueba = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Digite solo un numero entero: ");
                    }
                }

                Console.WriteLine("La resta de esos numeros es: " /*+ resta(int num1, int num2)*/);
                opcion = 0;

                break;
            }
        case 3:
            {
                Console.WriteLine("Digite el numero 1: ");

                while (prueba == false)
                {
                    try
                    {
                        num1 = int.Parse(Console.ReadLine());
                        prueba = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Digite solo un numero entero: ");
                    }
                }

                Console.WriteLine("Digite el numero 2: ");

                while (prueba == true)
                {
                    try
                    {
                        num2 = int.Parse(Console.ReadLine());
                        prueba = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Digite solo un numero entero: ");
                    }
                }

                Console.WriteLine("La division de esos numeros es: " /*+ division(int num1, int num2)*/);
                opcion = 0;

                break;
            }
        case 4:
            {
                Console.WriteLine("Digite el numero 1: ");

                while (prueba == false)
                {
                    try
                    {
                        num1 = int.Parse(Console.ReadLine());
                        prueba = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Digite solo un numero entero: ");
                    }
                }

                Console.WriteLine("Digite el numero 2: ");

                while (prueba == true)
                {
                    try
                    {
                        num2 = int.Parse(Console.ReadLine());
                        prueba = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Digite solo un numero entero: ");
                    }
                }

                Console.WriteLine("La multiplicacion de esos numeros es: " /*+ multiplicacion(int num1, int num2)*/);
                opcion = 0;

                break;
            }
        default:
            {
                break;
            }
    }

}while(opcion != 5);

//||