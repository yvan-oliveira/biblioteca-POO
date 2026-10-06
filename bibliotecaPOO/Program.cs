using bibliotecaPOO.Models;

namespace bibliotecaPOO;

internal class Program
{
    static void Main(string[] args)
    {
        Livro livro1 = new Livro(
            "Receitas de bolo",
            ["Receitas", "Doces", "Culinária", "Rango", "Boia", "Rala Bucho"],
            "9780064471190",
            100,
            "Cleiton"
        );

        //livro1.mostrarInformacoes();

        Livro livro2 = new Livro
        (
            "As crônicas de Gelo e Fogo",
            ["Fantasia", "Aventura", "Guerra"],
            "9780064471190",
            300,
            "George R. R. Martin"
        );

        //violaoBiblioteca.mostrarInformacoes();

        Livro livro3 = new Livro(
            "Crônicas de Nárnia",
            ["Fantasia", "Aventura"],
            "9780064471190",
            767/*,
            "C. S. Lewis",*/
        );

        livro3.MostrarInformacoes();

        Midia daniel = new Midia(
            "ser vivo",
            ["garoto", "de"],
            "60",
            "5",
            "Daniel"
        );

        daniel.MostrarInformacoes();

        Console.WriteLine(livro3.QuantidadePaginas);
        livro3.Titulo = "seila";
        Console.WriteLine(livro3.Titulo);
    }
}
