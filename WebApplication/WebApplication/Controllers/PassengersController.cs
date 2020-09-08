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
    public class PassengersController : Controller, IDisposable
    {
        private readonly IHttpClientFactory _clientFactory;
        public IEnumerable<Passenger> Passengers { get; set; }
        const string BASE_URL = "https://taxiclubapi.herokuapp.com/public";
        public PassengersController(IHttpClientFactory clientFactory)
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

        public async Task<IActionResult> Profille(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/passengerprofile/{id}");
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
            message.RequestUri = new Uri($"{BASE_URL}/unasigntriptopassenger/{id}");

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

        public IActionResult Test()
        {
            return View();
        }



        public async Task<IActionResult> ListTrips()
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
                Passengers = await JsonSerializer.DeserializeAsync<IEnumerable<Passenger>>(responseStream);
            }
            else
            {
                Passengers = Array.Empty<Passenger>();
            }
            return View(Passengers);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("Name, Surname, Gender, BirthDate, Email, Cell, HomeAddress, PickUpLocation, DropOffLocation")] Passenger driver)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(driver), Encoding.UTF8);
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
            return View(driver);
        }

        public async Task<IActionResult> List()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/allpassengerssimple");
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

        public async Task<IActionResult> UnassignedList()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/allpassengerssimple");
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

        public async Task<IActionResult> SimpleList()
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/allpassengerssimple");
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
        public async Task<IActionResult> RemoveTrip(int id)
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

        [HttpGet]
        public async Task<IActionResult> TripNotFound(int id)
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
        public async Task<IActionResult> RemoveTrip(int id, [Bind("")] Passenger passenger)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(passenger), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/unasigntriptopassenger/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(passenger);
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
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(passenger),Encoding.UTF8);
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


        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/passengertrip/{id}");
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
        public async Task<IActionResult> Remove(int id, [Bind("")] Passenger passenger)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(passenger), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/unasigntriptopassenger/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(passenger);
        }

        [HttpGet]
        public async Task<IActionResult> EditTrip(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/passengertrip/{id}");
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
        public async Task<IActionResult> EditTrip(int id, [Bind("PickUpArea, DropOffArea")] Passenger passenger)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(passenger), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/updateassignpassengertotrip/{id}");
                HttpClient client = _clientFactory.CreateClient();
                HttpResponseMessage response = await client.SendAsync(message);

                var result = await response.Content.ReadAsStringAsync();
                return RedirectToAction(nameof(List));

            }
            return View(passenger);
        }

        [HttpGet]
        public async Task<IActionResult> AddTrip(int id)
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
        public async Task<IActionResult> AddTrip(int id, [Bind("PickUpArea, DropOffArea")] Passenger passenger)
        {
            if (ModelState.IsValid)
            {
                HttpContent httpContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(passenger), Encoding.UTF8);
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var message = new HttpRequestMessage();
                message.Content = httpContent;
                message.Method = HttpMethod.Put;
                message.RequestUri = new Uri($"{BASE_URL}/updateassignpassengertotrip/{id}");
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


        public async Task<IActionResult> Trip(int id)
        {
            var message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri($"{BASE_URL}/passengertrip/{id}");
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
    }
}

