using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVeiculos
{
    using System;
    using System.Text.RegularExpressions;

    namespace ProjetoVeiculos.Models
    {
        public class Automovel : DePassageiros
        {
            private string tipoCombustivel;
            private string motorizacao;

            public string TipoCombustivel
            {
                get => tipoCombustivel;
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new Exception("Tipo de combustível deve ser informado.");
                    }

                    tipoCombustivel = value.Trim();
                }
            }


            public string Motorizacao
            {
                get => motorizacao;
                set
                {
                    string valor = value.Trim();
                    var regex = new Regex(@"^\d\.\d$");

                    if (!regex.IsMatch(valor))
                    {
                        throw new Exception("Motorização deve ser informada no formato: 1.0");
                    }
                    motorizacao = valor;
                }
            }

            public Automovel(
                string marca,
                string modelo,
                int ano,
                string categoria,
                decimal preco,
                string placa,
                int capacidadePassageiros,
                string tipoCombustivel,
                string motorizacao

            )
            : base(marca, modelo, ano, categoria, preco, placa, capacidadePassageiros)
            {
                TipoCombustivel = tipoCombustivel;
                Motorizacao = motorizacao;

            }
            public Automovel() : base()
            {
                // Construtor padrão
            }

            public override string ToString()
            {
                return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Categoria: {Categoria}, Preço: {Preco:C}, Placa: {Placa} Capacidade de passageiros: {CapacidadePassageiros}, tipo de combustivel: {tipoCombustivel}, Motorização: {motorizacao}";
            }


        }
    }

}