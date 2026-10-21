Console.WriteLine("-----MENU-----\n 1 = Consultar saldo \n 2 = Retirar \n 3 = Depositar \n 4 = Salir");
string eleccion = Console.ReadLine() ?? "";

switch (eleccion)
{
    case "1":
        Console.WriteLine("Tu saldo actual es de $42.000");
    break;

    case "2":
        Console.WriteLine("Has retirado $42.000");
    break;

    case "3":
        Console.WriteLine("Has depositado $10.000");
    break;

    case "4":
        Console.WriteLine("Has finalizado el programa correctamente");
    break;

    default:
        Console.WriteLine("Opcion no valida");
    break;
}

