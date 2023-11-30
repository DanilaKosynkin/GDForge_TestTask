using Dice.Window;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Dice
{
    public class DiceClick : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private DiceWindow diceWindow;
        
        public void OnPointerDown(PointerEventData eventData)
        {
            diceWindow.DiceRoll();
        }
    }
}