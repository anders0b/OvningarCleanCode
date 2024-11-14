using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCleanCode.entities
{

    public class CustomerInquiry
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public DateTime InquiryDate { get; set; }
        public InquiryResponse CustomerAgentResponse { get; set; } = new();
    }
    public class InquiryResponse
    {
        public int Id { get; set; }
        public string Answer { get; set; } = string.Empty;

    }
}
