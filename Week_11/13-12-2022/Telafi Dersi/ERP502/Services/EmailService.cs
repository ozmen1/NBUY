namespace ERP502.Services
{
    public class EmailService : IEmailService
    {
        public string SenderMail { get; set; }
        public string Password { get; set; }
        public EmailService()
        {
            this.SenderMail = "info@bilmemne.com";
            this.Password = "123456";
        }
        public void Send(string to, string message, string topic)
        {
            Console.WriteLine($"{to} - {topic} {message}");
        }
    }
}
