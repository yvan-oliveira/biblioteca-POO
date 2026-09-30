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

        livro1.mostrarInformacoes();

        Material livro2 = new Material
        (
            "As crônicas de Gelo e Fogo",
            ["Fantasia", "Aventura", "Guerra"],
            "George R. R. Martin"
        );

        livro2.mostrarInformacoes();

        Material violaoBiblioteca = new Material
        (
            "Violão Clássico",
            ["Música", "Instrumento", "Material Pedagógico"]
        );

        violaoBiblioteca.mostrarInformacoes();
    }
}
