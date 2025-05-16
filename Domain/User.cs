using System;

public class User
{
	
	public int Id { get; set; }
	public required string Email { get; set; }
	public required string FullName { get; set; }
	public DateTime CreatedAt { get; set; }
	public ICollection<Habit> Habits { get; set; } = [];
}
