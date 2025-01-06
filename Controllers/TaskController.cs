using Microsoft.AspNetCore.Mvc;
using DataBalkCSharp.Data;
using DataBalkCSharp.Models;

namespace DataBalkCSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TaskController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public IActionResult GetAllTasks()
        {
            return Ok(_context.Tasks.ToList());
        }

        
        [HttpGet("{id}")]
        public IActionResult GetTaskById(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task == null) return NotFound();
            return Ok(task);
        }

        
        [HttpPost]
        public IActionResult CreateTask(UserTask task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetTaskById), new { id = task.ID }, task);
        }

        
        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, UserTask updatedTask)
        {
            var task = _context.Tasks.Find(id);
            if (task == null) return NotFound();

            task.Title = updatedTask.Title;
            task.Description = updatedTask.Description;
            task.Assignee = updatedTask.Assignee;
            task.DueDate = updatedTask.DueDate;

            _context.SaveChanges();
            return NoContent();
        }

        
        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task == null) return NotFound();

            _context.Tasks.Remove(task);
            _context.SaveChanges();
            return NoContent();
        }

       
        [HttpGet("expired")]
        public IActionResult GetExpiredTasks()
        {
            var expiredTasks = _context.Tasks.Where(t => t.DueDate < DateTime.Now).ToList();
            return Ok(expiredTasks);
        }

        
        [HttpGet("active")]
        public IActionResult GetActiveTasks()
        {
            var activeTasks = _context.Tasks.Where(t => t.DueDate >= DateTime.Now).ToList();
            return Ok(activeTasks);
        }

       
        [HttpGet("by-date")]
        public IActionResult GetTasksByDate(DateTime date)
        {
            var tasksByDate = _context.Tasks.Where(t => t.DueDate.Date == date.Date).ToList();
            return Ok(tasksByDate);
        }

        
        [HttpPost("{id}/comment")]
        public IActionResult AddComment(int id, [FromBody] string comment)
        {
            var task = _context.Tasks.Find(id);
            if (task == null) return NotFound();

            
            task.Comments.Add(comment);
            _context.SaveChanges();

            return Ok(task);
        }
        [HttpPost("{id}/attachment")]
        public IActionResult UploadAttachment(int id, IFormFile file)
        {
            var task = _context.Tasks.Find(id);
            if (task == null) return NotFound();

            
            var attachmentDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Attachments");
            if (!Directory.Exists(attachmentDirectory))
            {
                Directory.CreateDirectory(attachmentDirectory);
            }

            
            var filePath = Path.Combine(attachmentDirectory, file.FileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            
            task.Attachments.Add(filePath);
            _context.SaveChanges();

            return Ok(task);
        }

    }
}
