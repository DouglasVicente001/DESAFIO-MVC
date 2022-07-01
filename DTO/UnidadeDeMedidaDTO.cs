using System.ComponentModel.DataAnnotations;

namespace VirtualMagazine.DTO
{
    public class UnidadeDeMedidaDTO
    {   
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="Nome da unidade de medida é obrigatória")]
        [MinLength(2,ErrorMessage ="O nome da unidade de medida é muito curto")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Receita é obrigatória")]  
        public int ReceitaId {get ; set; }
        [Required(ErrorMessage ="Unidade de medida é obrigatória")]  
        public int UnidadeDeMedidaId {get; set; }
        [Required(ErrorMessage ="Medição do produto é obrigatória")]  
        [Range(0,2,ErrorMessage ="Medição inválida")]
        public int Medicao { get; set; }
  
        
    }
}