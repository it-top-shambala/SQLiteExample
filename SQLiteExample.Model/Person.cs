namespace SQLiteExample.Model;

public class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public string? FullName => $"{LastName} {FirstName}";

    public DateTime DateOfBirth { get; set; }
}
