using System;
using MusicPorts;

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
