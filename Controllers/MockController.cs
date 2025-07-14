using Microsoft.AspNetCore.Mvc;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using api_converter.Data;
using api_converter.Data.Scaffolded;
using Microsoft.EntityFrameworkCore;

namespace api_converter.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MockController : ControllerBase
{
    private readonly IWebHostEnvironment _env;
    private readonly AppDbContext _db;

    public MockController(IWebHostEnvironment env, AppDbContext db)
    {
        _env = env;
        _db = db;
    }

    [HttpPost("init")]
    public async Task<IActionResult> GenerateMock()
    {
        var tempDir = Path.Combine(_env.ContentRootPath, "MockDocs");
        Directory.CreateDirectory(tempDir);

        var fileName = $"mock_{Guid.NewGuid()}.docx";
        var fullPath = Path.Combine(tempDir, fileName);

        using (var wordDoc = WordprocessingDocument.Create(fullPath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
        {
            var mainPart = wordDoc.AddMainDocumentPart();
            mainPart.Document = new Document();
            var body = mainPart.Document.AppendChild(new Body());
            var para = body.AppendChild(new Paragraph());
            var run = para.AppendChild(new Run());
            run.AppendChild(new Text("Это мок-документ, сгенерированный программно."));
        }

        var doc = new FileModels
        {
            Title = fileName,
            PathToFile = fullPath
        };

        _db.FileModels.Add(doc);
        await _db.SaveChangesAsync();

        return Ok(new { doc.FileModelId, doc.PathToFile });
    }

    [HttpDelete("clear")]
    public async Task<IActionResult> ClearMocks()
    {
        var mockDocs = await _db.FileModels
            .Where(d => d.PathToFile.Contains("mock_"))
            .ToListAsync();

        int fileDeleted = 0;

        foreach (var doc in mockDocs)
        {
            try
            {
                if (System.IO.File.Exists(doc.PathToFile))
                {
                    System.IO.File.Delete(doc.PathToFile);
                    fileDeleted++;
                }
            }
            catch (Exception ex)
            {
                // Можно добавить логгирование, если нужно
            }
        }

        _db.FileModels.RemoveRange(mockDocs);
        var dbDeleted = await _db.SaveChangesAsync();

        return Ok(new
        {
            DeletedFromDb = dbDeleted,
            DeletedFiles = fileDeleted
        });
    }

}
