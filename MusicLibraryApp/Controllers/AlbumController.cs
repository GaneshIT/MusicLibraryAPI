using Microsoft.AspNetCore.Mvc;
using MusicLibraryEntity;
using Newtonsoft.Json;
using System.Text;

namespace MusicLibraryApp.Controllers
{
    public class AlbumController : Controller
    {

        //GET
        public IActionResult Index()
        {
            return View();
        }
        //GET
        public async Task<IActionResult> GetAlbums()
        {
            IEnumerable<Album> albums = null;
            string apiURL = "http://localhost:5273/api/Album";
            using (HttpClient client = new HttpClient())
            {
                var response =await client.GetAsync(apiURL);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    albums = JsonConvert.DeserializeObject<IEnumerable<Album>>(result);
                }
            }
            return View(albums);//it returns the html view/page
        }

        public IActionResult EditAlbum(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        //GET
        public IActionResult Create()
        {
            ViewBag.status = "";
            ViewBag.message = "";
            return View();
        }
        [HttpPost]
        public IActionResult Create(Album album)
        {
            //Consume API
            StringContent content = new StringContent
                (JsonConvert.SerializeObject(album), 
                Encoding.UTF8, "application/json");
            string apiURL = "http://localhost:5273/api/Album";
            using (HttpClient client = new HttpClient())
            {
                var response=client.PostAsync(apiURL, content);
                if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    ViewBag.status = "Ok";
                    ViewBag.message = "Saved";
                }
                else
                {
                    ViewBag.status = "Error";
                    ViewBag.message = "Invalid";
                } 
            }
            return View();
        }
    }
}
