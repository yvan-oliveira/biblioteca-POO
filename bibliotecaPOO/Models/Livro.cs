using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaPOO.Models;

internal class Livro : Material
{
    private string _isbn;
    private int _quantidadePaginas;

    public int QuantidadePaginas { get => this._quantidadePaginas; set => this._quantidadePaginas = value; }
    public string Isbn { get => this._isbn; set => this._isbn = value; }

    public Livro(string titulo, List<string> assuntos, string isbn, int quantidadePaginas, string? autor = null) : base(titulo, assuntos, autor)
    {
        this._isbn = isbn;
        this._quantidadePaginas = quantidadePaginas;
    }

    public override void mostrarInformacoes()
    {
        base.mostrarInformacoes();
        Console.WriteLine($"Titulo: {this._titulo}");
        Console.WriteLine($"Isbn: {this._isbn}");
        Console.WriteLine($"Quantidade de Paginas: {this._quantidadePaginas}");
        Console.WriteLine("---------------------------");
    }
}
