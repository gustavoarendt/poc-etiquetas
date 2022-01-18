using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace pocEtiquetas.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PdfFileController : ControllerBase {

    public PdfFileController() {}

    [HttpGet("{pdfName}")]
    public IActionResult Download(string pdfName) {
        var stream = new FileStream(@"./files/pdfCrescer.pdf", FileMode.Open);
        var defaultName = string.IsNullOrEmpty(pdfName) ? "Crescer" : pdfName;
        
        if(stream == null)
            return NotFound(); // returns a NotFoundResult with Status404NotFound response.

        return File(stream, "application/octet-stream", $"{defaultName}.pdf"); // returns a FileStreamResult
    } 
}