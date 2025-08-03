// Exercício para identificação de faixa etária
Console.WriteLine("Informe sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());
if (idade <= 13)
{
    Console.WriteLine("Você é uma criança.");
}
else if (idade <= 18)
{
    Console.WriteLine("Você é um Adolescente.");
}
else if (idade <= 60)
{
    Console.WriteLine("Você é um Adulto.");
}
else
{
    Console.WriteLine("Você é um Idoso.");
}

