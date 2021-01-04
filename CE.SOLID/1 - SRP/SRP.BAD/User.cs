using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace CE.SOLID.SRP.BAD
{
    public class User
    {
        public int ClientId { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        private string CPF { get; set; }
        private DateTime Date { get; set; }

        public string AddClient()
        {
            if (!Email.Contains("@"))
                return "Invalid Email Adress";

            if (CPF.Length != 11)
                return "Client com CPF invalid";

            AddUser();
            return SendAndEmail();
        }


        private string SendAndEmail()
        {
            var mail = new MailMessage("serkaneren@outlook.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Hi Serkan";
            mail.Body = "Hello bro";
            client.Send(mail);
            
            return "Client send mail";
        }

        private void AddUser()
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "dummyConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NAME, EMAIL CPF, DATE) VALUES (@mame, @email, @cpf, @date))";

                cmd.Parameters.AddWithValue("name", Name);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("cpf", CPF);
                cmd.Parameters.AddWithValue("date", Date);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}