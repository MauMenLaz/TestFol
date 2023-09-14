using ConexionDatos.EDM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDNWPF.HttpHelper
{
    internal class HttpHelp
    {
        public HttpHelp()
        {
                
        }
        public async Task<string> obtenEmpleados(string apiUrl)
        {
            // URL de la API que deseas consumir
            //string  = "https://ejemplo.com/api/datos";

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // Realiza la solicitud GET a la API de manera asincrónica
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    // Verifica si la solicitud fue exitosa (código de estado 200 OK)
                    if (response.IsSuccessStatusCode)
                    {
                        // Lee el contenido de la respuesta como una cadena JSON
                        string json = await response.Content.ReadAsStringAsync();

                        // Aquí puedes procesar los datos JSON obtenidos de la API
                        // Por ejemplo, puedes mostrarlos en un control de Windows Forms
                        return json;
                    }
                    else
                    {
                        return "La solicitud a la API falló. Código de estado: " + response.StatusCode;
                    }
                }
                catch (Exception ex)
                {
                    return "Error al conectarse a la API: " + ex.Message;
                }
            }
        }


        public async Task<string> enviaEmpleado(string url,ExaTEmpleado emp)
        {
            // URL a la que deseas realizar la solicitud POST
            //string url = "https://ejemplo.com/api/endpoint";

            // Crear un objeto HttpClient (preferiblemente se debe reutilizar en toda la aplicación)
            using HttpClient httpClient = new HttpClient();

           
            // Convertir los datos a formato JSON (puedes usar una biblioteca como Newtonsoft.Json)
            string jsonDatos = Newtonsoft.Json.JsonConvert.SerializeObject(emp);

            // Crear un objeto StringContent para enviar los datos en el cuerpo de la solicitud
            var contenido = new StringContent(jsonDatos, System.Text.Encoding.UTF8, "application/json");

            try
            {
                // Realizar la solicitud POST
                HttpResponseMessage respuesta = await httpClient.PostAsync(url, contenido);

                // Comprobar si la solicitud fue exitosa (código de estado 200 OK)
                if (respuesta.IsSuccessStatusCode)
                {
                    // Procesar la respuesta (si es necesario)
                    string respuestaJson = await respuesta.Content.ReadAsStringAsync();
                    return "Respuesta del servidor: " + respuestaJson;
                }
                else
                {
                    return "La solicitud POST falló. Código de estado: " + respuesta.StatusCode;
                }
            }
            catch (Exception ex)
            {
                return "Error al realizar la solicitud POST: " + ex.Message;
            }
        }

    }
}
