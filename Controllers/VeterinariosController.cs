using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetTechApi.Data;
using VetTechApi.Model;

namespace VetTechApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinariosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VeterinariosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veterinario>>> GetVeterinarios()
        {
            return await _context.Veterinarios.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> CriarVeterinario(Veterinario veterinario)
        {
            _context.Veterinarios.Add(veterinario);
            await _context.SaveChangesAsync();

            return Ok("Veterinário salvo com sucesso!!");
        }
    }
}
