using System;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

namespace Dice.Modification
{
    [RequireComponent(typeof(PullDiceModification))]
    public class DiceModificationWindow : MonoBehaviour
    {
        [SerializeField] private PullDiceModification _pullDiceModification;

        private void Start()
        {
            _pullDiceModification = _pullDiceModification.GetComponent<PullDiceModification>();
        }

        public void SetupModification(List<DiceModificationData> diceModification)
        {
            _pullDiceModification.CloseAllDiceModification();

            SpawnDiceModification(diceModification);
        }

        private void SpawnDiceModification(List<DiceModificationData> diceModification)
        {
            foreach (DiceModificationData modificationData in diceModification)
            {
                DiceModification spawnDiceModification = _pullDiceModification.GetDiceModification();
                spawnDiceModification.gameObject.SetActive(true);
                spawnDiceModification.SetupDiceModification(modificationData);
            }
        }
    }
}