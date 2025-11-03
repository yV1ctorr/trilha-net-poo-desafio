using DesafioPOO.Models;

Nokia android = new Nokia("1234-5678", "Samsung S24", "1111", 128);
Iphone ios = new Iphone("0987-6543", "Iphone 13 pro", "2222", 256);


Console.WriteLine("Smartphone Android:");
android.Ligar();
android.InstalarAplicativo("Angry Birds");
android.ReceberLigacao();
Console.WriteLine($"Numero: {android.Numero}");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IOS:");
ios.Ligar();
ios.InstalarAplicativo("X");
ios.ReceberLigacao();
Console.WriteLine($"Numero: {ios.Numero}");