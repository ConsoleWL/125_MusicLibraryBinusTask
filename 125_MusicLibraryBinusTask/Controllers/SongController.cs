﻿using _125_MusicLibraryBinusTask.Data;
using _125_MusicLibraryBinusTask.Model;
using Azure;
using Microsoft.AspNetCore.JsonPatch;
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
        public IActionResult Get()
        {
            List<Song> songs = _context.Songs.ToList();
            return Ok(songs);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Song song = _context.Songs.FirstOrDefault(f => f.Id == id);

            if (song is null)
                return NotFound();

            return Ok(song);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Song song)
        {
            if (song is null)
                return BadRequest(400);

            _context.Songs.Add(song);
            _context.SaveChanges();
            return Ok(song);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Song newSong)
        {
            Song? song = _context.Songs.FirstOrDefault(f => f.Id == id);

            if (song is null)
                return NotFound($"Not Found Song with this {id}");

            song.Title = newSong.Title;
            song.Artist = newSong.Artist;
            song.Album = newSong.Album;
            song.ReleaseDate = newSong.ReleaseDate;
            song.Genre = newSong.Genre;
            song.Like = newSong.Like;

            _context.SaveChanges();
            return Ok(song);
        } 

        [HttpDelete("{id}")]
        public IActionResult DeleteSong(int id)
        {
            Song? song = _context.Songs.FirstOrDefault(f => f.Id == id);

            if (song is null)
                return NotFound($"Can not find  item with id {id}");

            _context.Songs.Remove(song);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPut("like/{id}")]
        public IActionResult Like(int id)
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
