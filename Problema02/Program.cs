double peso = -3;

string precio = peso switch 
{
    < 0 => "Peso invalido",
    0 => "Tarifa 0",
    < 1 => "$8.000kg",
    >= 1 and < 5 => "$15.000",
    >= 5 and < 20 => "$32.000",
    >= 20 => "$60.000",
    _ => "Valor no valido"
};

Console.WriteLine(precio);
