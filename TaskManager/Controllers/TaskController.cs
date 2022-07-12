using TaskManager.Models;
using TaskManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    public TaskController()
    {

    }

    // GET
    [HttpGet]
    public ActionResult<List<Models.Task>> GetAll() =>
        TaskService.GetAll();

    // POST
    [HttpPost]
    public IActionResult Create(Models.Task task)
    {
        TaskService.Add(task);
        return CreatedAtAction(nameof(Create), new { id = task.Id }, task);
    }
}