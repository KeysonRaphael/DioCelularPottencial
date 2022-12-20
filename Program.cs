using DioCelularPottencial.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"123456",modelo:"Modelo 1",imei:"11111111111",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone(numero:"123456",modelo:"Modelo 1",imei:"11111111111",memoria:64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");