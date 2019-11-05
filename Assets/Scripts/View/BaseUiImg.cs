using UnityEngine;
using UnityEngine.UI;

namespace Slot_Mashine_2D_test
{
    public abstract class BaseUiImg : MonoBehaviour
{
        protected Image _img;
        public Sprite Sprite { get => _img.sprite; set => _img.sprite = value; }
        public Image Image { get => _img; set => _img = value; }

        protected virtual void Start()
        {
            _img = GetComponent<Image>();
        }

        public virtual void SetActive(bool value)
        {
            Image.enabled = value;
        }
    }
}
