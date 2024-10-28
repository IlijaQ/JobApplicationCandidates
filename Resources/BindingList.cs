using CandidateLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateLog.Resources
{
    public static class BindingList
    {
        public static List<DisplayCandidate> BindCandidates(List<Candidate> queryResults)
        {
            List<DisplayCandidate> dgwDisplayableList = new List<DisplayCandidate>();

            for(int i = 0; i < queryResults.Count; i++)
                dgwDisplayableList.Add(new DisplayCandidate(queryResults[i]));

            return dgwDisplayableList;
        }
    }
}
