using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorHybrid.Repos;

namespace RazorHybrid.Pages
{
    public class TodoModel : PageModel
    {
        private readonly TodoRepo _todoRepo;
        private readonly UserRepo _userRepo;
        private readonly ILogger<IndexModel> _logger;

        public TodoModel(TodoRepo todoRepo, UserRepo userRepo, ILogger<IndexModel> logger)
        {
            _todoRepo = todoRepo;
            _userRepo = userRepo;
            _logger = logger;
        }

        public void OnGet()
        {

            TodoItems = _todoRepo.GetAll();
            Users = _userRepo.GetAll();



        }


        public List<TodoItem> TodoItems { get; set; } = new List<TodoItem>();
        public List<User> Users { get; set; } = new List<User>();
    }

}
