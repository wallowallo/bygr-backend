using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace bygr_project.Controllers
{
    [ApiController]
    [Route("api/buyer-info/")]
    public class ApartmentController : ControllerBase
    {
        [HttpGet]
        public List<Apartment> GetAll()
        {
            var json = getApartmentsFromJson();
            return json;
        }

        [HttpGet("{floor}")]
        public List<Apartment> GetbyFloor(int floor) {
            var apartments = getApartmentsFromJson();
            return apartments.FindAll(x => x.floor == floor);
        }

        private List<Apartment> getApartmentsFromJson()
        {
            var jsonString = System.IO.File.ReadAllText("data.json");
            var jsonObject = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Apartment>>(jsonString);
            return jsonObject;
        }
    }
}
