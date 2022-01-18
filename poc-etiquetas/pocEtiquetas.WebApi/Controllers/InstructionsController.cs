using Microsoft.AspNetCore.Mvc;

namespace pocEtiquetas.WebApi.Controllers;

[ApiController]
[Route("/")]
public class InstructionsController : ControllerBase {

    public PdfFileController() {}

    [HttpGet]
    public string Infos() {
        return "Acessar https://poc-etiquetas.herokuapp.com/PdfFile/ + nomeDoArquivo";
    } 
}