using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCleanCode.Methods
{
    //Uppgift: Anta att du har en EmailService som skickar e-postmeddelanden.Använd FakeItEasy för att skapa en mock av denna tjänst.
    //Tester: Skriv tester som verifierar att ett e-postmeddelande "skickas" (dvs.metoden SendEmail anropas) när det är tänkt att skickas.

    public interface IEmailService
    {
        void SendEmail(string toAddress, string subject, string body);
        string PaymentSent(string toAddress);

    }
    public class OrderService
    {
        private readonly IEmailService _emailService;
        public OrderService(IEmailService emailService)
        {
            _emailService = emailService;
        }
        public void PlaceOrder(string customerMail)
        {
            _emailService.SendEmail(customerMail, "Test", "Test");
        }
        public string Pay(string customerMail)
        {
            return _emailService.PaymentSent(customerMail);
        }
    }


}
