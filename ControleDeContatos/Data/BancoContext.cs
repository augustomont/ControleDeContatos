using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos.Data
{
    public class BancoContext : DbContext //Nome padrao DbContext
    {
        //Construtor padrão
        public BancoContext(DbContextOptions<BancoContext> options) : base (options) //DbContextOptions como Parametro de entrada , e tipar ele dentro da propria classe <BancoContext>, nomear de options, depois passar essa informação do options pra dentro do DbContext = :base(options)
        {
        }
        public DbSet<ContatoModel> Contatos { get; set; } //Contexto puxando a Model (ContatoModel). Coloca o nome da tabela com o mesmo nome da Model(Contato)
    }
}
