using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoVeiculos
{
    public class Caminhonete : DeCarga
    {
        private bool tracao4x4;
        private string tipoCambio;
        private string motorizacao;
        private string tipoCombustivel;


        public bool Tracao4x4
        {
            get => tracao4x4;
            set => tracao4x4 = value;
        }

      

        public string Motorizacao
        {
            get => motorizacao;
            set
            {
                string valor = value.Trim();
                var regex = new Regex("^\"\\d\\.\\d\"$"); 

                if (!regex.IsMatch(valor))
                {
                 throw new Exception("Motorização deve ser informada no formato: \"1.0\"");
                }
                motorizacao = valor;
         }
        }

        
        public string TipoCombustivel
        {
            get => tipoCombustivel;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Tipo de combustível deve ser informado.");
                tipoCombustivel = value.Trim();
            }
        }


        public Caminhonete(
            string marca,
            string modelo,
            int ano,
            string categoria,
            decimal preco,
            string placa,
            double capacidadeCargaKg,
            bool tracao4x4,
            string motorizacao,
            string tipoCombustivel
        )
        : base(marca, modelo, ano, categoria, preco, placa, capacidadeCargaKg)
        {
            Tracao4x4 = tracao4x4;
            
            Motorizacao = motorizacao;
            TipoCombustivel = tipoCombustivel;
        }
        public Caminhonete() : base()
        {
            // Construtor padrão
        }
    }
}