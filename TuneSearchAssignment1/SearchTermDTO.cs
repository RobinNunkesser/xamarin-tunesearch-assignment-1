using System;
using ExplicitArchitecture.TuneSearchExample.Core.Ports;

namespace TuneSearchAssignment1
{
    public class SearchTermDTO : ISearchTerm
    {
        public SearchTermDTO()
        {
        }

        public string Term { get; set; }
    }
}
