string comando = "play";
string mensaje = comando switch {
    "play" => "Reproduciendo...",
    "pause" => "En pausa",
    "stop" => "Detenido",
    "next" => "Siguiente canción",
    _ => "Comando no reconocido"
};
Console.WriteLine(mensaje);
