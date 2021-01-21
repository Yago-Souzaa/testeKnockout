using System.Data.Entity;
using testeKnockout.Models;

namespace testeKnockout.Controllers
{
    public class ProdutoContex : DbContext
    {
        public ProdutoContex() : base("ProjetoKnockout") { }
        public DbSet<Produtos> Produtos { get; set; }
    }
}