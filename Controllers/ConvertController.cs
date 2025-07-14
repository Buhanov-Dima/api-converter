using api_converter.Data.Scaffolded;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace api_converter.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ConvertController : ControllerBase
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;

        public ConvertController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ConvertById(int id)
        {
            var record = await _db.FileModels.FirstOrDefaultAsync(d => d.FileModelId == id);
            if (record == null)
                return NotFound("Документ с таким ID не найден.");

            var inputPath = record.PathToFile;
            if (!System.IO.File.Exists(inputPath))
                return NotFound("Файл не найден: " + inputPath);

            // Папка = та же, где лежит .docx
            var outputDir = Path.GetDirectoryName(inputPath)!;
            var pdfName = Path.GetFileNameWithoutExtension(inputPath) + ".pdf";
            var outputPath = Path.Combine(outputDir, pdfName);

            // Запускаем LibreOffice
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Program Files\LibreOffice\program\soffice.exe", // Укажи свой путь
                    Arguments = $"--headless --convert-to pdf \"{inputPath}\" --outdir \"{outputDir}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            string stdout = await process.StandardOutput.ReadToEndAsync();
            string stderr = await process.StandardError.ReadToEndAsync();
            process.WaitForExit();

            if (!System.IO.File.Exists(outputPath))
                return StatusCode(500, $"Ошибка при конвертации:\n{stderr}");

            // Создаём запись о PDF
            var pdfRecord = new FileModels
            {
                PathToFile = outputPath
            };

            _db.FileModels.Add(pdfRecord);
            await _db.SaveChangesAsync();

            return Ok(new { pdfRecord.FileModelId, pdfRecord.PathToFile });
        }
    }
}
