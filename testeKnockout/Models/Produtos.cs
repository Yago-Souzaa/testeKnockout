using System.ComponentModel.DataAnnotations.Schema;

namespace testeKnockout.Models
{
    [Table("Produtos")]
    public class Produtos
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
    }
}