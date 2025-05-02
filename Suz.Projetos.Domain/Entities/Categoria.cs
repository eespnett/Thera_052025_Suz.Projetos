namespace Suz.Projetos.Domain.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string DescricaoCategoria { get; set; }
        public SubCategoria SubCategoria { get; set; }


        // Categoria
    }
}
