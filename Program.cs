using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "01020", modelo: "G60 5G", imei: "111222333", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Sketchbook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "54321", modelo: "XV Plus", imei: "333111222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Procreate Pocket");