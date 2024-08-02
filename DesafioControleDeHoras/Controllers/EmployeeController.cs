using AutoMapper;
using DesafioControleDeHoras.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioControleDeHoras.Controllers   
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>();
        [HttpPost]
        public void AddEmployee([FromBody] Employee employee) 
        { 
            employees.Add(employee);
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.BornDate);
        }
    }
}
