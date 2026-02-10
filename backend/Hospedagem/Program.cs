using System.Text;
using Hospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

var hospedes = new List<Pessoa>
{
    new Pessoa("Hóspede 1"),
    new Pessoa("Hóspede 2"),
    new Pessoa("Hóspede 3"),
};

var suite = new Suite(
    TipoSuite.Premium,
    capacidade: 2,
    valorDiaria: 30
);

var reserva = new Reserva(5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
