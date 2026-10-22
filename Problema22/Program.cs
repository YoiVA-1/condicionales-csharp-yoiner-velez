int a = 5, b = 2; char op = '%';
int resultado = op switch {
    '+' => a + b,
    '-' => a - b,
    '*' => a * b,
    '/' => b == 0 ? throw new System.DivideByZeroException("No se puede dividir entre cero") : a / b,
    _ => throw new System.ArgumentException("Operador no soportado")
};
Console.WriteLine($"{a} {op} {b} = {resultado}");
