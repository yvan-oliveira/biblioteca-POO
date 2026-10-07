using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaPOO.Models;

internal class Livro : Material
{
    private string __isbn;
    private int __quantidadePaginas;

    public int QuantidadePaginas {
        get => this.__quantidadePaginas;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "A quantidade de páginas deve ser maior que zero."
                );
            }
            this.__quantidadePaginas = value;
        }
    }
        
    public string Isbn
    {
        get => this.__isbn;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O ISBN é obrigatório");

                this.__isbn = value;
        }
    }

    public Livro(string titulo, List<string> assuntos, string isbn, int quantidadePaginas, string? autor = null) : base(titulo, assuntos, autor)
    {
        this.Isbn = isbn;
        this.__quantidadePaginas = quantidadePaginas;
    }

    public override void MostrarInformacoes()
    {
        base.MostrarInformacoes();
        Console.WriteLine($"Titulo: {this._titulo}");
        Console.WriteLine($"Isbn: {this.__isbn}");
        Console.WriteLine($"Quantidade de Paginas: {this.__quantidadePaginas}");
        Console.WriteLine("---------------------------");
    }
}
