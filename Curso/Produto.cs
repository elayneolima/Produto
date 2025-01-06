using System.Globalization; 

namespace Curso
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade; 

        public double ValorTotalEmEstoque() 
        {
            return Quantidade * Preco;         
        }

        public void ProdutoEntrada(int quantidade) 
        {
            Quantidade += quantidade;
        
        }

        public void ProdutoSaida(int quantidade) 
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);


        }

    }
}
