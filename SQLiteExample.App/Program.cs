using SQLiteExample.DbLib;

var db = new DataBase();
var persons = db.GetAllPersons();

foreach (var person in persons)
{
    Console.WriteLine($"{person.FullName}, {person.DateOfBirth}");
}
