using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "999999999", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "888888888", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");