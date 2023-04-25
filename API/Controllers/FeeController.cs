using Core.Entity;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class FeeController : BaseApiController<Fee>
{
    public FeeController(Service<Fee> service) : base(service)
    {
    }
}