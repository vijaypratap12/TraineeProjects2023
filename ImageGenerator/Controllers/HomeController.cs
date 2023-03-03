using ImageGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OpenAIImageGenerater.Models;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;

namespace ImageGenerator.Controllers
{
    public class HomeController : Controller
    {
        string APIKEY = string.Empty;
        public HomeController(IConfiguration conf)
        {
            // _logger = logger;
            APIKEY = conf.GetSection("OPENAI_API_KEY").Value;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GenerateImage([FromBody] Input input)
        {
            string imglink = string.Empty;
            var resp = new ResponseModel();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", APIKEY);
                var Message = await client.PostAsync("https://api.openai.com/v1/images/generations", new StringContent(JsonConvert.SerializeObject(input), Encoding.UTF8, "application/json"));
                if (Message.IsSuccessStatusCode)
                {
                    var content = await Message.Content.ReadAsStringAsync();
                    resp = JsonConvert.DeserializeObject<ResponseModel>(content);
                    imglink = resp.data[0].url.ToString();
                }
            }
            return Json(resp);
        }


        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}