//using Solid07_DependencyInversion.Before;
using Solid07_DependencyInversion.After;

namespace Solid07_DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before
            //MailService mailService = new MailService();
            //mailService.SendMail(new GmailServer());
            #endregion

            #region After
            MailService mailService = new MailService();
            mailService.SendMail(new GmailServer(), "engin@gmail.com", "selam");
            mailService.SendMail(new HotmailServer(), "engin@hotmail.com", "selammm");
            #endregion
        }
    }
}