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

    [HttpPut]
    [Route("{id}")] // Formato quando for alterar o usuário, ou alguma coisa, um admin, por exemplo; Ou usuário apenas pode alterar as informações dele logado.
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update(
        [FromRoute] int id,
        [FromBody] RequestUpdateUserProfileJson req)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")] // Formato para remover o id de um usuário, porém, é preciso fazer uma validação pelo usuário logado; Não recebe, por padrão, [FromBody]
    [ProducesResponseType(StatusCodes.Status204NoContent)] // Formato que o usuário deleta outros usuários;
    public IActionResult Delete([FromRoute] int id)
    {
        return Ok();
    }
    [HttpGet]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<User>()
        {
            new User {Id = 1, Name = "Davi", Age = 22}
        };

        return Ok(response);
    }

    [HttpPost]
    [Route("change-password")] // Ao dar nome para as rotas eu evito dar colisões nas rotas com o mesmo método
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword([FromBody] RequestRegisterUserJson obj)
    {
        ResponseRegisterdUserJson response = new()
        {
            Id = 1,
            Name = obj.Name
        };
        return Created(string.Empty, response);
    }
}
