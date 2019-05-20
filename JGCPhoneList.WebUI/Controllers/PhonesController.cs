namespace JGCPhoneList.WebUI.Controllers
{
    using JGCPhoneList.Application;
    using JGCPhoneList.Application.Phones.Models;

    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class PhonesController : ControllerBase
    {
        private readonly IJgcPhoneListApplicationContext _context;

        public PhonesController(IJgcPhoneListApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Phones
        [HttpGet]
        public ActionResult<PhoneListDto> GetPhones()
        {
            var result = _context.GetPhoneList();

            return Ok(result);
        }

        // GET: api/Phones/5
        [HttpGet("{id}")]
        public ActionResult<PhoneDetailDto> GetPhone(int id)
        {
            var phone = _context.GetPhoneDetail(id);
            if (phone == null)
            {
                return NotFound();
            }

            return Ok(phone);
        }
    }
}
