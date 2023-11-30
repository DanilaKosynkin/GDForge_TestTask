using System;
using Dice.Modification;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Dice.Window
{
    public class DiceWindow : MonoBehaviour
    {
        public event Action<bool> OnDiceResult; 
        
        [SerializeField] private DiceController diceController;
        [SerializeField] private TMP_Text lossDiceRollRangeText;
        [SerializeField] private TMP_Text diceRollText;
        [SerializeField] private TMP_Text modificationBonusText;
        [SerializeField] private DiceModificationWindow diceModificationWindow;
        [SerializeField] private Button continueButton;

        private int _bonusModification;
        private int _resultDiceRoll;
        private DiceWindowData _diceWindowData;
        private Animator _diceWindowAnimator;
        private bool _isReadyRoll = true;

        private void Start()
        {
            _diceWindowAnimator = GetComponent<Animator>();
        }

        public void DiceRoll()
        {
            if(_isReadyRoll == false) return;
            
            _isReadyRoll = false;
            _diceWindowAnimator.SetBool("isDiceClick",true);
            
            _resultDiceRoll = diceController.DiceRoll(_diceWindowData.RollRange);
            diceRollText.text = _resultDiceRoll.ToString();

            if (_resultDiceRoll + _bonusModification >= _diceWindowData.LossRollRange)
            {
                OnDiceResult?.Invoke(true);
                _diceWindowAnimator.SetBool("isDiceRollWin", true);
            }
            else
            {
                OnDiceResult?.Invoke(false);
            }
        }

        public void BonusAmount()
        {
            _resultDiceRoll += _bonusModification;
            diceRollText.text = _resultDiceRoll.ToString();
            continueButton.gameObject.SetActive(true);
        }
        
        public void SetupWindowData(DiceWindowData diceWindowData)
        {
            ResetData();
            
            gameObject.SetActive(true);
            _diceWindowData = diceWindowData;
            diceModificationWindow.SetupModification(_diceWindowData.DiceModificationList);
            lossDiceRollRangeText.text = diceWindowData.LossRollRange.ToString();
            
            foreach (DiceModificationData modificationData in _diceWindowData.DiceModificationList)
            {
                _bonusModification += modificationData.ValueModification;
            }
            modificationBonusText.text = "Бонус " + _bonusModification.ToString();
        }

        private void ResetData()
        {
            _bonusModification = 0;
            _resultDiceRoll = 0;
            _isReadyRoll = true;
        }
    }
}