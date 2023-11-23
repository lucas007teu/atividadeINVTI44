using System.ComponentModel.DataAnnotations;

namespace WebTeste007.Models
{
    public class Inventario
    {
        [Key]
        public int idInvt { get; set; }
        public int idClientes { get; set; }
        public int idMaquinas { get; set; }
        public string Qtd { get; set; }
    }
}
