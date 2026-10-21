int numero1 = int.Parse(Console.ReadLine() ?? "");
int numero2 = int.Parse(Console.ReadLine() ?? "");

if (numero1 > numero2)
{
    Console.WriteLine($"El mayor es {numero1}");
}
else if (numero2 > numero1)
{
    Console.WriteLine($"El mayor es {numero2}");
}
else
{
    Console.WriteLine("Los numeros son iguales");
}