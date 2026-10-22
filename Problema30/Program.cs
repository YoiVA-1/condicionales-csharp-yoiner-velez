double n1 = 85, n2 = 78, n3 = 92;
double promedio = (n1 + n2 + n3) / 3.0;

char letra = promedio switch {
    >= 90 => 'A',
    >= 80 => 'B',
    >= 70 => 'C',
    >= 60 => 'D',
    _ => 'F'
};

string retroalimentacion = letra switch {
    'A' => "Desempeño excelente",
    'B' or 'C' => "Buen desempeño, sigue así",
    'D' => "Aprobado, refuerza los temas",
    'F' => "Debe presentar plan de mejoramiento",
    _ => ""
};

string estado = promedio >= 60 ? "Aprobado" : "Reprobado";
string mencion = promedio == 100 ? " | ¡Mención de honor!" : "";

Console.WriteLine($"Promedio: {promedio:F1} | Letra: {letra} | {retroalimentacion} | {estado}{mencion}");
