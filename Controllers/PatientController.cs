using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.Data.Common;
using WebApplication1.Models;
namespace Quadcare.Controllers
{

    [ApiController]
    [Route("patient")]
    public class PatientController : Controller
    {

        private MySqlConnection dbConnection;

        public PatientController(MySqlConnection connection) 
        {
            dbConnection = connection;
        }

        [HttpGet(Name = "getAllPatients")]
        public async Task<List<Person>> GetAllPatients()
        {
            await dbConnection.OpenAsync();
            var command = new MySqlCommand("SELECT * FROM Person", dbConnection);
            var reader = await command.ExecuteReaderAsync();
            var personInformation = new List<Person>();
            while (await reader.ReadAsync())
            {
                var value = reader.GetValue(0);
                var b = value;
                personInformation.Add(new Person
                {
                     id = (int)reader.GetValue(0),
                     name = (string)reader.GetValue(1),
                     age = (int)reader.GetValue(2)
                });
            }
            return personInformation;
        }
    }
}
