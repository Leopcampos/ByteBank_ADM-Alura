using bytebank_ADM.Funcionarios;
using System.Globalization;

Funcionario Pedro = new Funcionario();
Pedro.Nome = "Pedro Queiroz";
Pedro.Cpf = "123456789";
Pedro.Salario = 2000;

Console.WriteLine("Bonificação de Pedro: " + Pedro.GetBonificacao().ToString("C2", CultureInfo.CurrentCulture));
Console.WriteLine("Salário atualizado de Pedro: " + Pedro.SalarioAtualizado().ToString("C2", CultureInfo.CurrentCulture));

Diretor diretor = new Diretor();
diretor.Nome = "Cícero César";
diretor.Cpf = "11445355796";
diretor.Salario = 5000;

Console.WriteLine();
Console.WriteLine("Bonificação de Cícero: " + diretor.GetBonificacao().ToString("C2", CultureInfo.CurrentCulture));
Console.WriteLine("Salário atualizado de Cícero: " + diretor.SalarioAtualizado().ToString("C2", CultureInfo.CurrentCulture));