namespace JGCPhoneList.WebUI.Controllers
{
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    using JGCPhoneList.Domain.Entities;
    using JGCPhoneList.Persistence;

    [Route("api/[controller]")]
    [ApiController]
    public class PhonesController : ControllerBase
    {
        private readonly IJgcPhoneListDbContext _context;

        public PhonesController(IJgcPhoneListDbContext context)
        {
            _context = context;
        }

        // GET: api/Phones
        [HttpGet]
        public async Task<IEnumerable<Phone>> GetPhones()
        {
            var result = await _context.Phones
                .Include(p => p.OperativeSystem)
                .Include(p => p.Manufacturer)
                .Include(p => p.PhoneColors)
                .Include(p => p.PhoneImages)
                    .ThenInclude(pi => pi.Image)
                .Include(p => p.PhoneColors)
                    .ThenInclude(pi => pi.Color)
                .ToListAsync();

            return result;
        }

        // GET: api/Phones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Phone>> GetPhone(int id)
        {
            var phone = await _context.Phones
                .Include(p => p.OperativeSystem)
                .Include(p => p.Manufacturer)
                .Include(p => p.PhoneColors)
                .Include(p => p.PhoneImages)
                .ThenInclude(pi => pi.Image)
                .Include(p => p.PhoneColors)
                .ThenInclude(pi => pi.Color)
                .SingleOrDefaultAsync(p => p.PhoneId == id);
                
            if (phone == null)
            {
                return NotFound();
            }

            return phone;
        }

        // PUT: api/Phones/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhone(int id, Phone phone)
        {
            if (id != phone.PhoneId)
            {
                return BadRequest();
            }

            _context.Entry<Phone>(phone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhoneExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Phones
        [HttpPost]
        public async Task<ActionResult<Phone>> PostPhone(Phone phone)
        {
            _context.Phones.Add(phone);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPhone", new { id = phone.PhoneId }, phone);
        }

        // DELETE: api/Phones/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Phone>> DeletePhone(int id)
        {
            var phone = await _context.Phones.FindAsync(id);
            if (phone == null)
            {
                return NotFound();
            }

            _context.Phones.Remove(phone);
            await _context.SaveChangesAsync();

            return phone;
        }

        private bool PhoneExists(int id)
        {
            return _context.Phones.Any(e => e.PhoneId == id);
        }
    }
}
