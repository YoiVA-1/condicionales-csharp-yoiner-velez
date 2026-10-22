double peso = 70, estatura = 1.75;
double imc = peso / (estatura * estatura);

string categoria = imc switch {
    < 18.5 => "Bajo peso",
    < 25 => "Peso normal",
    < 30 => "Sobrepeso",
    _ => "Obesidad"
};

Console.WriteLine($"IMC: {imc:F1} - {categoria}");
