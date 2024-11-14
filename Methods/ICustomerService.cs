using OvningarCleanCode.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCleanCode.Methods
{
    public interface ICustomerService
    {
        InquiryResponse ReceiveCustomerInquiry(CustomerInquiry inquiry);
        void RespondToInquiry(InquiryResponse response);
    }
}
