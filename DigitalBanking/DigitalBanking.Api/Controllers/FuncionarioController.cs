using System;
using System.Collections.Generic;
using DigitalBanking.Api.Filters;
using DigitalBanking.Application.Dtos;
using DigitalBanking.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DigitalBanking.Api.Controllers
{
    /// <summary>[Authorize]
    /// </summary>
    [Route("api/Funcionarios")]
    public class FuncionarioController : Controller
    {
        private IFuncionarioAppService FuncionarioAppService { get; }
        /// <summary>
        /// Constructor to Funcionario Controller 
        /// </summary>
        /// <param name="funcionarioAppService">app service</param>
        public FuncionarioController(IFuncionarioAppService funcionarioAppService)
        {
            this.FuncionarioAppService = funcionarioAppService;
        }


        /// <summary>
        ///     Delete a funcionario by Id
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <param name="id">Person Id</param>
        /// <returns>No content</returns>
        /// <response code="204">Person deleted!</response>
        /// <response code="400">Person has missing/invalid values</response>
        /// <response code="500">Oops! Can't list your area right now</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(void), 204)]
        [ProducesResponseType(typeof(Error), 400)]
        [ProducesResponseType(typeof(Error), 500)]
        public IActionResult Delete(int id)
        {
            FuncionarioAppService.Delete(id);
            return NoContent();
        }

        /// <summary>
        /// Get all funcionario with paging, filtering and sorting.
        /// </summary>
        /// <param name="parameters"><see cref="ResourceParameters"/>
        /// Filter/Sort based on FirstName, LastName and Type
        /// </param>
        /// <returns>List of <see cref="FuncionarioDto"/> with Total Number of records.</returns>
        [HttpGet("All")]
        [ProducesResponseType(typeof(IEnumerable<FuncionarioDto>), 200)]
        [ProducesResponseType(typeof(Error), 400)]
        [ProducesResponseType(typeof(Error), 500)]
        public IActionResult GetAll()
        {
            var result = FuncionarioAppService.GetAll();

            return Ok(result);
        }

        /// <summary>
        ///     Get funcionario by Id
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <param name="id">Person Id</param>
        /// <returns>Person that has been solicited</returns>
        /// <response code="200">Person!</response>
        /// <response code="400">Person has missing/invalid values</response>
        /// <response code="500">Oops! Can't list your area right now</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(FuncionarioDto), 200)]
        [ProducesResponseType(typeof(Error), 400)]
        [ProducesResponseType(typeof(Error), 500)]
        public IActionResult GetById(int id)
        {
            var ret = FuncionarioAppService.GetById(id);
            if (ret == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(ret);
            }
        }

        /// <summary>
        ///     Create a new funcionario
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <param name="value">Person data</param>
        /// <returns>Person who has been created</returns>
        /// <response code="201">Person created!</response>
        /// <response code="400">Person has missing/invalid values</response>
        /// <response code="500">Oops! Can't list your area right now</response>
        [HttpPost]
        [ProducesResponseType(typeof(FuncionarioDto), 201)]
        [ProducesResponseType(typeof(Error), 400)]
        [ProducesResponseType(typeof(Error), 500)]
        public IActionResult Post([FromBody] FuncionarioDto value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = FuncionarioAppService.Insert(value);
            return Created("", response);
        }


        /// <summary>
        ///     Update a funcionario
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <param name="id">Person Id</param>
        /// <param name="value">Person data</param>
        /// <returns>Person who has been updated</returns>
        /// <response code="200">Person updated!</response>
        /// <response code="400">Person has missing/invalid values</response>
        /// <response code="500">Oops! Can't list your area right now</response>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(FuncionarioDto), 200)]
        [ProducesResponseType(typeof(Error), 400)]
        [ProducesResponseType(typeof(Error), 500)]
        public IActionResult Put(int id, [FromBody] FuncionarioDto value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(FuncionarioAppService.Update(id, value));
        }
    }
}
