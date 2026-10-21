int nivelBateria = int.Parse(Console.ReadLine() ?? "");
string alerta = nivelBateria < 15 ? $"Bateria baja: Conecte el cargador \n Nivel actual:{nivelBateria}%" : $"Nivel actual: {nivelBateria}";
Console.WriteLine(alerta);