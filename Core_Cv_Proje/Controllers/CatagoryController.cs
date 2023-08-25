using Core_Cv_Proje.DAL.ApiContext;
using Core_Cv_Proje.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_Cv_Proje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatagoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            using var c = new Context();
            return Ok(c.Catagories.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult CategoryGet(int id)
        {
            using var c = new Context();
            var value = c.Catagories.Find(id);
            if(value == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }
        }
        [HttpPost]
        public IActionResult CategoryAdd(Catagory p)
        {
            var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("", p);
        }
        [HttpDelete]
        public IActionResult CategoryDelete(int id)
        {
            using var c = new Context();
            var value = c.Catagories.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(value);
                c.SaveChanges();
                return NoContent();
            }
        }
        [HttpPut]
        public IActionResult CategoryUpdate(Catagory p)
        {
            using var c = new Context();
            var value = c.Find<Catagory>(p.CatagoryID);
            if(value == null)
            {
                return NotFound();
            }
            else
            {
                value.CatagoryName = p.CatagoryName;
                c.Update(value);
                c.SaveChanges();
                return NoContent();

            }

        }

    }
}
