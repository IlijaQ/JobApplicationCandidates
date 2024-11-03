using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateLog.Resources
{
    public static class MiniTools
    {
        public static string UpdateLabelIfLeadsToSotialNetwork(string url)
        {
            string urlLowerCase = url.ToLower();

            if (urlLowerCase.Contains("linkedin"))
                return "LinkedIn account";
            if (urlLowerCase.Contains("github"))
                return "GitHub account";
            if (urlLowerCase.Contains("facebook"))
                return "Facebook account";
            if (urlLowerCase.Contains("instagram"))
                return "Instagram account";
            if (urlLowerCase.Contains("threads"))
                return "Threads account";
            if (urlLowerCase.Contains("/x.com")
                || urlLowerCase.Contains(".x.com")
                || urlLowerCase.IndexOf("x.com") == 0
                || urlLowerCase.Contains("twitter"))
                return "X account";

            return url;
        }
    }
}
