using _125_MusicLibraryBinusTask.Data;
using _125_MusicLibraryBinusTask.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace _125_MusicLibraryBinusTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SongController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Song()
        {
            List<Song> songs = _context.Songs.ToList();
            return Ok(songs);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Song song = _context.Songs.FirstOrDefault(f => f.Id == id);

            if (song is null)
                return NotFound();

            return Ok(song);
        }

        [HttpPost]
        public IActionResult SongAdd([FromBody]Song song)
        {
            if (song is null)
                return BadRequest(400);

            _context.Songs.Add(song);
            _context.SaveChanges();
            return Ok(song);
        }

        [HttpPut("{id}")]
        public IActionResult SongUpdate(int id, [FromBody] Song newSong)
        {
            Song? song = _context.Songs.Where(f => f.Id == id).FirstOrDefault();

            if (song is null)
                return NotFound($"Not Found Song with this {id}");

            song.Title = newSong.Title;
            song.Artist = newSong.Artist;
            song.Album = newSong.Album;
            song.ReleaseDate = newSong.ReleaseDate;
            song.Genre = newSong.Genre;

            _context.SaveChanges();
            return Ok(song);

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSong(int id)
        {
            Song? song = _context.Songs.FirstOrDefault(f => f.Id == id);

            if (song is null)
                return NotFound($"Not Found Song With id {id}");

            _context.Songs.Remove(song);
            _context.SaveChanges();

            return Ok(song);
        }

        // this is a route for liking a song https://localhost:7043/api/song/3/like
        // I want like this : https://localhost:7043/api/song/like/
        [HttpPut("{id}/like")]
        public IActionResult SongLike(int id)
        {
            Song? song = _context.Songs.FirstOrDefault(f => f.Id == id);

            if (song is null)
                return NotFound();

            song.Like++;
            _context.SaveChanges();
            return Ok(song);
        }
    }
}
