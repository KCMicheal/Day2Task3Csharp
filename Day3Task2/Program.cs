using System;

namespace Day3Task2
{
    public abstract class Notification
    {
        public virtual string Notify()
        {
            return string.Empty;
        }
    }

    public abstract class SMS : Notification
    {
        private string Msg { get; set; }
        private string PhoneNumber { get; set; }
        public SMS()
        {
            Msg = "Sending SMS";
            PhoneNumber = "+123 789 2336";
        }
        public override string Notify()
        {
            return $"SMS, '{Msg}' was delivered to {PhoneNumber}";
        }
    }

    public abstract class Email : Notification
    {
        public string Msg { get; set; }
        public string EmailAddress { get; set; }

        public Email()
        {
            Msg = "Sending Email";
            EmailAddress = "user.name@domain.com";
        }
        public override string Notify()
        {
            return $"Email, '{Msg}' was delivered to {EmailAddress}";
        }
    }

    public class Whatsapp : SMS
    {
        protected string Msg { get; set; }
        protected string PhoneNumber { get; set; }

        public Whatsapp()
        {
            Msg = "Sending Whatsapp";
            PhoneNumber = "+12343456789";
        }
        public override string Notify()
        {
            return $"Whatsapp, '{Msg}' was delivered to {PhoneNumber}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            /*var notify = new Notification();
            var notifications = notify.Notify();

            var sms = new SMS();
            var sendSms = sms.Notify();

            var email = new Email();
            var sendEmail = email.Notify();*//*

            Console.WriteLine($"{notifications} did here \n{sendSms} and \n{sendEmail} worked!!");*/

            var whatsapp = new Whatsapp();
            var whatsappnotify = whatsapp.Notify();
            Console.WriteLine($"{whatsappnotify} worked");
        }
    }
    public class Test
    {

    }
}
