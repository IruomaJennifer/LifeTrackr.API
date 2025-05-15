using System;

public class HabitLog
{
	
	public int Id { get; set; }
	public bool Completed { get; set; }
	public DateTime DateLogged { get; set; }
	public string? Notes { get; set; }
	public required Habit Habit { get; set; }
}
