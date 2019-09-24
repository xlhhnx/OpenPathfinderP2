using OpenPathfinderP2.Interfaces;
using System;

namespace OpenPathfinderP2.Models
{
    public class SpellSlot
    {
        public uint MaxSpellLevel { get; }
        public ISpell PreparedSpell { get; set; }

        private SpellSlot(uint maxSpellLevel)
        {
            MaxSpellLevel = maxSpellLevel;
            PreparedSpell = new EmptySpell();
        }

        public static SpellSlot NewSpellSlot(uint maxSpellLevel) => new SpellSlot(maxSpellLevel);

        public static SpellSlot NewSpellSlot(int maxSpellLevel) => new SpellSlot(Convert.ToUInt32(maxSpellLevel));
    }
}
