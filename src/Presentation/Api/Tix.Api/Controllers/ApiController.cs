using Microsoft.AspNetCore.Mvc;

namespace Tix.Api.Controllers;

public abstract class ApiController : ControllerBase
{
}

public abstract class ApiController<TEntity, TId> : ApiController
{
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(TId id)
    {
        await Task.Run(() => {});
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        await Task.Run(() => {});
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Search()
    {
        await Task.Run(() => {});
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Create()
    {
        await Task.Run(() => {});
        return Ok();
    }

    [HttpPost("batch")]
    public async Task<IActionResult> CreateRange()
    {
        await Task.Run(() => {});
        return Ok();
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> Update(TId id)
    {
        await Task.Run(() => {});
        return Ok();
    }

    [HttpPatch]
    public async Task<IActionResult> UpdateRange()
    {
        await Task.Run(() => {});
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(TId id)
    {
        await Task.Run(() => {});
        return NoContent();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteRange()
    {
        await Task.Run(() => {});
        return NoContent();
    }
}