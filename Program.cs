Console.Write("Qual o salário do João R$? ");
double salario = double.Parse(Console.ReadLine());
Console.Write("Qual o valor da primeira conta R$ ");
double conta1 = double.Parse(Console.ReadLine());
Console.Write("Qual o valor da segunda conta R$ ");
double conta2 = double.Parse(Console.ReadLine());

double salarioRestante = salario - ( (conta1 + (conta1 * (2.0 / 100.0))) + (conta2 + (conta2 * (2.0/100.0))) );
Console.WriteLine("O salário restante é R$ " + salarioRestante.ToString("F2"));
