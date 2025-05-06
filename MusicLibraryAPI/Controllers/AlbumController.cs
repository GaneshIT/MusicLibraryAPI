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
        ILogger<AlbumController> _logger;
        public AlbumController(IAlbumService albumService,
            ILogger<AlbumController> logger)
        {
            _albumService = albumService;
            _logger = logger;
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
            _logger.LogInformation("Get Albums");
            //calling business
            List<Album> albums = _albumService.GetAll();
            _logger.LogInformation("Retrieved albums");
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
