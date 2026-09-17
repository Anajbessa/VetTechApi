using System.Text.Json.Serialization;

namespace VetTechApi.Model
{
    public class Veterinario
    {
            public int id { get; set; }
            public string Nome { get; set; }
            public string CMRV { get; set; }
            public string Especialidade { get; set; }

            public ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();
    }
}
