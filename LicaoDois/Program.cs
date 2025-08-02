// ALgoritmo para conversão de real para dólar, euro e peso argentino
Console.WriteLine("insira o valor em reais para conversão: ");
double real = Convert.ToDouble(Console.ReadLine());
double dolar = real*5.17; // taxa de conversão do real para dólar
double euro = real*6.14; // taxa de conversão do real para euro
double pesoArgentino = real*0.05; // taxa de conversão do real para peso argentino
Console.WriteLine("Valor em dólares: $" + dolar);
Console.WriteLine("Valor em euros: €" + euro);
Console.WriteLine("Valor em pesos argentinos: $" + pesoArgentino); 