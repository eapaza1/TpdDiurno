using System;

using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;

namespace TpdDiurno.servicios
{
    public class ServiceApiDev
    {
        private HttpClient http;
        private const string TOKEN = "599759f090449b051bf2d0b9b34200c71383cbc3994343636653c2ac3419b5cb";
        private const string URL_BASE = "https://apiperu.dev/api/";
        public ServiceApiDev()
        {
            http = new HttpClient();
            http.BaseAddress = new Uri(URL_BASE);
            http.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );
            http.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", TOKEN);
        }

        public async Task<DataDniApiDev> getByDni(string nrodni)
        {
            var datos = new { dni = nrodni };
            string json=JsonConvert.SerializeObject(datos);
            HttpContent content = new StringContent(json,Encoding.UTF8,"application/json");
            HttpResponseMessage respuesta = await http.PostAsync("dni", content);
            if (respuesta.IsSuccessStatusCode)
            {
                string body = await respuesta.Content.ReadAsStringAsync();
                var resbody = JsonConvert.
                    DeserializeObject<ResponseApiDev<DataDniApiDev>>(body);

                if (resbody.Success)
                {
                    return resbody.Data;
                }
                else
                {
                    throw new Exception("no hay datos");
                }
            }
            else
            {
                throw new Exception("La solicitud no se concreto");
            }

        }
    }
}
