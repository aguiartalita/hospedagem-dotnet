using System.Collections.Generic;

namespace Hospedagem.Models
{
    public class ReservaInput
    {
        public int DiasReservados { get; set; }
        public List<string> Hospedes { get; set; }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}
