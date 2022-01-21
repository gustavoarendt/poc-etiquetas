using Microsoft.AspNetCore.Mvc;
using pocEtiquetas.WebApi.Handlers;

namespace pocEtiquetas.WebApi.Controllers{
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
            return File(stream, "application/octet-stream", $"{pdfName}.pdf");
        }
        
        [HttpGet("v2/static")]
        public string PdfBytes() {
            var encodedPdf = ConvertHandlers.ConvertBaseToString(Path.Combine(_filePath, _fileName));
            return encodedPdf;
        }
    }
}