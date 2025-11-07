namespace Actividad3;

class Program
{
    static void Main(string[] args)
    {
        string? cmd;
        Console.WriteLine("Bienvenido al programa de ejercicios de C#. ACTIVIDAD 3");
        Console.WriteLine("Nombre completo del usuario1 grupo");
        Console.WriteLine("Nombre completo del usuario2 grupo");
        Menu();
        do
        {
            cmd = Console.ReadLine();
            switch (cmd?.ToLower())
            {
                case "exit":
                    break;
                case "menu":
                    Menu();
                    break;
                default:
                    if (int.TryParse(cmd, out int num))
                    {
                        switch (num)
                        {
                            case 0:
                                Ejercicio0();
                                break;
                            case 1:
                                Ejercicio1();
                                break;
                            case 2:
                                Ejercicio2();
                                break;
                            case 3:
                                Ejercicio3();
                                break;
                            case 4:
                                Ejercicio4();
                                break;
                            case 5:
                                Ejercicio5();
                                break;
                            case 6:
                                Ejercicio6();
                                break;
                            case 7:
                                Ejercicio7();
                                break;
                            case 8:
                                Ejercicio8();
                                break;
                            case 9:
                                Ejercicio9();
                                break;
                            case 10:
                                Ejercicio10();
                                break;
                            default:
                                Console.WriteLine(
                                    "Comando no permitido.\nEscriba un nÚmero del 0 al 10, para ejecutar el ejercicio.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Comando no permitido.");
                        Console.WriteLine("Escriba un nÚmero del 0 al 10 para ejecutar el ejercicio.");
                        Console.WriteLine("Escriba EXIT para salir.");
                        Console.WriteLine("Escriba MENU para mostar el menu principal.");
                    }

                    break;
            }
        } while (cmd?.ToLower() != "exit");
        Console.WriteLine("Gracias por usar el programa.");
    }

    static void Menu()
    {
        Console.WriteLine("======== MENU PRINCIPAL ========");
        Console.WriteLine("0. Hola Mundo!");
        Console.WriteLine("1. Ejercicio 1");
        Console.WriteLine("2. Ejercicio 2");
        Console.WriteLine("3. Ejercicio 3");
        Console.WriteLine("4. Ejercicio 4");
        Console.WriteLine("5. Ejercicio 5");
        Console.WriteLine("6. Ejercicio 6");
        Console.WriteLine("7. Ejercicio 7");
        Console.WriteLine("8. Ejercicio 8");
        Console.WriteLine("9. Ejercicio 9");
        Console.WriteLine("10. Ejercicio 10");
        Console.WriteLine("Escriba EXIT para salir.");
        Console.WriteLine("Escriba MENU para mostrar el menu principal.");
        Console.WriteLine("================================");
    }

    static void Ejercicio0()
    {
        Console.WriteLine("Hola Mundo!");
    }

    static void Ejercicio1()
    {
        
    }

    static void Ejercicio2()
    {
        
    }
    
    static void Ejercicio3()
    {
        
    }

    static void Ejercicio4()
    {
        
    }
    
    static void Ejercicio5()
    {
        
    }

    static void Ejercicio6()
    {
        
    }

    static void Ejercicio7()
    {
        
    }

    static void Ejercicio8()
    {
        
    }

    static void Ejercicio9()
    {
        
    }

    static void Ejercicio10()
    {
        
    }
}