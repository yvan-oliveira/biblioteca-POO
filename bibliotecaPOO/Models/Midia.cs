using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaPOO.Models;

internal class Midia : Material
{
    private string _tempoMidia;
    private string _anoProducao;

    public string TempoMidia;
    public string AnoProducao;

    public Midia(string titulo, List<string> assuntos, string tempoMidia, string anoProducao, string? autor = null) : base(titulo, assuntos, autor)
    {
        _tempoMidia = tempoMidia;
        _anoProducao = anoProducao;
    }

    public override void mostrarInformacoes()
    {
        base.mostrarInformacoes();
        Console.WriteLine(this._titulo);
        Console.WriteLine($"Duração: {this._tempoMidia}");
        Console.WriteLine($"Ano de produção: {this._anoProducao}");
        Console.WriteLine("---------------------------");
    }
}
