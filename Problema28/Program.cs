decimal compra = 250000; bool frecuente = true;
decimal descuentoBase = compra switch {
    >= 500000 => 0.15m,
    >= 200000 => 0.10m,
    >= 100000 => 0.05m,
    _ => 0.00m
};
decimal descuentoAdicional = (frecuente && compra >= 100000) ? 0.05m : 0.00m;
decimal descuentoTotal = descuentoBase + descuentoAdicional;
decimal totalPagar = compra * (1 - descuentoTotal);
Console.WriteLine($"Compra: {compra}, Descuento: {descuentoTotal * 100}%, Total: {totalPagar}");
