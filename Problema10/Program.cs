object dato = true;

if (dato is string texto)
{
    int cantidad = texto.Length;
    Console.WriteLine($"Texto de {cantidad} caracteres");
}
else if (dato is int entero)
{
    Console.WriteLine($"Entero: {entero}");
}
else if (dato is decimal Dec)
{
    Console.WriteLine($"Decimal: {Dec}");
}
else if (dato is Boolean boleano)
{
    Console.WriteLine($"Booleano: {boleano}");    
}
else
{
    Console.WriteLine("tipo no reconocido");
}