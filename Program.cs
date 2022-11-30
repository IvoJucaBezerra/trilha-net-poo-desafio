using DesafioPOO.Models;

Console.WriteLine("Smartphone iphone:");
Iphone iphone = new Iphone(numero: "12345678", modelo: "A", imei: "1111",memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("YouTube");

Console.WriteLine("--------------------------------------------------------");

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "23456789", modelo: "B", imei: "2222",memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Spotify");

Console.WriteLine("--------------------------------------------------------");