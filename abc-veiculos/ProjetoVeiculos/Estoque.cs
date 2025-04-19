using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using ProjetoVeiculos.ProjetoVeiculos.Models;

namespace ProjetoVeiculos;

public class Estoque
{


    private List<RegistroVenda> registros = new List<RegistroVenda>();
    public void EstoqueVeiculo()
    {
        string opcao = "";
        do
        {
            Console.WriteLine("\nCadastro de Veículo");
            Console.WriteLine("1. Carro\n2. Motocicleta\n3. Utilitário\n4. Bicicleta\n5. Caminhonete\n6. Listar Veículos\n7. Pesquisar por Placa\n8. Remover veiculo\n9 Vender veiculo\n10 LIstar revendas\n11 sair");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": CadastrarCarro(); break;
                case "2": CadastrarMotocicleta(); break;
                case "3": CadastrarUtilitario(); break;
                case "4": CadastrarBicicleta(); break;
                case "5": CadastrarCaminhonete(); break;
                case "6": ListarVeiculos(); break;
                case "7": PesquisarPorPlaca(); break;
                case "8": RemoverVeiculos(); break;
                case "9": VenderVeiculo(); break;
                case "10": ListarRevendas(); break;
                case "11": Console.WriteLine("Encerrando o programa."); break;
                default: Console.WriteLine("Opção inválida, tente novamente."); break;
            }
        } while (opcao != "9");
    }

    private string LerEntrada(string mensagem)
    {
        Console.WriteLine(mensagem);
        string entrada;
        do
        {
            entrada = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Entrada inválida. Tente novamente.");
            }
        } while (string.IsNullOrWhiteSpace(entrada));

        return entrada;
    }

    private int LerInteiro(string mensagem)
    {
        int valor;
        while (!int.TryParse(LerEntrada(mensagem), out valor))
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
        }
        return valor;
    }

    private decimal LerDecimal(string mensagem)
    {
        decimal valor;
        while (!decimal.TryParse(LerEntrada(mensagem), out valor))
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
        }
        return valor;
    }

    private double LerDouble(string mensagem)
    {
        double valor;
        while (!double.TryParse(LerEntrada(mensagem), out valor))
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
        }
        return valor;
    }

    private bool LerBoolean(string mensagem)
    {
        string entrada = LerEntrada(mensagem + " (s/n)").ToLower();
        return entrada == "s";
    }

    private bool VerificarPlacaDuplicada(string placa)
    {
        var disponiveis = registros.Where(r => !r.Vendido).ToList();
        return disponiveis.Any(r => r.Veiculo.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase));
    }

    public void CadastrarCarro()
    {
        string placa = LerEntrada("Digite a placa:");
        if (VerificarPlacaDuplicada(placa))
        {
            Console.WriteLine("Placa já cadastrada. Veículo não adicionado.");
            return;
        }

        string marca = LerEntrada("Digite a marca:");
        string modelo = LerEntrada("Digite o modelo:");
        int ano = LerInteiro("Digite o ano:");
        string categoria = LerEntrada("Digite a categoria:");
        decimal preco = LerDecimal("Digite o preço:");
        string motorizacao = LerEntrada("Digite a motorização:");
        int capacidadePassageiros = LerInteiro("Digite a capacidade de passageiros:");
        string tipoCombustivel = LerEntrada("Digite o tipo de combustível:");

        Automovel automovel = (new Automovel(marca, modelo, ano, categoria, preco, placa, capacidadePassageiros, tipoCombustivel, motorizacao));

        RegistroVenda registro = new RegistroVenda
        {
            Veiculo = automovel,
            DadosVenda = null
        };

        registros.Add(registro);
    }
    public void CadastrarMotocicleta()
    {
        string placa = LerEntrada("Digite a placa:");
        if (VerificarPlacaDuplicada(placa))
        {
            Console.WriteLine("Placa já cadastrada. Veículo não adicionado.");
            return;
        }

        string marca = LerEntrada("Digite a marca:");
        string modelo = LerEntrada("Digite o modelo:");
        int ano = LerInteiro("Digite o ano:");
        string categoria = LerEntrada("Digite a categoria:");
        decimal preco = LerDecimal("Digite o preço:");
        int capacidadePassageiros = LerInteiro("Digite a capacidade de passageiros:");
        int cilindradas = LerInteiro("Digite o numero de cilindradas");

        Motocicleta motocicleta = (new Motocicleta(marca, modelo, ano, categoria, preco, placa, capacidadePassageiros, cilindradas));

        RegistroVenda registro = new RegistroVenda
        {
            Veiculo = motocicleta,
            DadosVenda = null
        };

        registros.Add(registro);
    }

    public void CadastrarUtilitario()
    {
        string placa = LerEntrada("Digite a placa:");
        if (VerificarPlacaDuplicada(placa))
        {
            Console.WriteLine("Placa já cadastrada. Veículo não adicionado.");
            return;
        }

        string marca = LerEntrada("Digite a marca:");
        string modelo = LerEntrada("Digite o modelo:");
        int ano = LerInteiro("Digite o ano:");
        string categoria = LerEntrada("Digite a categoria:");
        decimal preco = LerDecimal("Digite o preço:");
        string motorizacao = LerEntrada("Digite a motorização:");
        int capacidadePassageiros = LerInteiro("Digite a capacidade de passageiros:");
        int capacidadeCargaKg = LerInteiro("Digite a capacidade de carga:");
        bool possuiTracaoIntegral = LerBoolean("Possui tração integral?");

        Utilitario utilitario = (new Utilitario(marca, modelo, ano, categoria, preco, placa, capacidadePassageiros, capacidadeCargaKg, possuiTracaoIntegral));


        RegistroVenda registro = new RegistroVenda
        {
            Veiculo = utilitario,
            DadosVenda = null
        };

        registros.Add(registro);
    }

    public void CadastrarBicicleta()
    {
        string placa = LerEntrada("Digite a placa:");
        if (VerificarPlacaDuplicada(placa))
        {
            Console.WriteLine("Placa já cadastrada. Veículo não adicionado.");
            return;
        }

        string marca = LerEntrada("Digite a marca:");
        string modelo = LerEntrada("Digite o modelo:");
        int ano = LerInteiro("Digite o ano:");
        string categoria = LerEntrada("Digite a categoria:");
        decimal preco = LerDecimal("Digite o preço:");
        int capacidadePassageiros = LerInteiro("Digite a capacidade de passageiros:");
        bool temMarcha = LerBoolean("Possui marcha?");

        Bicicleta bicicleta = (new Bicicleta(marca, modelo, ano, categoria, preco, placa, capacidadePassageiros, temMarcha));


        RegistroVenda registro = new RegistroVenda
        {
            Veiculo = bicicleta,
            DadosVenda = null
        };

        registros.Add(registro);
    }

    public void CadastrarCaminhonete()
    {
        string placa = LerEntrada("Digite a placa:");
        if (VerificarPlacaDuplicada(placa))
        {
            Console.WriteLine("Placa já cadastrada. Veículo não adicionado.");
            return;
        }


        string marca = LerEntrada("Digite a marca:");
        string modelo = LerEntrada("Digite o modelo:");
        int ano = LerInteiro("Digite o ano:");
        string categoria = LerEntrada("Digite a categoria:");
        decimal preco = LerDecimal("Digite o preço:");
        double capacidadeCargaKg = LerDouble("Digite a capacidade de carga:");
        string tipoCombustivel = LerEntrada("Digite o tipo de combustível:");
        bool tracao4x4 = LerBoolean("Pussui tração 4x4?");
        string motorizacao = LerEntrada("Digite a motorização:");

        Caminhonete caminhonete = (new Caminhonete(marca, modelo, ano, categoria, preco, placa, capacidadeCargaKg, tracao4x4, motorizacao, tipoCombustivel));

        RegistroVenda registro = new RegistroVenda
        {
            Veiculo = caminhonete,
            DadosVenda = null
        };

        registros.Add(registro);
    }

    public void ListarVeiculos()
    {
        var disponiveis = registros.Where(r => !r.Vendido).ToList();
        if (!disponiveis.Any())
        {
            Console.WriteLine("Nenhum veículo cadastrado.");
            return;
        }

        Console.WriteLine("\n--- Lista de Veículos em Estoque ---");
    foreach (var r in disponiveis)
    {
        Console.WriteLine($"\nTipo: {r.Veiculo.GetType().Name}");
        Console.WriteLine(r.Veiculo);
    }
    }

    public void PesquisarPorPlaca()
    {
        string placa = LerEntrada("Digite a placa a ser pesquisada:");
        var registro = registros.FirstOrDefault(r => r.Veiculo.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase));
        if (registro != null)
        {
            Console.WriteLine($"\nTipo: {registro.Veiculo.GetType().Name}\n{registro.Veiculo}");
            if (registro.Vendido)
            {
                Console.WriteLine($"Vendido para: {registro.DadosVenda.NomeCliente} | Forma de pagamento: {registro.DadosVenda.FormaDePagamento}");
            }
            else
            {
                Console.WriteLine("Veículo ainda está em estoque.");
            }
        }
        else
            Console.WriteLine("Veículo não encontrado.");
    }

    public void RemoverVeiculos()
    {
        string placa = LerEntrada("Digite a placa do veículo:");

        var registro = registros.FirstOrDefault(r => r.Veiculo.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase));

        if (registro != null)
        {
            if (!registro.Vendido)
            {
                registros.Remove(registro);
                Console.WriteLine("Veículo removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Veículo já foi vendido e não pode ser removido.");
            }
        }
        else
        {
            Console.WriteLine("Veículo não encontrado.");
        }
    }

    public void VenderVeiculo()
    {
        string placa = LerEntrada("Digite a placa do veículo a ser vendido:");
        var registro = registros.FirstOrDefault(r => r.Veiculo.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase));

        if (registro != null)
        {
            if (registro.Vendido)
            {
                Console.WriteLine("Este veículo já foi vendido.");
                return;
            }
            {
                string nomeCliente = LerEntrada("Digite o nome do cliente:");
                string formaPagamento = LerEntrada("Digite a forma de pagamento:");

                registro.DadosVenda = new DadosVenda
                {
                    NomeCliente = nomeCliente,
                    FormaDePagamento = formaPagamento
                };
                Console.WriteLine($"Venda realizada: {registro.DadosVenda} | Veículo: {registro.Veiculo}");
            }

        }
        else
        {
            Console.WriteLine("Veículo não encontrado.");
            return;
        }
    }

    public void ListarRevendas()
    {
        var vendidos = registros.Where(r => r.Vendido).ToList();

        if (!vendidos.Any())
        {
            Console.WriteLine("Nenhuma venda registrada ainda.");
            return;
        }

        Console.WriteLine("\n--- Lista de Veículos Vendidos ---");
        foreach (var r in vendidos)
        {
            Console.WriteLine($"Cliente: {r.DadosVenda.NomeCliente} | Forma de pagamento: {r.DadosVenda.FormaDePagamento} | Veículo: {r.Veiculo}");
        }
    }

}


