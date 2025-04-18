using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCAPI.Data;
using MVCAPI.Models.Entites;

namespace MVCAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentiController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public StudentiController(ApplicationDbContext context)
        {
            this.dbContext = context;
        }

        [HttpGet]
        // "IEnumerable" è una lista che mi permette di passarlo in formato jason
        public async Task<ActionResult<IEnumerable<Studente>>> GetList()
        {
            var studenti = await dbContext.Studenti.ToListAsync();
            foreach (var riga in studenti) {
                riga.Facolta = dbContext.Facolta.FirstOrDefault(u => u.IdFacolta == riga.IdFacolta);
            }
            return studenti;
        }

    }
}
