using GloboClima.Domain.Weather;
using GloboClima.Repository;
using GloboClima.Repository.ClassFirstCode;
using Microsoft.AspNetCore.Mvc;

namespace GloboClima.WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class FavoriteController : ControllerBase
    {
        public readonly FavoriteContext _context;
        public FavoriteController(FavoriteContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public ActionResult<List<Favorite>> Get()
        {
            try
            {
                return Ok(_context.Favorite.ToList().OrderByDescending(x=>x.id));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Favorite> GetById([FromRoute] int? id)
        {
            try
            {
                return Ok(new Favorite() { });
            }
            catch (Exception)
            {
                return BadRequest(_context.Favorite.Where(x => x.id == id).FirstOrDefault());
            }
        }

        [HttpPost("")]
        public bool Post([FromBody] Favorite? favorite)
        {
            try
            {
                _context.Favorite.Add(favorite);
                var r = _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int? id)
        {
            try
            {
                var pessoa = _context.Favorite.Where(x => x.id == id).FirstOrDefault();
                _context.Favorite.Remove(pessoa);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return BadRequest(false);
            }
        }

        [HttpPut("")]
        public bool Put([FromBody] Favorite favorite)
        {
            try
            {
                var favoriteContext = _context.Favorite.Where(x => x.id == favorite.id).FirstOrDefault();
                favoriteContext.city = favorite.city;
                favoriteContext.date = favorite.date;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
