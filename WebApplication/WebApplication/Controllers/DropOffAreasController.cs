using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class DropOffAreasController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        public IEnumerable<DropOffAreaModel> DropOffAreas { get; set; }
        const string BASE_URL = "https://taxiclubapi.herokuapp.com/public";
        public DropOffAreasController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> List()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/alldropoff");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                DropOffAreas = await JsonSerializer.DeserializeAsync<IEnumerable<DropOffAreaModel>>(responseStream);
            }
            else
            {
                DropOffAreas = Array.Empty<DropOffAreaModel>();
            }
            return View(DropOffAreas);
        }

        public async Task<IActionResult> Details(int id)
        {

            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/dropoff/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            DropOffAreaModel DropOffAreas = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                DropOffAreas = await JsonSerializer.DeserializeAsync<DropOffAreaModel>(responseStream);
            }

            if (DropOffAreas == null)
                return NotFound();

            return View(DropOffAreas);
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("DropOffArea, TimeArrival, TimeDepature, DriverID")] DropOffAreaModel DropOffAreaModel)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(DropOffAreaModel), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Post;
                message.RequestUri = new Uri($"{BASE_URL}/createdropoffarea");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));
            }
            return View(DropOffAreaModel);
        }
    }
}
