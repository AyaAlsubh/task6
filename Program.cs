using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    // Interface
    interface INotification
    {
        void Send();
    }

    // Email
    class EmailNotification : INotification
    {
        private string message;
        private string emailAddress;

        public EmailNotification(string message, string emailAddress)
        {
            this.message = message;
            this.emailAddress = emailAddress;
        }

        public void Send()
        {
            Console.WriteLine($"Sending Email to {emailAddress}: {message}");
        }
    }

    // SMS
    class SMSNotification : INotification
    {
        private string message;
        private string phoneNumber;

        public SMSNotification(string message, string phoneNumber)
        {
            this.message = message;
            this.phoneNumber = phoneNumber;
        }

        public void Send()
        {
            Console.WriteLine($"Sending SMS to {phoneNumber}: {message}");
        }
    }

    // Push
    class PushNotification : INotification
    {
        private string message;
        private string deviceId;

        public PushNotification(string message, string deviceId)
        {
            this.message = message;
            this.deviceId = deviceId;
        }

        public void Send()
        {
            Console.WriteLine($"Sending Push Notification to device {deviceId}: {message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            INotification email = new EmailNotification("Hello Email", "aya@email.com");
            INotification sms = new SMSNotification("Hello SMS", "0796700000");
            INotification push = new PushNotification("Hello Push", "Device1");

            email.Send();
            sms.Send();
            push.Send();
        }
    }
}
