using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TareaFinal.Modelos
{
    [Table("tblEmpleados")]
    public class Empleado
    {
        [Key]
        public int Id { get; set; }

        [StringLength(11, ErrorMessage = "11 caracteres máximo.")]
        public string Codigo { get; set; }

        [StringLength(11, ErrorMessage = "11 caracteres máximo.")]
        public string Cedula { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }


        [Required]
        [StringLength(40, ErrorMessage = "40 caracteres máximo.")]
        public string Nombre { get; set; }

        [StringLength(40, ErrorMessage = "40 caracteres máximo.")]
        public string Apellido { get; set; }

        [StringLength(10, ErrorMessage = "10 caracteres máximo.")]
        public string Sexo { get; set; }


        [StringLength(15, ErrorMessage = "15 caracteres máximo.")]
        public string EstadoCivil { get; set; }

        [StringLength(5, ErrorMessage = "5 caracteres máximo.")]
        public string? TipoSangre { get; set; }


        [StringLength(50, ErrorMessage = "50 caracteres máximo.")]
        public string? Nacionalidad { get; set; }

        [StringLength(50, ErrorMessage = "50 caracteres máximo.")]
        public string Religion { get; set; }

        [StringLength(20, ErrorMessage = "20 caracteres máximo.")]
        public string? Telefono { get; set; }

        [StringLength(50, ErrorMessage = "50 caracteres máximo.")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "100 caracteres máximo.")]
        public string Direccion { get; set; }

        [StringLength(20, ErrorMessage = "20 caracteres máximo.")]
        public string SalarioMensual { get; set; }

        [StringLength(50, ErrorMessage = "50 caracteres máximo.")]
        public string DepartamentoQuePertenece { get; set; }

        [StringLength(40, ErrorMessage = "40 caracteres máximo.")]
        public string NombreContactoEmergencia { get; set; }

        [StringLength(20, ErrorMessage = "20 caracteres máximo.")]
        public string TelefonoEmergencia { get; set; }

        [StringLength(20, ErrorMessage = "20 caracteres máximo.")]
        public string AfpQuePertenece { get; set; }

        [StringLength(20, ErrorMessage = "20 caracteres máximo.")]
        public string ArsQuePertenece { get; set; }

        [StringLength(300, ErrorMessage = "300 caracteres máximo.")]
        public string Observaciones { get; set; }

        public bool Inactivo { get; set; }

    }
}
