using System.Data.SqlClient;
using Dapper;

string connectionString = "YourConnectionStringHere";
string query = "SELECT Id, Name, Age FROM Users";

using (var connection = new SqlConnection(connectionString))
{
    var result = connection.Query(query);
    
    foreach (var row in result)
    {
        Console.WriteLine($"Id: {row.Id}, Name: {row.Name}, Age: {row.Age}");
    }
}
