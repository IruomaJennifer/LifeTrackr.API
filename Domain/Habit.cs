using System;

public class Habit
{
	
	public int Id { get; set; }
	public required string Name { get; set; }
	public string? Description { get; set; }
	public bool IsActive { get; set; }
	public DateTime StartDate { get; set; }
	public required User User { get; set; }
	public ICollection<HabitLog> HabitLogs { get; set; } = [];
}
