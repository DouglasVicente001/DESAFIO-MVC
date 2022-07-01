using System.ComponentModel.DataAnnotations;

namespace VirtualMagazine.DTO
{
    public class IgredienteDTO
    {   
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="Nome do igrediente é obrigatório")]
        [MinLength(2, ErrorMessage ="Nome de igrediente muito pequeno, tente um nome com mais de dois caracteres")]
        public string Nome { get; set; }
        public bool Status { get; set; }
        public int ReceitaId {get ; set; }
        public string  ModoPreparo { get; set; }
        
    }
}