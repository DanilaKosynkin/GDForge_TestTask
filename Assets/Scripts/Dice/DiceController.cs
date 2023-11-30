using Dice.RollLogic;
using UnityEngine;

namespace Dice
{
    public class DiceController : MonoBehaviour
    {
        private IDiceRollLogic _diceRollLogic = new DefaultDiceRollLogic();
        
        public int DiceRoll(int rollRange)
        {
            return _diceRollLogic.Roll(rollRange);
        }

        public void SetupDiceRollLogic(IDiceRollLogic diceRollLogic)
        {
            _diceRollLogic = diceRollLogic;
        }
    }
}