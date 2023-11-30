using UnityEngine;

namespace Dice.RollLogic
{
    public class DefaultDiceRollLogic : IDiceRollLogic
    {
        public int Roll(int rollRange)
        {
            return Random.Range(0, rollRange + 1);
        }
    }
}