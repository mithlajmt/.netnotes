﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.contexts;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Dtos;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly EmpContext empContext;

        // Constructor injection of the EmpContext
        public EmpController(EmpContext dbcontext)
        {
            this.empContext = dbcontext;
        }

        // GET api/emp 
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            try
            {
                // Retrieve all employees from the database asynchronously
                var employees = await empContext.Employees.ToListAsync();

                // Return the list of employees with a 200 OK status
                return Ok(employees);
            }
            catch (Exception ex)
            {
                // Handle any errors and return a 500 Internal Server Error status
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // POST api/emp
        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] AddEmployeeDto employeeDto)
        {
            // Create a new employee entity from the DTO
            var employeeEntity = new Employees()
            {
                Name = employeeDto.Name,
                Email = employeeDto.Email,
                Phone = employeeDto.PhoneNumber, 
            };

            // Asynchronously add the new employee to the database context
            await empContext.Employees.AddAsync(employeeEntity);

            // Asynchronously save changes to the database
            await empContext.SaveChangesAsync();

            // Return the created employee with a 201 Created status
            return CreatedAtAction(nameof(GetAllEmployees), new { id = employeeEntity.Id }, employeeEntity);
        }
    }
}
