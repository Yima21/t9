using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TareaFinal.Modelos
{
    [Table("tblReligiones")]
    public class Religion
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es obligatorio.")]
        [StringLength(50, ErrorMessage = "max 50 caracteres.")]
        public string Nombre { get; set; }

        public bool Inactivo { get; set; }
    }
}
