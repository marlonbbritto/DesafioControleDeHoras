using AutoMapper;
using DesafioControleDeHoras.Data;
using DesafioControleDeHoras.Data.Dtos;
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
        private IMapper _mapper;

        public EmployeeController(EmployeeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] CreateEmployeeDto employeeDto) 
        { 
            Employee employee = _mapper.Map<Employee>(employeeDto);
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
