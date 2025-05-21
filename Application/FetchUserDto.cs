namespace LifeTrackr.API.Application;

public class FetchUserDto
{
    public string Email { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public int Id { get; set; }
}
