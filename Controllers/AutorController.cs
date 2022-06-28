using Microsoft.AspNetCore.Mvc;
using PruebaIngenieria.Models;

namespace PruebaIngenieria.Controllers;

[Route("api/[controller]")]
public class AutorController : ControllerBase{
    IAutorService _autor;

    public AutorController(IAutorService service){
        _autor = service;
    }

    [HttpGet]
    [Route("[action]")]
    public IActionResult GetAutor(){
        return Ok(_autor.GetAutor());
    }

    [HttpPost]
    [Route("[action]")]
    public IActionResult SaveAutor([FromBody] Autor autor){
        _autor.SaveAutor(autor);
        return Ok();
    }

    [HttpPut]
    [Route("[action]/{id}")]
    public IActionResult UpdateAutor(Guid id, [FromBody] Autor autor){
        _autor.UpdateAutor(id, autor);
        return Ok();
    }

    [HttpDelete]
    [Route("[action]/{id}")]
    public IActionResult DeleteAutor(Guid id){
        _autor.DeleteAutor(id);
        return Ok();
    }
}