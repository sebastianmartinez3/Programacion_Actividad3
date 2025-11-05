using System.Security.Cryptography;

namespace Actividad3;

class Program
{
    static void Main(string[] args)
    {
        string? cmd;
        Console.WriteLine("Bienvenido al programa de ejercicios de C#. ACTIVIDAD 3");
        Console.WriteLine("Nombre completo del usuario1 grupo");
        Console.WriteLine("Nombre completo del usuario2 grupo");
        do
        {
            cmd = Console.ReadLine();
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
                        Console.WriteLine("Comando no permitido.\nEscriba un nÚmero del 0 al 10, para ejecutar el ejercicio.\nEscriba EXIT para salir.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Comando no permitido.\nEscriba un nÚmero del 0 al 10, para ejecutar el ejercicio.\nEscriba EXIT para salir.");
            }
        } while (cmd?.ToLower() != "exit");
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