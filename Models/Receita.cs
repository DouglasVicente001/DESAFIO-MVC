namespace VirtualMagazine.Models
{
    public  class Receita
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ModoPreparo{ get; set; }
        public string TempoPreparo { get; set; }
        public bool Status { get; set; }
        public string Imagem { get; set; }

        
    }
}