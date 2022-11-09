using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "9235-4687", modelo: "Iphone 14", imei: "11111111", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n==============================================\n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "9888-8888", modelo: "Nokita A1", imei: "12345124512", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");