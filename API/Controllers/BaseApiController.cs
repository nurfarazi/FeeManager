using API.Errors;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class BaseApiController<TEntity> : ControllerBase where TEntity : class
{
    private readonly Service<TEntity> service;

    public BaseApiController(Service<TEntity> service)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var entities = await this.service.ListAllAsync().ConfigureAwait(false);

        return Ok(entities);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var entity = await this.service.GetByIdAsync(id);

        if (entity == null)
        {
            return NotFound();
        }

        return Ok(entity);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync(TEntity entity)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new ApiResponse(400));
        }

        await this.service.AddAsync(entity);

        return Ok();
    }


    [HttpPut]
    public async Task<IActionResult> UpdateAsync(TEntity entity)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new ApiResponse(400));
        }

        await this.service.UpdateAsync(entity);

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(string id)
    {
        await this.service.DeleteAsync(id);

        return Ok();
    }
}