using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Slot_Mashine_2D_test
{
    public class ButtonsUiManager : MonoBehaviour
    {
        private Main Main;

        public event Action SpinButtonPressed;
        public event Action BetButtonPressed;

        [SerializeField] private Button _spin;
        [SerializeField] private Button _bet;
        [SerializeField] private Button _exit;

        public void OnEnable()
        {
            Main = ServiceLocator.GetService<Main>();
            _spin.onClick.AddListener(Spin_OnClick);
            _bet.onClick.AddListener(Bet_OnClick);
            _exit.onClick.AddListener(Exit_OnClick);
        }

        public void OnDisable()
        {
            _spin.onClick.RemoveListener(Spin_OnClick);
            _bet.onClick.RemoveListener(Bet_OnClick);
            _exit.onClick.RemoveListener(Exit_OnClick);
        }

        private void Spin_OnClick()
        {
            var row = ServiceLocator.GetService<Main>().CardPoolController.Row;
            if (row[0].RowStopped && row[1].RowStopped && row[2].RowStopped)
            {
                SpinButtonPressed?.Invoke();
            }
        }

        private void Bet_OnClick()
        {
            BetButtonPressed?.Invoke();
        }

        private void Exit_OnClick()
        {
            if (EditorApplication.isPlaying)
            {
                Main.UiController.UnSubscribe();
                EditorApplication.isPlaying = false;
            }
            else
            {
                Main.UiController.UnSubscribe();
                Application.Quit();
            }
        }
    }
}
