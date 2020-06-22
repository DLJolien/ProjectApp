using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public async Task<IActionResult> Index()
        {
            List<ProjectListViewModel> vmList = new List<ProjectListViewModel>();
            var projects = await _projectDb.Projects.Include(x => x.Status).Include(x => x.ProjectTags).ThenInclude(x => x.Tag).ToListAsync();
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
        public async Task<IActionResult> Detail(int id)
        {
            Project project = await _projectDb.Projects.Include(x => x.Status).Include(x => x.ProjectTags).ThenInclude(x => x.Tag).FirstOrDefaultAsync(x => x.Id == id);
            ProjectDetailViewModel vm = new ProjectDetailViewModel()
            {
                Title = project.Title,
                CompletionDate = project.CompletionDate,
                Status = project.Status.Description,
                Tags = project.ProjectTags.Select(x => x.Tag.Description).ToList(),
                PhotoUrl = project.PhotoUrl,
                Description = project.Description
            };
            return View(vm);
        }

    }
}
