using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "71985542436", modelo: "Nokia 1100i", imei: "324556-5698", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "71993730932", modelo: "Iphone XR", imei: "4521-9856", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Ifood");