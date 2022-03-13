using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WizardSpellsAPI.Models;



namespace WizardSpellsAPI.Controllers
{
    [ApiController]
    [Route("/comments")]
    public class CommentsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public CommentsController(DatabaseContext context)
        {
            _context = context;

        }
        [HttpGet("all", Name = "GetAllComments")]

        public async Task<ActionResult<List<Comment>>> GetAllSComments()
        {
            return await _context.Comments.ToListAsync();
        }
    }
} 
