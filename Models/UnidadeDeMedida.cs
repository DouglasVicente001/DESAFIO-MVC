namespace VirtualMagazine.Models
{
    public class UnidadeDeMedida
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
        public Receita Receita {get ; set; }
        
    }
}