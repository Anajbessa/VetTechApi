namespace VetTechApi.Model
{
    public class Pet
    {

        public int id { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public int TutorId { get; set; }

        public ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();
    }
}
