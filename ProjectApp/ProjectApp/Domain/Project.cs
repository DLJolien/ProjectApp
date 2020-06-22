using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Domain
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CompletionDate { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<ProjectTag> ProjectTags { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
    }
}
