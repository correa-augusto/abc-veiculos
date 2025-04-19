using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVeiculos
{
    public class RegistroVenda
{
    public Veiculo Veiculo { get; set; }
    public DadosVenda? DadosVenda { get; set; } // Se for null, veiculo ainda esta em estoque

    public bool Vendido => DadosVenda != null;
}
}