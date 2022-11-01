using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;
using System.Globalization;

Designer Pedro = new Designer("123456789");
Pedro.Nome = "Pedro Queiroz";

Console.WriteLine("Bonificação de Pedro: " + Pedro.GetBonificacao().ToString("C2", CultureInfo.CurrentCulture));
Console.WriteLine("Salário atualizado de Pedro: " + Pedro.SalarioAtualizado().ToString("C2", CultureInfo.CurrentCulture));

Diretor Cicero = new Diretor("11445355796");
Cicero.Nome = "Cícero César";

Console.WriteLine();
Console.WriteLine("Bonificação de Cícero: " + Cicero.GetBonificacao().ToString("C2", CultureInfo.CurrentCulture));
Console.WriteLine("Salário atualizado de Cícero: " + Cicero.SalarioAtualizado().ToString("C2", CultureInfo.CurrentCulture));

Console.WriteLine();
Console.WriteLine(Pedro);
Console.WriteLine(Cicero);

Console.WriteLine();
Console.WriteLine("Total de Funcionários: " + Funcionario.TotalDeFuncionarios);

CalcularBonificacao();
Console.WriteLine();
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("987456");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("74581");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("852963");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonficacao.ToString("C2", CultureInfo.CurrentCulture));
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("852741");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("258147");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "321";

    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "963");
}

