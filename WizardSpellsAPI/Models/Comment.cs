using System;


namespace WizardSpellsAPI.Models
{
    public class UserComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; private set; } = DateTime.Now;
        public int SpellId { get; set; }

        public Spell Spell { get; set; }
    }
}










//old code, above code is from Gavin's lecture
// public class UserComment
// {
//     public int ID { get; set; }
//     public string Comment { get; set; }
//     public string Spell { get; set; }
//     public DateTime Time { get; set; }
//     public int UserId { get; set; }
//     public int SpellId { get; set; }

// }

