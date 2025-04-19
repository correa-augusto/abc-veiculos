using System;

namespace ProjetoVeiculos
{
    public class DadosVenda
    {
        private string nomeCliente;
        private string formaDePagamento;

        public string NomeCliente
        {
            get => nomeCliente;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Nome do cliente deve ser informado");
                }
                nomeCliente = value.Trim();
            }
        }

        public string FormaDePagamento
        {
            get => formaDePagamento;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Forma de pagamento deve ser informada");
                }
                formaDePagamento = value.Trim();
            }
        }

        public override string ToString()
        {
            return $"Cliente: {NomeCliente} | Pagamento: {FormaDePagamento}";
        }
    }
}
