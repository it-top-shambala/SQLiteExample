namespace SQLiteExample.DbLib;

using System.Data;
using Microsoft.Data.Sqlite;
using Model;

public class DataBase
{
    private readonly SqliteConnection db;
    private const string Str = @"Data Source=D:\Programming\Education\ITStep\Shambala\SQLiteDemo\persons.db;";

    public DataBase() => this.db = new SqliteConnection(Str);

    public IEnumerable<Person> GetAllPersons()
    {
        var persons = new List<Person>();

        this.db.Open();

        var sql = @"SELECT first_name, last_name, date_of_birth FROM tab_persons";

        var command = new SqliteCommand(sql, this.db);
        var result = command.ExecuteReader();
        if (result.HasRows)
        {
            while (result.Read())
            {
                persons.Add(new Person
                {
                    FirstName = result.GetString("first_name"),
                    LastName = result.GetString("last_name"),
                    DateOfBirth = Convert.ToDateTime(result.GetString("date_of_birth"))
                });
            }
        }
        else
        {
            throw new Exception("Bad request to DB");
        }

        this.db.Close();

        return persons;
    }
}
