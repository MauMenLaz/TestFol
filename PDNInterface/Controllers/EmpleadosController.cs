using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PDNInterface.Controllers
{
   
    public class EmpleadosController : ControllerBase
    {
        string dir = "https://localhost:44347/";
        public EmpleadosController()
        {
                
        }

        [HttpGet]
        public async Task<string> consultaEmpleados(int id) { 
        HttpHelperEmpleado helper = new HttpHelperEmpleado();
            return await helper.GetAsync(string.Format(dir + "obtieneEmpleados/{0}", id));
        }

    }
}
