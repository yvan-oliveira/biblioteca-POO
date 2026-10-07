using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaPOO.Models;

internal class Emprestimo
{
    private Usuario __usuario;
    private Material __material;
    private DateTime __dataPrevistaDevolucao;
    private DateTime? __dataDevolucao;
    private bool __ativo;
    private Multa? __multa;

    internal Usuario Usuario { get => __usuario; set => __usuario = value; }
    internal Material Material { get => __material; set => __material = value; }
    public DateTime DataPrevistaDevolucao { get => __dataPrevistaDevolucao; set => __dataPrevistaDevolucao = value; }
    public DateTime? DataDevolucao { get => __dataDevolucao; set => __dataDevolucao = value; }
    public bool Ativo { get => __ativo; set => __ativo = value; }
    internal Multa? Multa { get => __multa; set => __multa = value; }

    public Emprestimo(Usuario usuario, Material material, DateTime dataPrevistaDevolucao, DateTime? dataDevolucao, bool ativo, Multa? multa)
    {
        __usuario = usuario;
        __material = material;
        __dataPrevistaDevolucao = dataPrevistaDevolucao;
        __dataDevolucao = dataDevolucao;
        __ativo = ativo;
        __multa = multa;
    }

    public void Devolver(DateTime data)
    {
        __dataDevolucao = data;
    }
}
