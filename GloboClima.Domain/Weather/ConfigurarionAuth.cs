using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboClima.Domain.Weather
{
    public class ConfigurarionAuth
    {
        //public const string appId = "aa1941d555f4a151c6931796548359a1";
        public const string appId = "771d9f09ca81d3a225bcb6ed1a6b9d5f";
        public const string uri = "https://api.openweathermap.org/data/2.5/weather?";
        public const string paramAppid = "appid";
    }

    public class HttpRequestWaether
    {
        public const string requestUri = "https://localhost:7163/Waether";
    }

    public class HttpRequestFavorite
    {
        public const string requestUri = "https://localhost:7163/Favorite";
    }

}
