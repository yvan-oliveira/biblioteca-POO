using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaPOO.Models;

internal class Midia : Material
{
    private string __tempoMidia;
    private string __anoProducao;

    public string TempoMidia;
    public string AnoProducao;

    public Midia(string titulo, List<string> assuntos, string tempoMidia, string anoProducao, string? autor = null) : base(titulo, assuntos, autor)
    {
        __tempoMidia = tempoMidia;
        __anoProducao = anoProducao;
    }

    public override void MostrarInformacoes()
    {
        base.MostrarInformacoes();
        Console.WriteLine(this._titulo);
        Console.WriteLine($"Duração: {this.__tempoMidia}");
        Console.WriteLine($"Ano de produção: {this.__anoProducao}");
        Console.WriteLine("---------------------------");
    }
}
