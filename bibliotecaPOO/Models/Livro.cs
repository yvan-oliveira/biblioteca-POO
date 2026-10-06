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

    public int QuantidadePaginas;
    public string Isbn;

    public Livro(string titulo, List<string> assuntos, string isbn, int quantidadePaginas, string? autor = null) : base(titulo, assuntos, autor)
    {
        this._isbn = isbn;
        this._quantidadePaginas = quantidadePaginas;
    }
}
