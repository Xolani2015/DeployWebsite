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
    public class TestController : Controller, IDisposable
    {
        private readonly IHttpClientFactory _clientFactory;
        public IEnumerable<Passenger> Passengers { get; set; }
        public IEnumerable<Trip> Trips { get; set; }
        const string BASE_URL = "http://localhost/taxiclubapi/public";
        public TestController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/allPassengers");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Passengers = await JsonSerializer.DeserializeAsync<IEnumerable<Passenger>>(responseStream);
            }
            else
            {
                Passengers = Array.Empty<Passenger>();
            }
            return View(Passengers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name, Surname, Gender, Email, Cell, PassengerType")] Passenger Passenger)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Passenger), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Post;
                message.RequestUri = new Uri($"{BASE_URL}/createPassenger");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Passenger);
        }

        public async Task<IActionResult> Profile(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/passenger/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Passenger Passenger = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Passenger = await JsonSerializer.DeserializeAsync<Passenger>(responseStream);
            }

            if (Passenger == null)
                return NotFound();

            return View(Passenger);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/passenger/{id}");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            Passenger Passenger = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Passenger = await JsonSerializer.DeserializeAsync<Passenger>(responseStream);
            }
            return View(Passenger);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Delete;
            message.RequestUri = new Uri($"{BASE_URL}/deletepassenger/{id}");

            HttpClient client = _clientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(message);
            var result = await response.Content.ReadAsStringAsync();
            return RedirectToAction(nameof(List));
        }

        /*[HttpGet]
          public async Task<IActionResult> Edit(int id)
          {
              if (id == null)
                  return NotFound();

              var message = new HttpRequestMessage();
              message.Method = HttpMethod.Get;
              message.RequestUri = new Uri($"{BASE_URL}/Passenger/{id}");
              message.Headers.Add("Accept", "application/json");
              var client = _clientFactory.CreateClient();
              var response = await client.SendAsync(message);

              Passenger Passenger = null;

              if (response.IsSuccessStatusCode)
              {
                  using var responseStream = await response.Content.ReadAsStreamAsync();
                  Passenger = await JsonSerializer.DeserializeAsync<Passenger>(responseStream);
              }

              if (Passenger == null)
                  return NotFound();

              return View(Passenger);
          }*/

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("Name, Surname, Gender, BirthDate, Email, Cell,HomeAddress, PickUpLocation, DropOffLocation, Temp")] Passenger Passenger)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Passenger), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Post;
                message.RequestUri = new Uri($"{BASE_URL}/createpassenger");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));
            }
            return View(Passenger);
        }

        public async Task<IActionResult> List()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/allpassengers");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Passengers = await JsonSerializer.DeserializeAsync<IEnumerable<Passenger>>(responseStream);
            }
            else
            {
                Passengers = Array.Empty<Passenger>();
            }
            return View(Passengers);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/passenger/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);
            Passenger Passenger = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Passenger = await JsonSerializer.DeserializeAsync<Passenger>(responseStream);
            }
            return View(Passenger);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Name, Surname,Gender, BirthDate, Email, Cell, HomeAddress, PickUpLocation, DropOffLocation")] Passenger passenger)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(passenger), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/updatepassenger/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(passenger);
        }


        public async Task<IActionResult> AssignToTrip(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/passenger/{id}");
            message.Headers.Add("Accept", "application/json");
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(message);
            Passenger Passenger = null;

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Passenger = await JsonSerializer.DeserializeAsync<Passenger>(responseStream);
            }
            return View(Passenger);
        }

        [HttpPost]
        public async Task<IActionResult> AssignToTrip(int id, [Bind("Name, Surname,Gender, BirthDate, Email, Cell, HomeAddress, PickUpLocation, DropOffLocation")] Passenger passenger)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(passenger), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/updatepassenger/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(passenger);
        }

        public void ListPassengers()
        {

        }

        public async Task<IActionResult> Test()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/allpassengers");
            message.Headers.Add("Accept", "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                Passengers = await JsonSerializer.DeserializeAsync<IEnumerable<Passenger>>(responseStream);
            }
            else
            {
                Passengers = Array.Empty<Passenger>();
            }

            var message2 = new HttpRequestMessage();
            message2.Method = HttpMethod.Get;
            message2.RequestUri = new Uri($"{BASE_URL}/findall");
            message2.Headers.Add("Accept", "application/json");

            var client2 = _clientFactory.CreateClient();

            var response2 = await client2.SendAsync(message);

            if (response2.IsSuccessStatusCode)
            {
                using var responseStream2 = await response.Content.ReadAsStreamAsync();
                Trips = await JsonSerializer.DeserializeAsync<IEnumerable<Trip>>(responseStream2);
            }
            else
            {
                Trips = Array.Empty<Trip>();
            }

            TaxiClubViewModel objTaxiClubViewModel = new TaxiClubViewModel();
            objTaxiClubViewModel.PassengersViewModel = Passengers;
            objTaxiClubViewModel.TripViewModel = Trips;

            return View(objTaxiClubViewModel);

        }
    }
}

