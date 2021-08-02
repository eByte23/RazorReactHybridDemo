using System;
using System.Collections.Generic;
using System.Linq;

namespace RazorHybrid.Repos
{
    public class TodoRepo
    {
        private List<TodoItem> _todos;
        public TodoRepo()
        {
            _todos = new List<TodoItem>();
        }

        public TodoRepo(List<TodoItem> todos)
        {
            _todos = todos;
        }

        public List<TodoItem> GetAll() => _todos;

        public TodoItem Get(Guid id) => _todos.SingleOrDefault(t => t.Id == id);

        public void Add(TodoItem todo)
        {

            if (todo == null)
            {
                throw new ArgumentNullException(nameof(todo));
            }

            if (_todos.Any(t => t.Id == todo.Id))
            {
                throw new ArgumentException($"Todo with Id {todo.Id} already exists");
            }


            _todos.Add(todo);
        }

        public void Update(TodoItem todo)
        {
            if (todo == null)
            {
                throw new ArgumentNullException(nameof(todo));
            }

            if (!_todos.Any(t => t.Id == todo.Id))
            {
                throw new ArgumentException($"Todo with Id {todo.Id} does not exist");
            }

            var existingTodo = _todos.Single(t => t.Id == todo.Id);
            existingTodo.Title = todo.Title;
            existingTodo.AssignedUserId = todo.AssignedUserId;
            existingTodo.Completed = todo.Completed;
        }
    }

    public class TodoItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid? AssignedUserId { get; set; }
        public bool? Completed { get; set; }
    }

}