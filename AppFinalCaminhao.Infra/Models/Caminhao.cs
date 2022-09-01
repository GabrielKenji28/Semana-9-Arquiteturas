using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AppFinalCaminhao.Infra.Models.Enums.EnumModelo;

namespace AppFinalCaminhao.Infra.Models
{
    
    public class Caminhao
    {        
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome não pode ser nulo ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Descricao não pode ser nulo ")]
        public string Descricao { get; set; }
        
        [Required(ErrorMessage = "Data não pode ser nulo ")]
        public string DataCriacao { get; set; }

        [Required(ErrorMessage ="Modelo não pode ser nulo")]
        public Modelos Modelo { get; set; }
    }
}
