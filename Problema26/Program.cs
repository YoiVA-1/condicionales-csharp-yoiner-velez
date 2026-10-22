char categoriaVehiculo = 'D';
string respuesta = char.ToUpper(categoriaVehiculo) switch {
    'M' => "Categoría M - Tarifa: $0",
    'A' => "Categoría A - Tarifa: $12.000",
    'B' => "Categoría B - Tarifa: $25.000",
    'C' => "Categoría C - Tarifa: $38.000",
    _   => throw new ArgumentException("Categoría desconocida")
};
Console.WriteLine(respuesta);
