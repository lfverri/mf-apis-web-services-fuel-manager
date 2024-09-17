using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_apis_web_services_fuel_manager.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public decimal Valor { get; set; }

        [Required]
        public tipoCombustivel Tipo { get; set; }

        [Required]
        public int VeiculoId { get; set; } //fk

        public Veiculo Veiculo { get; set; } //navegacao
        public enum tipoCombustivel
        {
            Diesel, //0
            Etanol, //1
            Gasolina //2
        }
    }
}
