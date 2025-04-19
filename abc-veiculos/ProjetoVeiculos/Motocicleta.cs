using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVeiculos
{
    public class Motocicleta : DePassageiros
    {
        private int cilindradas;
       

        public int Cilindradas
        {
            get => cilindradas;
            set 
            {
                if(value <= 49)
                {
                    throw new Exception("cilindrada deve ser maior ou igual a 50");
                }
                cilindradas = value;
            }
        }

        public Motocicleta(
            string marca,
            string modelo,
            int ano,
            string categoria,
            decimal preco,
            string placa,
            int capacidadePassageiros,
            int cilindradas 
        )
        : base(marca, modelo, ano, categoria, preco, placa, capacidadePassageiros)
        {
            Cilindradas = cilindradas;  
        }
        public Motocicleta() : base()
        {
            // Construtor padrão
        }
    }

    }