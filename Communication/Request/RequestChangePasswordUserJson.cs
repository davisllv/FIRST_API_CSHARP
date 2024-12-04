namespace MyFirstApi.Communication.Request;

public class RequestChangePasswordUserJson
{
    public int Id { get; set; }
    public string Password { get; set; } = String.Empty;
}
