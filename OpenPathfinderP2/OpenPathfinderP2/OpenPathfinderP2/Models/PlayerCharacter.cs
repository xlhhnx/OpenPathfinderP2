using OpenPathfinderP2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenPathfinderP2.Models
{
    public class PlayerCharacter :IEncounterObject, IEncounterActor
    {
        public IDictionary<AttributeName, CharacterAttribute> Attributes { get; set; }
        public IEnumerable<EquipmentSlot> EquipmentSlots { get; set; }
        public IEnumerable<IEquipable> Equipment { get => EquipmentSlots.Select(es => es.Equipment).ToList(); }
        public Inventory Inventory { get; set; }
        public IEnumerable<IFeature> Features { get; set; }
        public IEnumerable<ISpell> KnownSpells { get; set; }
        public IEnumerable<SpellSlot> SpellSlots { get; set; }
        public IEnumerable<ICondition> Conditions { get; set; }
        public float InitiativeOrder { get; set; }

        public void EndRound()
        {
            throw new NotImplementedException();
        }

        public void EndTurn()
        {
            throw new NotImplementedException();
        }

        public void StartRound()
        {
            throw new NotImplementedException();
        }

        public void StartTurn()
        {
            throw new NotImplementedException();
        }
    }
}
