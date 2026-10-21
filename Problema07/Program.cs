int numero1 = int.Parse(Console.ReadLine() ?? "");

string tipoNumero = numero1 switch 
{
    0 => "cero",
    < 0 => "Negativo",
    > 0 => "Positivo"
};

Console.WriteLine(tipoNumero);