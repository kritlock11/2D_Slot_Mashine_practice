using UnityEngine;
using UnityEngine.UI;

namespace Slot_Mashine_2D_test
{
    public class CardInfoUi : MonoBehaviour
    {
        [SerializeField] private CardModel _selfCard;
        [SerializeField] private int _id;
        [SerializeField] private string _name;
        [SerializeField] private Image _logo;

        public int ID { get => _id; set => _id = value; }

        private void Awake()
        {
            _logo = GetComponent<Image>();
        }

        public void ShowCardInfo(CardModel card)
        {
            _selfCard = card;
            _id = card.Id;
            _name = card.Name;
            _logo.sprite = card.Logo;
        }
    }
}
