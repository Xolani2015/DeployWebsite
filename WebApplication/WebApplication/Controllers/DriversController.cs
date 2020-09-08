using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class DriversController : Controller, IDisposable
    {
        private readonly IHttpClientFactory _clientFactory;
        public IEnumerable<Driver> Drivers { get; set; }
        const string BASE_URL = "https://taxiclubapi.herokuapp.com/public";
        public DriversController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/alldrivers");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Drivers = await JsonSerializer.DeserializeAsync<IEnumerable<Driver>>(responseStream);
            }
            else
            {
                Drivers = Array.Empty<Driver>();
            }
            return View(Drivers);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public async Task<IActionResult> Profile(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/driver/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Driver Passenger = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Passenger = await JsonSerializer.DeserializeAsync<Driver>(responseStream);
            }

            if (Passenger == null)
                return NotFound();

            return View(Passenger);
        }

        public async Task<IActionResult> NoVehicleFound(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/driver/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Driver Passenger = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Passenger = await JsonSerializer.DeserializeAsync<Driver>(responseStream);
            }

            if (Passenger == null)
                return NotFound();

            return View(Passenger);
        }

        public async Task<IActionResult> Vehicle(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/drivervehicle/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Driver Passenger = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Passenger = await JsonSerializer.DeserializeAsync<Driver>(responseStream);
            }

            if (Passenger == null)
                return NotFound();

            return View(Passenger);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name, Surname, Gender, Email, Cell, DriverType")] Driver driver)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(driver), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Post;
                message.RequestUri = new Uri($"{BASE_URL}/createdriver");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(driver);
        }

        public async Task<IActionResult> Details(int id)
        {

            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/driver/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Driver driver = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                driver = await JsonSerializer.DeserializeAsync<Driver>(responseStream);
            }

            if (driver == null)
                return NotFound();

            return View(driver);
        }


        public async Task<IActionResult> Delete(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/driver/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Driver driver = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                driver = await JsonSerializer.DeserializeAsync<Driver>(responseStream);
            }

            if (driver == null)
                return NotFound();
            return View(driver);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Delete;
            message.RequestUri = new Uri($"{BASE_URL}/deletedriver/{id}");

            HttpClient client = _clientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(message);
            var result = await response.Content.ReadAsStringAsync();
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> List()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/alldrivers");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Drivers = await JsonSerializer.DeserializeAsync<IEnumerable<Driver>>(responseStream);
            }
            else
            {
                Drivers = Array.Empty<Driver>();
            }
            return View(Drivers);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string Email)
        {
            if (Email == null)
                return NotFound();

            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/driver/{Email}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);

            Driver driver = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                driver = await JsonSerializer.DeserializeAsync<Driver>(responseStream);
            }

            if (driver == null)
                return NotFound();

            return View(driver);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("Name, Surname, Gender, Email, Cell, DriverType")] Driver driver)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(driver), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Post;
                message.RequestUri = new Uri($"{BASE_URL}/createdriver");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));
            }
            return View(driver);
        }

    }
}

