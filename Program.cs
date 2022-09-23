using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Zack");
Pessoa p2 = new Pessoa(nome: "Mara");
Pessoa p3 = new Pessoa(nome: "Gaby");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 49.90M);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 12);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Hóspedes :");
foreach(Pessoa hospede in hospedes)
{
    Console.WriteLine(hospede.Nome);
}
Console.WriteLine($"\nValor diária: {suite.ValorDiaria}");
Console.WriteLine($"Valor total: {reserva.CalcularValorDiaria()}");
Console.WriteLine($"Valor por pessoa: {reserva.CalcularValorDiaria() / reserva.ObterQuantidadeHospedes()}");

if (reserva.DiasReservados >= 10)
{
    Console.WriteLine("Valor desconto: {0:0.00}", + reserva.CalcularValorDiaria() / 10);
}