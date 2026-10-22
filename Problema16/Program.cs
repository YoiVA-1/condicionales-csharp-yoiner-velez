int x = 3, y = 4;
string ubicacion = (x, y) switch {
    (0, 0) => "Origen",
    (0, _) or (_, 0) => "Sobre un eje",
    (> 0, > 0) => "Primer cuadrante",
    (< 0, > 0) => "Segundo cuadrante",
    (< 0, < 0) => "Tercer cuadrante",
    (> 0, < 0) => "Cuarto cuadrante"
};
Console.WriteLine(ubicacion);
