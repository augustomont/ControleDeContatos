namespace ControleDeContatos.Models
{
    public class ContatoModel //Modelo que será salvo dentro do banco de Dados do SQL
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
