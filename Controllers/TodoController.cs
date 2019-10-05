using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;

            if (_context.TodoItems.Count() == 0)
            {
                _context.TodoItems.Add(new TodoItem { Name = "Item1" });
                _context.SaveChanges();
            }
        }

        // GET api/todo
        [HttpGet]
        public ActionResult<List<TodoItem>> GetAll()
        {
            return _context.TodoItems.ToList();
        }

        // GET api/todo/{id}
        [HttpGet("{id}", Name = "GetTodo")]
        public ActionResult<TodoItem> GetById(long id)
        {
            var item = _context.TodoItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        // POST api/todo
        [HttpPost(Name = "CreateTodo")]
        public ActionResult<List<TodoItem>> CreateOne([FromBody] TodoItem todo)
        {
            _context.TodoItems.Add(todo);
            _context.SaveChanges();

            return _context.TodoItems.ToList();
        }

        // PUT api/todo/{id}
        [HttpPut("{id}", Name = "UpdateTodo")]
        public ActionResult UpdateById(long id, [FromBody] TodoItem todo)
        {
            var itemToUpdate = _context.TodoItems.Find(id);
            if (itemToUpdate == null)
            {
                return BadRequest();
            }
            itemToUpdate.Name = todo.Name;
            itemToUpdate.IsComplete = todo.IsComplete;
            _context.TodoItems.Update(itemToUpdate);
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE api/todo/{id}
        [HttpDelete("{id}", Name = "DeleteTodo")]
        public ActionResult DeleteById(long id)
        {
            var itemToDelete = _context.TodoItems.Find(id);
            if (itemToDelete == null)
            {
                return NotFound();
            }
            _context.TodoItems.Remove(itemToDelete);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
