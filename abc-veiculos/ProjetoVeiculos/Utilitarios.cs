using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVeiculos
{
    public class Utilitario : DeMisto
    {
        private bool possuiTracaoIntegral;


        public bool PossuiTracaoIntegral
        {
            get => possuiTracaoIntegral;
            set => possuiTracaoIntegral = value;
        }

        public Utilitario(
            string marca,
            string modelo,
            int ano,
            string categoria,
            decimal preco,
            string placa,
            int capacidadePassageiros,
            int capacidadeCargaKg,
            bool possuiTracaoIntegral
        )
        : base(marca, modelo, ano, categoria, preco, placa, capacidadePassageiros,capacidadeCargaKg)
        {
            PossuiTracaoIntegral = possuiTracaoIntegral;
        }

         public Utilitario() : base()
            {
                // Construtor padrão
            }
    }
}