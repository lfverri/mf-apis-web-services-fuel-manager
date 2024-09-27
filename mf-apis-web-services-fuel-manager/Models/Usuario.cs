using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace mf_apis_web_services_fuel_manager.Models
{
    [Table("Usuario")]
    public class Usuario 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [JsonIgnore]
        public string Password { get; set;}

       public Perfil Perfil { get; set;}

        public ICollection<VeiculoUsuarios> Veiculos { get; set;}
    }

    public enum Perfil
    {
        [Display (Name = "Administrador")]
        Admistrador,

        [Display (Name ="Usuario")]
        Usuario
    }
}
