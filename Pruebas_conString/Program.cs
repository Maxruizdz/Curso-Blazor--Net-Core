// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

String[] oraciones = { "Mi próximo viaje está planeado para el mes que viene.",
"Quiero aprender a cocinar platos exóticos en mis vacaciones",
"Durante el viaje en tren, disfruté de hermosos paisajes.",
"Me encanta leer novelas de aventuras en mi tiempo libre.",
"Hicimos un emocionante viaje por carretera por la costa.",
"Pasé la tarde visitando museos y galerías de arte.",
"Encontré un gran libro sobre viajes en la biblioteca.",
"Este año, mi familia y yo planeamos un viaje a Europa.",
"Sueño con hacer un viaje alrededor del mundo algún día.",
"Durante las vacaciones, relajarse en la playa es mi prioridad."};
List<String> list = new List<String>();


list.AddRange(oraciones);



foreach (String oracion in list) {


    if (oracion.Contains("viaje")) {
    
    
    Console.WriteLine(oracion); 
    
    }


}



