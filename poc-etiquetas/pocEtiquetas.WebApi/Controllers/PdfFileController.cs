using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace pocEtiquetas.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PdfFileController : ControllerBase {

    private const string _filePath = "files";
    private const string _fileName = "pdfCrescer.pdf";

    public PdfFileController() {}

    [HttpGet("{pdfName}")]
    public IActionResult Download(string pdfName) {
        var stream = new FileStream(Path.Combine(_filePath, _fileName), FileMode.Open);
        
        if(stream == null)
            return NotFound(); // returns a NotFoundResult with Status404NotFound response.

        return File(stream, "application/octet-stream", $"{pdfName}.pdf"); // returns a FileStreamResult
    } 
}