using System.Data.SqlClient;

namespace Testproject.Repositories
{
    public class AccountRepository
    {
        public bool Exists(string email, string password)
        {
            using (var connection = new SqlConnection(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Testprojectdatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            )
            {
                using (var command = new SqlCommand("SELECT * FROM Accounts WHERE Email=@email AND Password=@password",
                    connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    var rows = command.ExecuteReader();

                    if (rows.HasRows)
                        return true;
                    return false;
                }
            }
        }
    }
}