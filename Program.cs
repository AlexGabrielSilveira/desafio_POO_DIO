using DesafioPOO.Models;

Console.WriteLine("Nokia tijolão na voz: ");
Smartphone nokia = new Nokia(numero: "1194221-0997", modelo: "modelo 001",imei: "1111111111111", memoria: "4GB");

nokia.Ligar();
nokia.InstalarAplicativo("tinder");

Console.WriteLine("\n");

Console.WriteLine("Celular de burgues: ");
Smartphone iphone = new Iphone(numero: "194221-0998", modelo: "modelo 2", imei: "222222222222", memoria: "264GB");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("ZAPZAP");

