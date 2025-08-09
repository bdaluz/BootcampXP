using DesafioSmartphone.Models;


Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "174715978915", modelo: "Nokia G60", imei: "1085884655262947" ,memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Pou");
nokia.ReceberLigacao();


Console.WriteLine("\nIphone:");
Smartphone iphone = new Iphone(numero: "17455699789", modelo: "Iphone 12", imei: "484844154499666", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Sky Guide");
iphone.ReceberLigacao();