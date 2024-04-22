namespace livraria;

class Program
public class Livro
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
public string Titulo { get; set; }
public string Autor { get; set; }
public string ISBN { get; set; }
public int QuantidadeEmEstoque { get; set; }

public Livro(string titulo, string autor, string isbn, int quantidadeEmEstoque)
{
Titulo = titulo;
Autor = autor;
ISBN = isbn;
QuantidadeEmEstoque = quantidadeEmEstoque;
}

public void AdicionarEstoque(int quantidade)
{
QuantidadeEmEstoque += quantidade;
}

public void Vender(int quantidade)
{
if (QuantidadeEmEstoque >= quantidade)
{
QuantidadeEmEstoque -= quantidade;
}
else
{
Console.WriteLine("Estoque insuficiente para realizar a venda.");
}
}
}

public class LivroDigital : Livro
{
public string FormatoArquivo { get; set; }

public LivroDigital(string titulo, string autor, string isbn, int quantidadeEmEstoque, string formatoArquivo)
: base(titulo, autor, isbn, quantidadeEmEstoque)
{
FormatoArquivo = formatoArquivo;
}
}