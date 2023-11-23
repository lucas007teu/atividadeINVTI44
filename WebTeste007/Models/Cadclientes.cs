using System.ComponentModel.DataAnnotations;

namespace WebTeste007.Models
{
    public class Cadclientes
    {
        [Key]
        public int idClientes { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
    }
}
