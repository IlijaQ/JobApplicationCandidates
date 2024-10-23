using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates.Models
{
    public class Attachment
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public byte Type { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
