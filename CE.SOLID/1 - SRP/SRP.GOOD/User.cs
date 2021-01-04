using System;

namespace Good_Single_Responsibility_Principle
{
    public class User
    {
        public int ClientId { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        private string CPF { get; set; }
        private DateTime Date { get; set; }
    }
}