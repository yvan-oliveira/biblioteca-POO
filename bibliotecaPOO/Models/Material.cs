using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaPOO.Models;

internal class Material
{
    private string _titulo;
    private string? _autor;
    private List<string> _assuntos;

    public string Titulo { get; set; }
    public string Autor { get; set; }
    public IReadOnlyList<string> Assuntos { get; set; }

    public Material(string titulo, string? autor = null)
    {
        _titulo = titulo;
        _autor = autor;
        _assuntos = new List<string>();
    }

    public void mostrarInformacoes()
    {
        Console.WriteLine($"Titulo: {this._titulo}");
        if (!string.IsNullOrWhiteSpace(_autor))
        {
            Console.WriteLine(_autor);
        }
        Console.WriteLine($"Assuntos {string.Join(", ", _assuntos)}");
    }
}
