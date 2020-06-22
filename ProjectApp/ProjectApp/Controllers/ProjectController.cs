using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectApp.Database;
using ProjectApp.Domain;
using ProjectApp.Models;

namespace ProjectApp.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ProjectDb _projectDb;

        public ProjectController(ProjectDb projectDb)
        {
            _projectDb = projectDb;
        }

        public IActionResult Index()
        {
            List<ProjectListViewModel> vmList = new List<ProjectListViewModel>();
            var projects = _projectDb.Projects.Include(x => x.Status).Include(x => x.ProjectTags).ThenInclude(x => x.Tag);
            foreach (var project in projects)
            {
                ProjectListViewModel vm = new ProjectListViewModel()
                {
                    Id = project.Id,
                    CompletionDate = project.CompletionDate,
                    Status = project.Status.Description,
                    Tags = project.ProjectTags.Select(x =>x.Tag.Description).ToList(),
                    PhotoUrl = project.PhotoUrl,
                    Title = project.Title
                };
                vmList.Add(vm);
            }

            return View(vmList);
        }
    }
}
