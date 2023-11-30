using System;
using System.Collections.Generic;
using Dice.Modification;
using UnityEngine;

namespace Dice.Window
{
    [Serializable]
    public struct DiceWindowData
    {
        [SerializeField] private string titleName;
        [SerializeField] private int lossRollRange;
        [SerializeField,Range(0,20)] private int rollRange;
        [SerializeField] private List<DiceModificationData> diceModificationList;
        
        public string TitleName => titleName;
        public int LossRollRange => lossRollRange;
        public int RollRange => rollRange;
        public List<DiceModificationData> DiceModificationList => diceModificationList;
    }
}