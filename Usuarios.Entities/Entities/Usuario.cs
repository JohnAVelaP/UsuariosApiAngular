using System.ComponentModel.DataAnnotations;

namespace Usuarios.Entities.Entities
{
    public class Usuario
    {
        [Key]
        public decimal UsuID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
    }
}
