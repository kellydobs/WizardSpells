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

        public async Task<ActionResult<IEnumerable<Spell>>> GetAllSpells(string filter)
        {
            //use the db context in _contest to request all spells, sort
            //them by row id and return them as a JSON array.
            if (filter == null)
            {
                return await _context.WizardSpells.
                OrderBy(row => row.Id).
                Include(spell => spell.Comments).
                ToListAsync();
            }
            else
            {
                //return the filtered list of spells
                return await _context.WizardSpells.
                OrderBy(row => row.Id).
                Where(Spell => Spell.Name.ToLower().Contains(filter.ToLower())).
                Include(Spell => Spell.Comments).
                ToListAsync();
            }
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
            var spell = await _context.WizardSpells.
            Where(spell => spell.Id == id).
            Include(spell => spell.Comments).
            FirstOrDefaultAsync();

            if (spell == null)
            {
                return NotFound();
            }
            return spell;
        }











    }
}


