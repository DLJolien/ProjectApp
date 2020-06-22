using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class ProjectCreateViewModel
    {
        public string Title { get; set; }
        public DateTime CompletionDate { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public int[] SelectedTags { get; set; }
        public List<SelectListItem> Tags { get; set; } = new List<SelectListItem>();
        public int SelectedStatus { get; set; }
        public List<SelectListItem> Statuses { get; set; } = new List<SelectListItem>();
    }
}
