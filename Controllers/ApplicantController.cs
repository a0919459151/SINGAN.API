using Microsoft.AspNetCore.Mvc;
using SINGAN.API.EFCore;

namespace SINGAN.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApplicantController : ControllerBase
{
    private readonly ApplicantDbContext _context;

    public ApplicantController(ApplicantDbContext context)
    {
        _context = context;
    }

    [HttpGet()]
    public IActionResult GetAll()
    {
        var res = _context.Applicants!.Select(x => new
        {
            x.Id,
            x.ChineseName,
            x.IdentificationNumber,
            x.Email,
            x.MobilePhone
        }).ToList();

        return Ok(res);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var res = _context.Applicants!.FirstOrDefault(x => x.Id == id);
        return Ok(res);
    }

    [HttpPost()]
    public IActionResult Create(Applicant applicant)
    {
        _context.Applicants!.Add(applicant);
        _context.SaveChanges();
        return Ok();
    }
}