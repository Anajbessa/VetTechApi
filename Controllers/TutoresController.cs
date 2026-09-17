using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetTechApi.Data;
using VetTechApi.Model;

namespace VetTechApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutoresController : ControllerBase
    {
      
    private readonly AppDbContext _context;

        public TutoresController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tutor>>> GetTutores()
        {
            return await _context.Tutores.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> CriarTutor(Tutor tutor)
        {
            _context.Tutores.Add(tutor);
            await _context.SaveChangesAsync();

            return Ok("Tutor salvo com sucesso!!");
        }
    }
}
