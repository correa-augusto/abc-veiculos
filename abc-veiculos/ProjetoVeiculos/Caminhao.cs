using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVeiculos
{
    public class Caminhao : DeCarga
    {
        private int numeroEixos;
        private bool possuiReboque;

        public int NumeroEixos
        {
            get => numeroEixos;
            set
            {
                if (value <= 0)
                    throw new Exception("O número de eixos deve ser maior que zero.");
                numeroEixos = value;
            }
        }

        public bool PossuiReboque
        {
            get => possuiReboque;
            set => possuiReboque = value;
        }

        public Caminhao(
            string marca,
            string modelo,
            int ano,
            string categoria,
            decimal preco,
            string placa,
            double capacidadeCargaKg,
            int numeroEixos,
            bool possuiReboque
        )
        : base(marca, modelo, ano, categoria, preco, placa, capacidadeCargaKg)
        {
            NumeroEixos = numeroEixos;
            PossuiReboque = possuiReboque;
        }
        public Caminhao():base()
        {
            // Construtor padrão
        }
        
    }
}