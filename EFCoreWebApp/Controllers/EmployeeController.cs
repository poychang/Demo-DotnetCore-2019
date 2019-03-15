using EFCoreWebApp.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EFCoreWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeContext _context;
        public EmployeeController(EmployeeContext context)
        {
            _context = context;
        }
        // GET: api/Employee
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return new JsonResult(await _context.Employees.ToListAsync());
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return new JsonResult(_context.Employees.Find(id));
        }

        // POST: api/Employee
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Employee employee)
        {
            if (!ModelState.IsValid) return new JsonResult(employee);

            if (employee.Id == 0)
            {
                _context.Add(employee);
            }
            else
            {
                _context.Update(employee);
            }

            await _context.SaveChangesAsync();

            return new JsonResult(employee);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var employee = await _context.Employees.FindAsync(id);

            _context.Employees.Remove(employee);

            await _context.SaveChangesAsync();

            return Ok($"Employee {id} is deleted.");
        }
    }
}
