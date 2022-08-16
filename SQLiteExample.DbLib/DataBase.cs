namespace SQLiteExample.DbLib;

using Microsoft.Data.Sqlite;

public class DataBase
{
    private readonly SqliteConnection db;
    private const string Str = @"Data Source=D:\Programming\Education\ITStep\Shambala\SQLiteDemo\persons.db;";

    public DataBase() => this.db = new SqliteConnection(Str);

    
}
