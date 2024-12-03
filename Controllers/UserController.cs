using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Communication.Request;
using MyFirstApi.Communication.Response;

namespace MyFirstApi.Controllers;
// Route é uma variável já definido com a variável local
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase // Controllerbase herda valores da classe cntrollerbase
{
    [HttpGet]
    [Route("{id}")] // Definir parametros dentro da rota;
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)] // Definir qual vai ser a resposta da API
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Get([FromHeader] long id) // Parametros dentro da query [FromQuery]; Parametros dentro do cabeçalho [FromHeader]
    {
        var response = new User
        {
            Id = 1,
            Age = 22,
            Name = "22"
        };
        return Ok(response);
    }
    // Informações são recebidas do body
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterdUserJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterUserJson obj)
    {
        ResponseRegisterdUserJson response = new()
        {
            Id = 1,
            Name = obj.Name
        };
        return Created(string.Empty, response);
    }
    [HttpPost]
    public IActionResult Update([FromBody] RequestRegisterUserJson obj)
    {
        ResponseRegisterdUserJson response = new()
        {
            Id = 1,
            Name = obj.Name
        };
        return NoContent();
    }
}
