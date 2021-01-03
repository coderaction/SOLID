using System;

namespace Good_Single_Responsibility_Principle
{
    public class Client
    {
            public int ClientId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string CPF { get; set; }
            public DateTime Date { get; set; }

            public bool IsValid()
            {
                return EmailServices.IsValid(Email) && CPFServices.IsValid(CPF);
            }
    }
}