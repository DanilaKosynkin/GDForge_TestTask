using TMPro;
using UnityEngine;

namespace Dice.Modification
{
    public class DiceModification : MonoBehaviour
    {
        [SerializeField] private TMP_Text nameModification;
        [SerializeField] private TMP_Text valueModification;

        public DiceModificationData DiceModificationData { get; private set; }
        
        public void SetupDiceModification(DiceModificationData modificationData)
        {
            DiceModificationData = modificationData;
            
            nameModification.text = DiceModificationData.NameModification;
            valueModification.text = DiceModificationData.ValueModification.ToString();
        }
    }
}