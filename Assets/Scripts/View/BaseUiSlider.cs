using UnityEngine;
using UnityEngine.UI;

namespace Slot_Mashine_2D_test
{
    public class BaseUiSlider : MonoBehaviour
    {
        protected Slider _slider;

        protected virtual void Awake()
        {
            _slider = GetComponent<Slider>();
        }

        public float SliderValue
        {
            set => _slider.value = value;
        }

        public float SliderMaxValue
        {
            set => _slider.maxValue = value;
        }

        public void SetActive(bool value)
        {
            _slider.gameObject.SetActive(value);
        }
    }
}
