string estado = Console.ReadLine() ?? "";

switch (estado)
{
    case "Rojo":
        Console.WriteLine("Detengase");
        break;
    
    case "Amarillo":
        Console.WriteLine("Precaucion, preparese para detenerse");
        break;
    
    case "Verde":
        Console.WriteLine("avance");
    break;
}