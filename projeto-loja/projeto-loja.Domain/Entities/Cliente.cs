namespace projeto_loja.Domain.Entities

{

    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}