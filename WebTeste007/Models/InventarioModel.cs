using System.ComponentModel.DataAnnotations;

namespace WebTeste007.Models
{
    public class InventarioModel : Cadclientes
    {
        [Key]
        public int idInvt { get; set; }
        public int idClientes { get; set; }
        public int idMaquinas { get; set; }
        public string Qtd { get; set; }
        public List<Cadclientes> ClientesLista { get; set; }
        public List<CadMaquinas> MaquinasLista { get; set; }
    }
}
