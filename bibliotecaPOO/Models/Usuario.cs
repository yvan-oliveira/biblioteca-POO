using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaPOO.Models;

internal class Usuario
{
    private string __matricula;
    private string __nome;
    private bool __podeEmprestar;
    private List<Emprestimo> __emprestimos;

    public string Matricula { get => __matricula; set => __matricula = value; }
    public string Nome { get => __nome; set => __nome = value; }
    public bool PodeEmprestar { 
        get => __podeEmprestar;
        set
        {
            if (this.__emprestimos.Count() > 0)
            {
                __podeEmprestar = value;
            }
            else
            {
                __podeEmprestar = false;
            };
        }
    }

    public Usuario(string matricula, string nome, bool podeEmprestar)
    {
        this.__matricula = matricula;
        this.__nome = nome;
        this.__podeEmprestar = podeEmprestar;
        this.__emprestimos = new List<Emprestimo>();
    }

    public void Registrar(Emprestimo emprestimo)
    {

    }
}
