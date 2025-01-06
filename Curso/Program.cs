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

Console.WriteLine("Digite o número de produtos a ser adicionado no estoque: ");

// entrada do usuário
int qteAdicionar  = int.Parse(Console.ReadLine());

// recebe o valor de entrada do usuário como parametro para funcao ProdutoEntrada
produto.ProdutoEntrada(qteAdicionar); 

// Basta chamar apenas o objeto produto, com os dados atualizados. 
Console.WriteLine("Dados atualizados" + produto);

Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
 int qteRemover =  int.Parse(Console.ReadLine());
produto.ProdutoSaida(qteRemover);
Console.WriteLine("Dados atualizados" + produto);