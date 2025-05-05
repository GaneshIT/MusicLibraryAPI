using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLibraryBusiness.Services;
using MusicLibraryEntity;

namespace MusicLibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _albumService;
        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }
        [HttpPost]
        public IActionResult Create(Album album)
        {
            _albumService.Create(album);//Calling business
            return Ok(album);//return http response
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            //calling business
            List<Album> albums = _albumService.GetAll();
            return Ok(albums);//http response
        }

        [HttpPut]//expects URL parameter along with data
        public IActionResult Update(Album album, int id)
        {
            _albumService.Update(album);//calling business
            return Ok(album);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _albumService.Delete(id);//calling business
            var result = new { message = "Deleted" };
            return Ok(result);
        }

        [HttpGet("GetAlbum")]
        public IActionResult Get(int id)
        {
            Album album = _albumService.GetById(id);
            if (album != null)
                return Ok(album);
            return NotFound();
        }
    }
}
