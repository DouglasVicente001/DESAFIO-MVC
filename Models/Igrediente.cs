namespace VirtualMagazine.Models
{
    public class Igrediente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Receita Receita {get ; set; }
        public UnidadeDeMedida UnidadeDeMedida {get; set; }
        public int Medicao { get; set; }
        public bool Status { get; set; }
    }
}