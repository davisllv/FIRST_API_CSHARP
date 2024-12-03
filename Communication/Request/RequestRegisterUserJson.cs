namespace MyFirstApi.Communication.Request;

public class RequestRegisterUserJson
{
    public string Name { get; set; } = string.Empty; // Se o usuário não informar nenhum valor, ele será empty
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
