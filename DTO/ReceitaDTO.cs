using System.ComponentModel.DataAnnotations;

namespace VirtualMagazine.DTO
{
    public class ReceitaDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="Nome de receita é obrigatório")]
        [StringLength(100, ErrorMessage ="Nome de receita muito grande, tente nome menor")]
        [MinLength(2, ErrorMessage ="Nome de receita muito pequena, tente um nome com mais de dois caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Modo de preparo é obriatório")]
        public string ModoPreparo { get; set; }
        public string TempoPreparo { get; set; }
        
        
    }
}