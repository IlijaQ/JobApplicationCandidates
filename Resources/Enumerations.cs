using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateLog.Resources
{
    public enum Status
    {
        All,
        Candidate, // white
        Qualified, // yellow
        Interview, // blue
        ShortListed, // purple
        Employee // green
    }

    public enum FileType
    {
        Resume,
        CoverLetter,
        Certificate
    }
}
