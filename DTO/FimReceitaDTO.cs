using System.ComponentModel.DataAnnotations;

namespace TesteMVCTraining.DTO
{
    public class FimReceitaDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="Nome da unidade de medida é obrigatória")]
        [StringLength(100, ErrorMessage ="Nome da unidade de medida tem que ter menos de 100 caracteres")]
        [MinLength(2,ErrorMessage ="O nome da unidade de medida é muito curto")]
        public string Nome { get; set; }
        public bool Status { get; set; }
    }
}