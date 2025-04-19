using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVeiculos
{
    public class DePassageiros : Veiculo
    {
        private int capacidadePassageiros;
        public int CapacidadePassageiros
        {
            get => capacidadePassageiros;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("A capacidade de passageiros deve ser maior que zero.");
                }
                capacidadePassageiros = value;
            }
        }

        public DePassageiros(string marca, string modelo, int ano, string categoria, decimal preco, string placa, int capacidadePassageiros)
            : base(marca, modelo, ano, categoria, preco, placa)
        {
            CapacidadePassageiros = capacidadePassageiros;
        }
        public DePassageiros() : base()
        {
            // Construtor padrão
        }
    }
}