using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CloudForge.Api.Models;

[Route("api/[controller]")]
[ApiController]
public class InstancesController : ControllerBase
{
    private readonly InstancesContext _context;
    public InstancesController(InstancesContext context)
    {
        _context = context;
    }

    // GET: api/Instances
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Instances>>> GetInstances()
    {
        return await _context.Instances.ToListAsync();
    }

    // GET: api/Instances/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Instances>> GetInstances(long id)
    {
        var instances = await _context.Instances.FindAsync(id);

        if (instances == null)
        {
            return NotFound();
        }

        return instances;
    }

    // PUT: api/Instances/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutInstances(long? id, Instances instances)
    {
        if (id != instances.Id)
        {
            return BadRequest();
        }

        _context.Entry(instances).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!InstancesExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Instances
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Instances>> PostInstances(Instances instances)
    {
        _context.Instances.Add(instances);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetInstances", new { id = instances.Id }, instances);
    }

    // DELETE: api/Instances/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteInstances(long? id)
    {
        var instances = await _context.Instances.FindAsync(id);
        if (instances == null)
        {
            return NotFound();
        }

        _context.Instances.Remove(instances);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool InstancesExists(long? id)
    {
        return _context.Instances.Any(e => e.Id == id);
    }
}
