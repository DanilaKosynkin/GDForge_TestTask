using System;
using Dice.Window;
using UnityEngine;
using UnityEngine.UI;

namespace Dice
{
    public class SetupWindowDataButton : MonoBehaviour
    {
        [SerializeField] private DiceWindowData diceWindowData;
        [SerializeField] private DiceWindow diceWindow;

        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(ClickButton);
        }

        private void OnDestroy()
        {
            GetComponent<Button>().onClick.RemoveListener(ClickButton);
        }

        public void ClickButton()
        {
            diceWindow.SetupWindowData(diceWindowData);
        }
    }
}