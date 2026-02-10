using System;
using System.Collections.Generic;

namespace Hospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; private set; } = new();
        public Suite Suite { get; private set; }
        public int DiasReservados { get; private set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite == null)
                throw new Exception("Suíte não cadastrada.");

            if (hospedes.Count > Suite.Capacidade)
                throw new Exception("Capacidade da suíte insuficiente.");

            Hospedes = hospedes;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados > 10)
                valor *= 0.9m;

            return valor;
        }
    }
}
