using bibliotecaPOO.Models;

namespace bibliotecaPOO;

internal class Program
{
    static void Main(string[] args)
    {
        Material livro1 = new Material(
            "Receitas de bolo",
            ["Receitas", "Doces", "Culinária", "Rango", "Boia", "Rala Bucho"],
            "Rita Lobo"
        );

        //livro1.mostrarInformacoes();

        Material livro2 = new Material
        (
            "As crônicas de Gelo e Fogo",
            ["Fantasia", "Aventura", "Guerra"],
            "George R. R. Martin"
        );

        //livro2.mostrarInformacoes();

        Material violaoBiblioteca = new Material
        (
            "Violão Clássico",
            ["Música", "Instrumento", "Material Pedagógico"]
        );

        //violaoBiblioteca.mostrarInformacoes();

        Livro livro3 = new Livro(
            "Crônicas de Nárnia",
            ["Fantasia", "Aventura"],
            "9780064471190",
            767/*,
            "C. S. Lewis",*/
        );

        livro3.mostrarInformacoes();

        Midia daniel = new Midia(
            "ser vivo",
            ["garoto", "de"],
            "60",
            "5",
            "Daniel"
        );

        daniel.mostrarInformacoes();
    }
}
