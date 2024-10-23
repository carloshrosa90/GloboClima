using GloboClima.Domain.Weather;
using GloboClima.Repository.ClassFirstCode;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GloboClima.WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class WaetherController : ControllerBase
    {
        [HttpGet("{city}")]
        public ActionResult<List<WeatherByCity>> Get([FromRoute] string city)
        {
            try
            {
                var client = new HttpClient();
                string baseUrl = $"{ConfigurarionAuth.uri}";

               if(!string.IsNullOrEmpty(city))
                    baseUrl = baseUrl + $"q={city}&{ConfigurarionAuth.paramAppid}={ConfigurarionAuth.appId}";
               
                var weatherResponso = client.GetStringAsync(baseUrl).Result;
                return Ok(weatherResponso);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
