namespace Hospedagem.Models
{
    public class Suite
    {
        public TipoSuite Tipo { get; private set; }
        public int Capacidade { get; private set; }
        public decimal ValorDiaria { get; private set; }

        public Suite(TipoSuite tipo, int capacidade, decimal valorDiaria)
        {
            if (capacidade <= 0)
                throw new ArgumentException("Capacidade deve ser maior que zero.");

            if (valorDiaria <= 0)
                throw new ArgumentException("Valor da diária deve ser maior que zero.");

            Tipo = tipo;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }
}
