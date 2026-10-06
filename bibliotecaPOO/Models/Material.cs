using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaPOO.Models;

internal abstract class Material
{
    protected string _titulo;
    protected string? _autor;
    protected List<string> _assuntos;

    public string Titulo { get { return this._titulo.ToUpper(); } set { this._autor = value; } }
    public string Autor { get => this._autor ?? "Não informado" ; set => this._autor = value; }
    public List<string> Assuntos { get => this._assuntos; set => this._assuntos = value; }

    public Material(string titulo, List<string> assuntos, string? autor = null)
    {
        _titulo = titulo;
        _autor = autor;
        _assuntos = assuntos;
    }

    public virtual void MostrarInformacoes()
    {
        Console.WriteLine("\n---------------------------");

        Console.WriteLine($"Titulo: {this._titulo}");

        Console.WriteLine($"Autor: {this._autor}");
        /*if (!string.IsNullOrWhiteSpace(_autor))
        {
        }
        else
        {
            Console.WriteLine($"Autor: Não encontrado");
        }*/
        
        Console.WriteLine($"Assuntos: {string.Join(", ", _assuntos)}");
    }

    /*public decimal CalcularMulta(int DiasAtraso)
    {
        return;
    }*/

    public void MarcarEmprestado()
    {

    }

    public void MarcarDisponivel()
    {

    }
}
