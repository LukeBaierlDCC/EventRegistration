using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventRegistration
{
    class Attendee
    {
        public int AttendeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
