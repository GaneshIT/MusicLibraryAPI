using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLibraryEntity;

namespace MusicLibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumTestController : ControllerBase
    {
       public static List<Album> albums = new List<Album>()
        {
            new Album{Id=1,Name="A",Description="Test 1"},
            new Album{Id=2,Name="B",Description="Test 2"},
            new Album{Id=3,Name="C",Description="Test 3"},
            new Album{Id=4,Name="D",Description="Test 4"},
            new Album{Id=5,Name="E",Description="Test 5"},
        };

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(albums);
        }

        [HttpGet("Get")]
        public IActionResult GetAlbum(int id)
        {
            foreach (var item in albums)
            {
                if (item.Id == id)
                    return Ok(item);
            }
            return NotFound(new {statusCode=404,
                                 message="No data found"});
        }

        [HttpPost("CreateAlbum")]
        public IActionResult Create(Album album)
        {
            albums.Add(album);
            return Ok(); 
        }

        [HttpPut]
        public IActionResult Update(Album album)
        {
            foreach (var item in albums)
            {
                if (item.Id == album.Id)
                {
                    //OldVal=NewValue
                    item.Id = album.Id;
                    item.Name = album.Name;
                    item.Description = album.Description;
                    return Ok(new { message = "Updated" });
                }
            }
            return BadRequest(new {message="Invalid"});
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            foreach (var item in albums)
            {
                if (item.Id == id)
                {
                    albums.Remove(item);
                    return Ok(new { message = "Deleted" });
                }
            }
            return BadRequest(new { message = "Invalid" });
        }
    }
}


