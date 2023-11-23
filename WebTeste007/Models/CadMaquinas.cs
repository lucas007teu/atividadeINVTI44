using System.ComponentModel.DataAnnotations;

namespace WebTeste007.Models
{
    public class CadMaquinas
    {
        [Key]
        public int idMaquinas { get; set; }
        public string Maquina { get; set; }
    }
}
