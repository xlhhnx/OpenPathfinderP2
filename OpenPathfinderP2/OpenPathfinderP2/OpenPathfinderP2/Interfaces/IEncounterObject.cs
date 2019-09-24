using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPathfinderP2.Interfaces
{
    public interface IEncounterObject
    {
        void StartTurn();
        void EndTurn();
        void StartRound();
        void EndRound();
    }
}
