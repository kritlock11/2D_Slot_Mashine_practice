using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Slot_Mashine_2D_test
{
    public class SpinButtonClick : MonoBehaviour
    {
        [SerializeField] private Button _spin;

        private void OnEnable()
        {
            _spin.onClick.AddListener(Spin_OnClick);
        }

        private void OnDisable()
        {
            _spin.onClick.RemoveListener(Spin_OnClick);
        }

        private void Spin_OnClick()
        {

        }
    }
}
