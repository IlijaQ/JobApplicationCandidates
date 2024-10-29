using CandidateLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CandidateLog.Resources
{
    public static class BindData
    {
        public static BindingList<DisplayCandidate> BindCandidates(List<Candidate> queryResults)
        {
            BindingList<DisplayCandidate> dgwDisplayableList = new BindingList<DisplayCandidate>();

            for(int i = 0; i < queryResults.Count; i++)
                dgwDisplayableList.Add(new DisplayCandidate(queryResults[i]));

            return dgwDisplayableList;
        }
    }
}
