using System;

namespace ProjetoVeiculos
{
    public class Veiculo
    {
        private string marca;
        private string modelo;
        private int ano;
        private string categoria;
        private decimal preco;

        private string placa;

        public string Marca
        {
            get => marca;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Marca deve ser preenchida");
                marca = value.Trim();
            }
        }
        public string Modelo
        {
            get => modelo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Modelo deve ser preenchido");
                modelo = value.Trim();
            }
        }

        public int Ano
        {
            get => ano;
            set
            {
                if (value <= 1900)
                    throw new Exception("Não aceitamos carros desse ano");
                ano = value;
            }
        }

        public string Categoria
        {
            get => categoria;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Categoria deve ser preenchida");
                categoria = value.Trim();
            }
        }

        public decimal Preco
        {
            get => preco;
            set
            {
                if (value <= 0)
                    throw new Exception("Preço deve ser maior que zero");
                preco = value;
            }
        }

        
        public string Placa
        {
            get => placa;
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Placa deve ser preenchida");
                }
                placa = value.Trim();
            }
        }

        public Veiculo(string marca, string modelo, int ano, string categoria, decimal preco, string placa)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Categoria = categoria;
            Preco = preco;
            Placa = placa;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Categoria: {Categoria}");
            Console.WriteLine($"Preço: R${Preco:N2}");
            Console.WriteLine($"Placa: {placa}");
        }

        public Veiculo()
        {
            // Construtor padrão
        }
    }
}
