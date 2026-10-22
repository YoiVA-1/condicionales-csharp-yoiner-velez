string codigo = Console.ReadLine() ?? "";

string nombrePais = codigo switch
{
    "CL" => "Chile",
    "MX" => "Mexico",
    "CO" => "Colombia",
    "PE" => "Peru",
    "AR" => "Argentina",
    _ => "Pais desconocido"
};

Console.WriteLine(nombrePais);