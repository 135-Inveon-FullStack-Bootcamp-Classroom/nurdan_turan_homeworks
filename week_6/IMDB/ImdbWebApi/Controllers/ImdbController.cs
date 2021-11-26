using Microsoft.AspNetCore.Mvc;
using ImdbWebApi.DBOperations;


namespace ImdbWebApi.AddControllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImdbController : ControllerBase
    {
        private readonly ImdbStoreDBContext _context;

        public ImdbController(ImdbStoreDBContext context)
        {
            _context = context;
        }
                                                          
        [HttpGet]
        public List<Imdb> GetAllImdbs()
        {
            var ImdbList = _context.Imdbs.OrderBy(b => b.Id).ToList<Imdb>();
            return ImdbList;
        }

        [HttpPost]
        public IActionResult AddImdb([FromBody] Imdb newImdb)
        {
            var Imdb = _context.Imdbs.SingleOrDefault(b => b.Title == newImdb.Title);
            if (Imdb is not null)
            {
                return BadRequest();
            }
            _context.Imdbs.Add(newImdb);
            _context.SaveChanges(); //Her değişiklik sonra db'ye kaydedilir.
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateImdb(int id, [FromBody] Imdb updatedImdb)
        {
            var Imdb = _context.Imdbs.SingleOrDefault(b => b.Id == updatedImdb.Id);
            if (Imdb is null)
            {
                return BadRequest();
            }
            Imdb.Title = updatedImdb.Title != default ? updatedImdb.Title : Imdb.Title;
            Imdb.Director = updatedImdb.Director != default ? updatedImdb.Director : Imdb.Director;
            Imdb.Genre = updatedImdb.Genre != default ? updatedImdb.Genre : Imdb.Genre;
            Imdb.Actors = updatedImdb.Actors != default ? updatedImdb.Actors : Imdb.Actors;
            Imdb.Language = updatedImdb.Language != default ? updatedImdb.Language : Imdb.Language;
            Imdb.imdbID = updatedImdb.imdbID != default ? updatedImdb.imdbID : Imdb.imdbID;
            Imdb.imdbRating = updatedImdb.imdbRating != default ? updatedImdb.imdbRating : Imdb.imdbRating;
            Imdb.imdbVotes = updatedImdb.imdbVotes != default ? updatedImdb.imdbVotes : Imdb.imdbVotes;
            Imdb.Type = updatedImdb.Type != default ? updatedImdb.Type : Imdb.Type;
            Imdb.Writer = updatedImdb.Writer != default ? updatedImdb.Writer : Imdb.Writer;
            Imdb.Country = updatedImdb.Country != default ? updatedImdb.Country : Imdb.Country;
            Imdb.Rated = updatedImdb.Rated != default ? updatedImdb.Rated : Imdb.Rated;
          
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteImdb(int id)
        {
            var Imdb = _context.Imdbs.SingleOrDefault(b => b.Id == id);
            if (Imdb is null)
            {
                return BadRequest();
            }
            _context.Imdbs.Remove(Imdb);
            _context.SaveChanges();
            return Ok();
        }
    }
}
