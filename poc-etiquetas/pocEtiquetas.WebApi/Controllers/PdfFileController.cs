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
            return NotFound();
        return File(stream, "application/pdf", $"{pdfName}.pdf");
    } 
}