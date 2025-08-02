// Exercício para leitura de dois numeros e informar qual é o maior e qual é o menor
Console.WriteLine("Insira o primeiro número: ");
double primeironumero = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insira o segundo número: ");
double segundonumero = Convert.ToDouble(Console.ReadLine());
if (primeironumero > segundonumero)
{
    Console.WriteLine("O maior número é o " + primeironumero + " e o menor é o " + segundonumero);
}
else if (segundonumero > primeironumero)
{
    Console.WriteLine("O maior número é " + segundonumero + " e o menor é " + primeironumero);
}
else
{
    Console.WriteLine("Os números são iguais.");
}
