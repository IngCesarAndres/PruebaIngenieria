using Microsoft.AspNetCore.Mvc;
using PruebaIngenieria.Models;

namespace PruebaIngenieria.Controllers;

[Route("api/[controller]")]
public class LibroController : ControllerBase{
    ILibroService _libro;

    public LibroController(ILibroService service){
        _libro = service;
    }

    [HttpGet]
    [Route("[action]")]
    public IActionResult GetLibro(){
        return Ok(_libro.GetLibro());
    }

    [HttpPost]
    [Route("[action]")]
    public IActionResult SaveLibro([FromBody] Libro libro){
        _libro.SaveLibro(libro);
        return Ok();
    }

    [HttpPut]
    [Route("[action]/{id}")]
    public IActionResult UpdateLibro(Guid id, [FromBody] Libro libro){
        _libro.UpdateLibro(id, libro);
        return Ok();
    }

    [HttpDelete]
    [Route("[action]/{id}")]
    public IActionResult DeleteLibro(Guid id){
        _libro.DeleteLibro(id);
        return Ok();
    }
}