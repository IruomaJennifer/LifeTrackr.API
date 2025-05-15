namespace LifeTrackr.API.Application
{
    public class CreateUserDto
    {
        public string Email { get; set; } = default!;
        public string FullName { get; set; } = default!;
        
    }
}
