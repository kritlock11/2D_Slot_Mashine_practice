using UnityEngine;
using TMPro;

namespace Slot_Mashine_2D_test
{
    public abstract class BaseUiText : MonoBehaviour
{
        protected TextMeshProUGUI _text;

        protected virtual void Awake()
        {
            _text = GetComponent<TextMeshProUGUI>();
        }

        public string Text
        {
            set => _text.text = $"{value}";
        }

        public Color Color
        {
            set => _text.color = value;
        }

        public int Size
        {
            set => _text.fontSize = value;
        }

        public void SetActive(bool value)
        {
            _text.gameObject.SetActive(value);
        }
    }
}
