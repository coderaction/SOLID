using CE.SOLID.SRP.GOOD;

namespace Good_Single_Responsibility_Principle
{
    public class ClientService
    {
        public string AddClient(Client client)
        {
            if (!client.IsValid())
                return "Invalid Client";

            var repo = new ClientRepository();
            repo.AdicionarCliente(client);

            EmailServices.SendMail("serkaneren@outlook.com", client.Email, "Hi Serkan", "Send Mail");

            return "Client Send Mail Suc.";
        }
    }
}