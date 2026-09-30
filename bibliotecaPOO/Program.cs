using bibliotecaPOO.Models;

namespace bibliotecaPOO;

internal class Program
{
    static void Main(string[] args)
    {
        Material livro = new Material(
            "Receitas de bolo",
            ["Receitas", "Doces", "Culinária", "Rango", "Boia", "Rala Bucho"],
            "Rita Lobo"
        );

        livro.mostrarInformacoes();
    }
}
