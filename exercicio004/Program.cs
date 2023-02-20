// See https://aka.ms/new-console-template for more information
/*
    Desenvolver um algoritmo que entra com o salario fixo, percentual de venda, total de venda e informe o salario final

*/

string nome;
double salariofixo = 0,  totalvendas = 0, percentualvenda = 0, salariofinal = 0;

Console.Write("Informe o nome: ");
nome = Console.ReadLine();

Console.Write("Informe o valor do salario fixo: ");
salariofixo = Convert.ToDouble(Console.ReadLine());
Console.Write("Informe o percentual de vendas: ");
totalvendas = Convert.ToDouble(Console.ReadLine());

percentualvenda = totalvendas * 0.15;
salariofinal = salariofixo + percentualvenda;

Console.WriteLine("O seu salário Final é "+salariofinal);

Console.ReadLine();


