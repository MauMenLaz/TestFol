using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


public class HttpHelperEmpleado
{
    public HttpHelperEmpleado()
    {

    }

    static HttpClient client = new HttpClient();

    //Get
    public async Task<string> GetAsync(string path)
    {
        string resp="";
        HttpResponseMessage response = await client.GetAsync(path);
        if (response.IsSuccessStatusCode)
        {
            resp = await response.Content.ReadAsStringAsync();
        }
        return resp;
    }


    //Get
    //Opc 1 para insertar, opc2 para actualizar

    public async Task<string> PostAsync(ExaTEmpleado emp)
    {
        string resp;
        HttpResponseMessage response = await client.PostAsJsonAsync(
                "https://localhost:44347/ingModEmpleado", emp);
        resp = await response.Content.ReadAsStringAsync();
        return resp;
    }
}


public class ExaTEmpleado
{
    public int IdEmpleado { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apaterno { get; set; } = null!;

    public string? Amaterno { get; set; }

    public int Area { get; set; }

    public DateTime FechaNacimiento { get; set; }

    public decimal Sueldo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Estatus { get; set; }
}
