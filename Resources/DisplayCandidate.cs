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
        public int DatabaseId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Rating { get; set; }
        public string Status { get; set; }

        public DisplayCandidate(Candidate dbData)
        {
            DatabaseId = dbData.Id;
            Name = dbData.Name;
            LastName = dbData.LastName;
            Email = dbData.Email;
            PhoneNumber = dbData.PhoneNumber;
            LastUpdate = dbData.LastUpdate;
            Rating = ConvertToStars(dbData.Rating);
            Status = AssignStatusName(dbData.Status) ;
        }

        private string ConvertToStars(byte rating)
        {
            switch(rating)
            {
                case 1: return "*";
                case 2: return "* *";
                case 3: return "* * *";
                case 4: return "* * * *";
                case 5: return "* * * * *";
                default: return string.Empty;
            }
        }

        private string AssignStatusName(byte statusCode)
        {
            try
            {
                return Enum.ToObject(typeof(Resources.Status), statusCode).ToString();
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
