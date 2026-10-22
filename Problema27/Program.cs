string dia = "sábado"; bool esEstudiante = true;
string precio = (dia.ToLower(), esEstudiante) switch {
    ("martes", _) => "$7.000",
    ("sábado" or "domingo", _) => "$15.000",
    ("lunes" or "miércoles" or "jueves" or "viernes", true) => "$9.000",
    ("lunes" or "miércoles" or "jueves" or "viernes", false) => "$12.000",
    _ => "Día inválido"
};
Console.WriteLine(precio);
