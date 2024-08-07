using AutoMapper;
using DesafioControleDeHoras.Data;
using DesafioControleDeHoras.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DesafioControleDeHoras.Controllers   
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee employee) 
        { 
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetEmployeeById), new { id = employee.Id },employee);
        }

        [HttpGet]

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees;
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id) 
        { 
            var employee = _context.Employees.FirstOrDefault(employee => employee.Id == id);
            if (employee == null) return NotFound();
            return Ok(employee);
        }
    }
}
