using System.Diagnostics.Tracing;

string letra = Console.ReadLine() ?? "";

if (char.TryParse(letra, out char salida) && char.IsLetter(salida))
{
    if(letra is "a" or "e" or "i" or "o" or "u")
    {
        Console.WriteLine("Es vocal");
    }
    else
    {
        Console.WriteLine("Es consonante");
    }
}else
{
    Console.WriteLine("No es una letra");
}
