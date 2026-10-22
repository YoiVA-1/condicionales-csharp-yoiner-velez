double estatura = 1.45; int edad = 10; bool acompañado = false;
bool puedeSubir = estatura >= 1.40 && (edad >= 12 || acompañado);
string resultado = puedeSubir ? "Puede subir" : "No puede subir";
Console.WriteLine(resultado);
