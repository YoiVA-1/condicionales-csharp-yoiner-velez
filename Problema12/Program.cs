Console.WriteLine("Tiene empleo?:");
string empleo = Console.ReadLine() ?? "";

if (empleo == "Si")
{
    Console.WriteLine("Ingrese su ingreso mensual:");
    int ingresoMensual = int.Parse(Console.ReadLine() ?? "0");

    if (ingresoMensual >= 2500000)
    {
        Console.WriteLine("Credito alto aprobado");
    }
    else
    {
        Console.WriteLine("Credito basico aprobado");
    }
}
else if (empleo == "No")
{
    Console.WriteLine("Credito rechazado");
}
else
{
    Console.WriteLine("Opcion invalida");
}
