namespace LojaEstoqueApi.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Estoque { get; set; }
    }
}