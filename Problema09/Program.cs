Console.WriteLine("Ingrese un año:");
int año = int.Parse(Console.ReadLine() ?? "0");

if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
{
    Console.WriteLine("Es bisiesto");
}
else
{
    Console.WriteLine("No es bisiesto");
}
