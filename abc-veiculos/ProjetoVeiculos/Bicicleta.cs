using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVeiculos
{
    public class Bicicleta : DePassageiros
    {
        private bool temMarcha;

        public bool TemMarcha
        {
            get => temMarcha;
            set
            {
                temMarcha = value;
            }
        }

        public Bicicleta(string marca, string modelo, int ano, string categoria, decimal preco, string placa, int capacidadePassageiros, bool temMarcha)
           : base(marca, modelo, ano, categoria, preco, placa, capacidadePassageiros)
           {
                TemMarcha = temMarcha;
           }
        public Bicicleta() : base()
        {
            // Construtor padrão
         } }
}