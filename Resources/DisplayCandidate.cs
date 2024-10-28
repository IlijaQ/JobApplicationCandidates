using CandidateLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateLog.Resources
{
    public class DisplayCandidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime LastUpdate { get; set; }
        public byte Rating { get; set; }
        public byte Status { get; set; }

        public DisplayCandidate(Candidate dbData)
        {
            Id = dbData.Id;
            Name = dbData.Name;
            LastName = dbData.LastName;
            Email = dbData.Email;
            PhoneNumber = dbData.PhoneNumber;
            LastUpdate = dbData.LastUpdate;
            Rating = dbData.Rating;
            Status = dbData.Status ;
        }
    }
}
