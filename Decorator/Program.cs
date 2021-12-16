using System;
using Decorator.Components;
using Decorator.Decorator;

namespace Decorator
{
    public class Program
    {
        public static void Main()
        {
            INotificatorComponent notificator = new EmailNotificator();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Notify by SMS? Y or N");
            Console.ForegroundColor = ConsoleColor.Red;
            var notifySms = Console.ReadLine().Equals("Y", StringComparison.CurrentCultureIgnoreCase);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nNotify by WhatsApp? Y or N");
            Console.ForegroundColor = ConsoleColor.Red;
            var notifyWhatsApp = Console.ReadLine().Equals("Y", StringComparison.CurrentCultureIgnoreCase);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nNotify by Teams? Y or N");
            Console.ForegroundColor = ConsoleColor.Red;
            var notifyTeams = Console.ReadLine().Equals("Y", StringComparison.CurrentCultureIgnoreCase);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;

            // I have implemented this simulating an "user configuration"
            // but it could be simpler as the example in region "Decorator Without "User Configuration"
            if (notifySms) notificator = new SmsDecorator(notificator);
            if (notifyWhatsApp) notificator = new WhatsAppDecorator(notificator);
            if (notifyTeams) notificator = new MicrosoftTeamsDecorator(notificator);
            notificator.Send();

            #region Decorator Without "User Configuration"

            //// This is a decorator without "user configuration"
            //var sms = new SmsDecorator(notificator);
            //var whastApp = new WhatsAppDecorator(sms);
            //var teams = new MicrosoftTeamsDecorator(whastApp);
            //teams.Send();
            //// In this example the output would be:
            ////    Sending Microsoft Teams message...
            ////    Sending WhatsApp message...
            ////    Sending SMS...
            ////    Send Email message...

            #endregion

            Console.ReadLine();
        }
    }
}
