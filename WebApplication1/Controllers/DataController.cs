using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.conf;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
   
    public class DataController : Controller
    {
        private readonly myAppconff _context;

        public DataController(myAppconff context)

        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var datas = _context.Datas.ToList();
                if (datas.Count == 0)
                {
                    return NotFound("data is not available.");
                }
                return Ok(datas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        [HttpGet("ID")]
        public IActionResult Get(int ID)
        {
            try
            {
                var data = _context.Datas.Find(ID);

                if (data == null)
                {
                    return NotFound($"data is not available{ID} ");
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPost]
        public IActionResult post(Datas Models)
        {
            try
            {
                _context.Add(Models);
                _context.SaveChanges();
                return Ok("data Create okk");
            }


            catch (Exception ex)
            {

                return BadRequest(ex.Message);

            }

        }



    }
}
