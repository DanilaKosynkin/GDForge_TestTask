using System;
using UnityEngine;

namespace Dice.Modification
{
    [Serializable]
    public struct DiceModificationData
    {
        [SerializeField] private string nameModification;
        [SerializeField] private int valueModification;

        public string NameModification => nameModification;
        public int ValueModification => valueModification;
    }
}