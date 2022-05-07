using System.Collections.Generic;



namespace WizardSpellsAPI.Models
{
    public class Spell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }



        // one spell has many comments
        public List<UserComment> Comments { get; set; }
    }


}

