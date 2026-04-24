// See https://aka.ms/new-console-template for more information



double altura, peso, IMC; 

Console.WriteLine("Altura (m)..: ");
altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Peso (kg)..: ");
peso = Convert.ToDouble(Console.ReadLine());

IMC = peso / Math.Pow(altura, 2);

Console.WriteLine($"\nIMC: {IMC:N1} kg/m²");