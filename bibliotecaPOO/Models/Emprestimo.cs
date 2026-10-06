using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaPOO.Models;

internal class Emprestimo
{
    private Usuario _usuario;
    private Material _material;
    private DateTime _dataPrevistaDevolucao;
    private DateTime? _dataDevolucao;
    private bool _ativo;
   /* private Multa? _multa;

    public Usuario Usuario { get; set }*/

}
