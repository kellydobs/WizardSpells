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
        // [HttpGet("all", Name = "GetAllComments")]

        // public async Task<ActionResult<IEnumerable<UserComment>>> GetAllComments()
        // {
        //     return await _context.Comments.OrderBy(row => row.Id).ToListAsync();
        // }

        [HttpPost("create")]
        public async Task<ActionResult<UserComment>> CreateUserComment(UserComment c)
        {

            if (c.Comment.Length < 1) return BadRequest("Your comment needs words!");

            c.Comment = c.Comment.Trim();

            _context.Comments.Add(c);
            await _context.SaveChangesAsync();

            return Created("create", c);
        }


        // [HttpGet("{id}")]
        // public async Task<ActionResult<UserComment>> GetCommentById(int id)
        // {
        //     var comment = await _context.Comments.FindAsync(id);

        //     if (comment == null)
        //     {
        //         return NotFound();
        //     }
        //     return comment;
        // }


        // [HttpDelete("{id}")]
        // public async Task<ActionResult<UserComment>> DeleteUserComment(int id)
        // {
        //     var comment = await _context.Comments.FindAsync(id);
        //     //     if (comment == null) {
        //         return NotFound();
        // }

        //     _context.Comments.Remove(comment);
        //     await _context.SaveChangesAsync();
        //     // 
        // }

    }
}



