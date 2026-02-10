using System.Text;
using Hospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Simulação de payload vindo do front
var input = new ReservaInput
{
    DiasReservados = 5,
    Hospedes = new List<string> { "Hóspede 1", "Hóspede 2" },
    TipoSuite = "Premium",
    Capacidade = 2,
    ValorDiaria = 30
};

// Converte input em domínio
var hospedes = input.Hospedes
    .Select(nome => new Pessoa(nome))
    .ToList();

var suite = new Suite(input.TipoSuite, input.Capacidade, input.ValorDiaria);

var reserva = new Reserva(input.DiasReservados);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Output simulando resposta da API
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
