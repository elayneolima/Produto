using System.Globalization; 
using Curso; 

Produto produto = new Produto();

Console.WriteLine("Entre com o nome do produto");

produto.Nome = Console.ReadLine(); 
Console.WriteLine("Entre com o preço do produto");

produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com a quantidade do produto");
produto.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados do produto: " + produto); 



