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
    public class PickUpAreasController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        public IEnumerable<PickUpAreaModel> PickUpAreas { get; set; }
        public object PickUpAreasModel { get; private set; }

        const string BASE_URL = "https://taxiclubapi.herokuapp.com/public";
        public PickUpAreasController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> List()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/allpickup");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                PickUpAreas = await JsonSerializer.DeserializeAsync<IEnumerable<PickUpAreaModel>>(responseStream);
            }
            else
            {
                PickUpAreas = Array.Empty<PickUpAreaModel>();
            }
            return View(PickUpAreas);
        }


        public async Task<IActionResult> Details(int id)
        {

            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/pickup/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            PickUpAreaModel  PickUpAreas = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                PickUpAreas = await JsonSerializer.DeserializeAsync<PickUpAreaModel>(responseStream);
            }

            if (PickUpAreas == null)
                return NotFound();

            return View(PickUpAreas);
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("PickUpArea, TimeArrival, TimeDepature, DriverID")] PickUpAreaModel PickUpAreaModel)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(PickUpAreaModel), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Post;
                message.RequestUri = new Uri($"{BASE_URL}/createpickuparea");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));
            }
            return View(PickUpAreaModel);
        }

    }
}
