using Microsoft.AspNetCore.Mvc;
using System;
using Prueba_tecnica.Context_Test;
[ApiController]
[Route("api/[controller]")]
public class DataController : ControllerBase
{
    private readonly Context_Test _context;

    public DataController(Context_Test context)
    {
        _context = context;
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var data = _context.Data.Find(id);
        if (data == null)
        {
            return NotFound();
        }
        return Ok(data);
    }
}