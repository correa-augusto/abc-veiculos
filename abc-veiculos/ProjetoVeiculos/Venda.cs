using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVeiculos
{
    public class Venda
{
    public string NomeCliente { get; set; }
    public string FormaDePagamento { get; set; }
    public Veiculo VeiculoVendido { get; set; }

    public override string ToString()
    {
        return $"Cliente: {NomeCliente} | Pagamento: {FormaDePagamento} | Veículo: {VeiculoVendido}";
    }
}

}