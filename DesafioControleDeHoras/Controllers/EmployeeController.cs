using AutoMapper;
using DesafioControleDeHoras.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DesafioControleDeHoras.Controllers   
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>();
        private static int id = 0;
        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee employee) 
        { 
            employee.Id = id++;
            employees.Add(employee);
            return CreatedAtAction(nameof(GetEmployeeById), new { id = employee.Id },employee);
        }

        [HttpGet]

        public IEnumerable<Employee> GetEmployees()
        {
            return employees;
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id) 
        { 
            var employee = employees.FirstOrDefault(employee => employee.Id == id);
            if (employee == null) return NotFound();
            return Ok(employee);
        }
    }
}
