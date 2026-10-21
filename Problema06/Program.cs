string j1 = Console.ReadLine() ?? "";
string j2 = Console.ReadLine() ?? "";

if (j1 == j2)
{
    Console.WriteLine("empate");
}
else if ((j1 == "piedra" && j2 == "tijera") ||
         (j1 == "papel" && j2 == "piedra") ||
         (j1 == "tijera" && j2 == "papel"))
{
    Console.WriteLine("Gana el Jugador 1");
}
else
{
    Console.WriteLine("Gana el Jugador 2");
}