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
    [Route("/spells")]
    public class WizardSpellController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public WizardSpellController(DatabaseContext context)
        {
            _context = context;

        }
        [HttpGet("all", Name = "GetAllWizardSpell")]

        public async Task<ActionResult<List<Spell>>> GetAllSpells()
        {
            return await _context.WizardSpells.ToListAsync();
        }
    }

    [Route("/spells/{id}")]
    public class SpellSelectionController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public SpellSelectionController(DatabaseContext context)
        {
            _context = context;

        }
        [HttpGet("spell", Name = "GetWizardSpell")]

        public async Task<ActionResult<Spell>> GetSpell(int id)

        {
            var spell = await _context.WizardSpells.FindAsync(id);

            if (spell == null)
            {
                return NotFound();
            }
            return spell;
        }











    }
}


