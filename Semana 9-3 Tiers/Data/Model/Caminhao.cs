using AppFinalCaminhao.Semana_9_3_Tiers.Data.Model;
using System.ComponentModel.DataAnnotations;

namespace AppFinalCaminhao.Models
{
    public class Caminhao
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nome não pode ser nulo ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Descricao não pode ser nulo ")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Data não pode ser nulo ")]
        public string DataCriacao { get; set; }

        [Required(ErrorMessage ="Modelo é obrigatório ")]        
        public EnumModelo Modelo { get; set; }
    }
}
