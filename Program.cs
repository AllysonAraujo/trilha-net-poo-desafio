using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero:"84526387", modelo:"X1", imei:"1796541230", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iPhone = new iPhone(numero:"97848215", modelo:"Pro Max", imei:"8745216320", memoria:256);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Facebook");