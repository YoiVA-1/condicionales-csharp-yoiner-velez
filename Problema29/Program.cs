string rol = "aprendiz"; int hora = 19;
string acceso = (rol.ToLower(), hora) switch {
    ("admin", >= 0 and <= 23) => "Acceso permitido",
    ("instructor", >= 6 and <= 21) => "Acceso permitido",
    ("aprendiz", >= 6 and <= 18) => "Acceso permitido",
    _ => "Acceso denegado"
};
Console.WriteLine(acceso);
