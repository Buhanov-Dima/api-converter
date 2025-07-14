using api_converter.Data.Scaffolded;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Sockets;

namespace api_converter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _config;
        private readonly AppDbContext _db;

        public StatusController(IWebHostEnvironment env, IConfiguration config, AppDbContext db)
        {
            _env = env;
            _config = config;
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetStatus()
        {
            // Укажи путь к LibreOffice явно, если он не в PATH
            var libreOfficePath = @"C:\Program Files\LibreOffice\program\soffice.exe";
            var libreOfficeAvailable = System.IO.File.Exists(libreOfficePath);
            string dbName = "n/a";
            string ipAddress = "unknown";
            bool dbAvailable = false;
            var dotnetVersion = Environment.Version.ToString();

            try
            {
                dbAvailable = await _db.Database.CanConnectAsync();
                dbName = _db.Database.GetDbConnection().Database;
            }
            catch
            {
                dbAvailable = false;
            }

            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                var ip = host.AddressList.FirstOrDefault(a => a.AddressFamily == AddressFamily.InterNetwork);
                ipAddress = ip?.ToString() ?? "n/a";
            }
            catch
            {
                ipAddress = "error";
            }


            return Ok(new
            {
                machineName = Environment.MachineName,
                ipAddress,
                environment = _env.EnvironmentName,
                libreOfficePath,
                libreOfficeAvailable,
                databaseConnected = dbAvailable,
                databaseName = dbName,
                dotnetVersion
            });

        }
    }
}