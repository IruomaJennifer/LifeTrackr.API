namespace LifeTrackr.API.Application
{
    public class UpdateUserDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } = default!;
    }
}
