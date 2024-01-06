using DesafioPOO.Models;

 // Criando uma instância do Nokia
Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia(numero: "987745327", modelo: "edge", imei: "1111111", memoria: 128);
            
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
// Criando uma instância do iPhone
Iphone iphone = new Iphone(numero: "987654321", modelo: "plus", imei: "00000000", memoria: 128);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");