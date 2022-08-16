namespace SQLiteExample.Model;

public class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public string? FullName => $"{this.LastName} {this.FirstName}";

    public DateTime DateOfBirth { get; set; }

    public Dictionary<string, string>? Contacts { get; set; }
}
