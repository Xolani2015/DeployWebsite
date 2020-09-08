using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
    public class TripsController : Controller, IDisposable
    {
        private readonly IHttpClientFactory _clientFactory;
        public IEnumerable<Trip> Trips { get; set; }
        const string BASE_URL = "https://taxiclubapi.herokuapp.com/public";
        public TripsController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/findall");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Trips = await JsonSerializer.DeserializeAsync<IEnumerable<Trip>>(responseStream);
            }
            else
            {
                Trips = Array.Empty<Trip>();
            }
            return View(Trips);
        }

        public IActionResult Create()
        {
            return View();
        }

       public async Task DynamicList()
       {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/findall");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                IEnumerable<Trip> displaylist;
                displaylist = await JsonSerializer.DeserializeAsync<IEnumerable<Trip>>(responseStream);
            }  
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name, Surname, Gender, Email, Cell, TripType")] Trip Trip)
        {
           

            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Trip), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Post;
                message.RequestUri = new Uri($"{BASE_URL}/createTrip");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Trip);
        }

        public async Task<IActionResult> Details(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/trip/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Trip Trip = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Trip = await JsonSerializer.DeserializeAsync<Trip>(responseStream);
            }

            if (Trip == null)
                return NotFound();

            return View(Trip);
        }

        public async Task<IActionResult> Detailss(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/tripwithnodriver/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Trip Trip = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Trip = await JsonSerializer.DeserializeAsync<Trip>(responseStream);
            }

            if (Trip == null)
                return NotFound();

            return View(Trip);
        }

        public async Task<IActionResult> Delete(int id)
        {
         
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/trip/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Trip Trip = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Trip = await JsonSerializer.DeserializeAsync<Trip>(responseStream);
            }

            if (Trip == null)
                return NotFound();

            return View(Trip);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Delete;
            message.RequestUri = new Uri($"{BASE_URL}/deletetrip/{id}");

            HttpClient client = _clientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(message);
            var result = await response.Content.ReadAsStringAsync();
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
                return NotFound();

            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/trip/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);

            Trip Trip = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Trip = await JsonSerializer.DeserializeAsync<Trip>(responseStream);
            }

            if (Trip == null)
                return NotFound();

            return View(Trip);
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddTrip([Bind("PickUpArea, DropOffArea, ArrivalTime, DepartureTime")] Trip Trip)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Trip), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Post;
                message.RequestUri = new Uri($"{BASE_URL}/createtrip");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);
                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));
            }
            return View(Trip);
        }

        public IActionResult AddTrip()
        {
            return View();
        }



        public async Task<IActionResult> Driver(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/trip/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Trip Passenger = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Passenger = await JsonSerializer.DeserializeAsync<Trip>(responseStream);
            }

            if (Passenger == null)
                return NotFound();

            return View(Passenger);
        }

        public async Task<IActionResult> NoDriverFound(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/tripwithnodriver/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Trip Passenger = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Passenger = await JsonSerializer.DeserializeAsync<Trip>(responseStream);
            }

            if (Passenger == null)
                return NotFound();

            return View(Passenger);
        }

        public async Task<IActionResult> Assign(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/trip/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Trip Passenger = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Passenger = await JsonSerializer.DeserializeAsync<Trip>(responseStream);
            }

            if (Passenger == null)
                return NotFound();

            return View(Passenger);
        }


        public async Task<IActionResult> AssignNew(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/tripwithnodriver/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Trip Passenger = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Passenger = await JsonSerializer.DeserializeAsync<Trip>(responseStream);
            }

            if (Passenger == null)
                return NotFound();

            return View(Passenger);
        }

        public async Task<IActionResult> RemoveDriver(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/trip/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Trip Passenger = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Passenger = await JsonSerializer.DeserializeAsync<Trip>(responseStream);
            }

            if (Passenger == null)
                return NotFound();

            return View(Passenger);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveDriver(int id, [Bind("")] Trip passenger)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(passenger), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/Unassigndrivertotrip/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(passenger);
        }



        [HttpPost]
        public async Task<IActionResult> Assign(int id, [Bind("Name")] Trip passenger)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(passenger), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/assigndrivertotrip/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(passenger);
        }

        [HttpPost]
        public async Task<IActionResult> AssignNew(int id, [Bind("Name")] Trip passenger)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(passenger), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/assigndrivertotrip/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(passenger);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("PickUpArea, DropOffArea, DriverName, Bill, ArrivalTime, DepartureTime")] Trip Trip)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Trip), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Post;
                message.RequestUri = new Uri($"{BASE_URL}/createtrip");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);
                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));
            }
            return View(Trip);
        }

        public async Task<IActionResult> List()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/alltrips");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Trips = await JsonSerializer.DeserializeAsync<IEnumerable<Trip>>(responseStream);
            }
            else
            {
                Trips = Array.Empty<Trip>();
            }
            return View(Trips);
        }
    }
}

