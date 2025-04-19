using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVeiculos
{
     public class DeMisto : Veiculo
    {
        private int capacidadePassageiros;
        private double capacidadeCargaKg;

       
        

        public int CapacidadePassageiros
        {
            get => capacidadePassageiros;
            set
            {
                if (value <= 0)
                    throw new Exception("A capacidade de passageiros deve ser maior que zero.");
                capacidadePassageiros = value;
            }
        }

        public double CapacidadeCargaKg
        {
            get => capacidadeCargaKg;
            set
            {
                if (value < 0)
                    throw new Exception("A capacidade de carga não pode ser negativa.");
                capacidadeCargaKg = value;
            }
        }

        public DeMisto(
            string marca,
            string modelo,
            int ano,
            string categoria,
            decimal preco,
            string placa,
            int capacidadePassageiros,
            double capacidadeCargaKg
        )
        : base(marca, modelo, ano, categoria, preco, placa)
        {
            CapacidadePassageiros = capacidadePassageiros;
            CapacidadeCargaKg = capacidadeCargaKg;
           
        }
        public DeMisto() : base()
        {
            // Construtor padrão
        }
    }
}