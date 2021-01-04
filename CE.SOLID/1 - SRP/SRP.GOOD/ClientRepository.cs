using System.Data;
using System.Data.SqlClient;
using CE.SOLID.SRP.GOOD;

namespace Good_Single_Responsibility_Principle
{
    public class ClientRepository
    {
        public void AdicionarCliente(Client client)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "DummyConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))";

                cmd.Parameters.AddWithValue("nome", client.Name);
                cmd.Parameters.AddWithValue("email", client.Email);
                cmd.Parameters.AddWithValue("cpf", client.CPF);
                cmd.Parameters.AddWithValue("dataCad", client.Date);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
}
   
}