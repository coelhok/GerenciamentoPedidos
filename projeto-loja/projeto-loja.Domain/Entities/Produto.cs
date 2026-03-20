namespace projeto_loja.Domain.Entities
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public int quantidadeEstoque { get; set; }
    }

}

   