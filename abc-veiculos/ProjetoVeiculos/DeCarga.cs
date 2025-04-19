using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVeiculos
{
    public class DeCarga : Veiculo
    {
        private double capacidadeCargaKg;

        public double CapacidadeCargaKg
        {
            get => capacidadeCargaKg;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("A capacidade de carga deve ser maior que zero.");
                }
                capacidadeCargaKg = value;
            }
        }

        public DeCarga(string marca, string modelo, int ano, string categoria, decimal preco, string placa, double capacidadeCargaKg)
            : base(marca, modelo, ano, categoria, preco, placa)
        {
            CapacidadeCargaKg = capacidadeCargaKg;
        }
        public DeCarga() : base()
        {
            // Construtor padrão
        }
    }
}