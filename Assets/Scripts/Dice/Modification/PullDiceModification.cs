using System.Collections.Generic;
using Dice.Modification;
using UnityEngine;

namespace DefaultNamespace
{
    public class PullDiceModification : MonoBehaviour
    {
        [SerializeField] private DiceModification diceModificationPrefab;
        
        private readonly List<DiceModification> _pullDiceModification = new List<DiceModification>();
        
        public DiceModification GetDiceModification()
        {
            if(_pullDiceModification.Count > 0)
                foreach (DiceModification diceModification in _pullDiceModification)
                    if (diceModification.gameObject.activeSelf == false)
                        return diceModification;

            return CreateDiceModification();
        }
        
        public void CloseAllDiceModification()
        {
            if(_pullDiceModification.Count > 0)
                foreach (DiceModification diceModification in _pullDiceModification)
                    diceModification.gameObject.SetActive(false);
        }
        
        private DiceModification CreateDiceModification()
        {
            DiceModification spawnPullObject = Instantiate(diceModificationPrefab, transform);
            spawnPullObject.gameObject.SetActive(false);
            _pullDiceModification.Add(spawnPullObject);
            
            return spawnPullObject;
        }
    }
}