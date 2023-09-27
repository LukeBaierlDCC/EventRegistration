using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventRegistration
{
    class Registration
    {
        public int RegistrationId { get; set; }
        public int AttendeeId { get; set; }
        public int EventId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public RegistrationStatus Status { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public RegistrationType Type { get; set; }
        public string ConfirmationCode { get; set; }
        public bool BadgePrinted { get; set; }
        public string Notes { get; set; }
        public DateTime CheckInDateTime { get; set; }
        public decimal RegistrationFee { get; set; }
        public string DiscountCode { get; set; }
    }

    public enum RegistrationStatus
    {
        Registered,
        Confirmed,
        Cancelled,
        OnHold
    }

    public enum PaymentStatus
    {
        Paid,
        Pending,
        Cancelled
    }

    public enum RegistrationType
    {
        VIP,
        Regular,
        EarlyBird
    }
}
