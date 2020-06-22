﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Domain
{
    public class Tag
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<ProjectTag> ProjectTags { get; set; }
    }
}
