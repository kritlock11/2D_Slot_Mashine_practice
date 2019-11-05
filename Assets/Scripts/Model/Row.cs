using System;
using System.Collections;
using System.Linq;
using UnityEngine;


namespace Slot_Mashine_2D_test
{
    public class Row : MonoBehaviour
    {
        private Main Main;
        private RectTransform _transformRect;
        private ButtonsUiManager ButtonsUiManager;

        [SerializeField] private RowNumber _rowNumber;

        private int _randomStopValue = 0;
        private int _randomCirclesStopValue = 0;

        private int _minStopValue;
        private int _maxStopValue;
        private int _minCirclesStopValue;
        private int _maxCirclesStopValue;

        private int _rowMinLocalPosition = 100;
        private int _rowMaxLocalPosition;

        private float _routineStartTimer;

        private float _timeInternal = 0.01f;
        private bool _rowStopped;
        private CardInfoUi _stoppedSlot;

        public bool RowStopped { get => _rowStopped; private set => _rowStopped = value; }
        public CardInfoUi StoppedSlot { get => _stoppedSlot; private set => _stoppedSlot = value; }

        private void Awake()
        {
            _rowStopped = true;
            Main = ServiceLocator.GetService<Main>();
            _transformRect = GetComponent<RectTransform>();
            ButtonsUiManager = ServiceLocator.GetService<ButtonsUiManager>();
            GetRowSettings(_rowNumber);
        }

        private void OnEnable()
        {
            ButtonsUiManager.SpinButtonPressed += StartRoating;
        }

        private void OnDisable()
        {
            ButtonsUiManager.SpinButtonPressed -= StartRoating;
        }

        public void StartRoating()
        {
            if (Main.GameControl.Spins <= 0
                && Main.GameControl.SliderSpins <= 0
                || Main.GameControl.SliderSpins < Main.GameControl.Bet)
            {
                return;
            }

            Invoke((nameof(CoroutineStart)), _routineStartTimer);
        }

        private void CoroutineStart()
        {
            StartCoroutine(nameof(Rotate));
        }

        private void GetRowSettings(RowNumber rowNumber)
        {
            switch (rowNumber)
            {
                case RowNumber.First:
                    _minCirclesStopValue = 10;
                    _maxCirclesStopValue = 17;
                    _minStopValue = 3;
                    _maxStopValue = 7;
                    _routineStartTimer = 0;
                    break;

                case RowNumber.Second:
                    _minCirclesStopValue = 15;
                    _maxCirclesStopValue = 20;
                    _minStopValue = 7;
                    _maxStopValue = 13;
                    _routineStartTimer = 0.1f;
                    break;

                case RowNumber.Third:
                    _minCirclesStopValue = 20;
                    _maxCirclesStopValue = 30;
                    _minStopValue = 8;
                    _maxStopValue = 30;
                    _routineStartTimer = 0.2f;
                    break;

                default:
                    _minCirclesStopValue = 0;
                    _maxCirclesStopValue = 0;
                    _minStopValue = 0;
                    _maxStopValue = 0;
                    _routineStartTimer = 0;
                    break;
            }
        }

        private void GetMaxLocalPosition(Action callback)
        {
            _rowMaxLocalPosition = (Main.CardPoolController.CardsInRowPoolSize - 3) * 70 + _rowMinLocalPosition;
            callback();
        }

        private void GetRandomCirclesStopValue(out int _randomCirclesStopValue, out int _randomStopValue)
        {
            _randomCirclesStopValue = UnityEngine.Random.Range(_minCirclesStopValue, _maxCirclesStopValue);
            _randomStopValue = UnityEngine.Random.Range(_minStopValue, _maxStopValue);

            switch (_randomCirclesStopValue % 2)
            {
                case 1:
                    _randomCirclesStopValue += 1;
                    break;
            }

            switch (_randomStopValue % 5)
            {
                case 1:
                    _randomStopValue += 4;
                    break;
                case 2:
                    _randomStopValue += 3;
                    break;
                case 3:
                    _randomStopValue += 2;
                    break;
                case 4:
                    _randomStopValue += 1;
                    break;
            }
        }

        private IEnumerator Rotate()
        {
            _rowStopped = false;

            GetMaxLocalPosition(() => Debug.Log($"{_rowMaxLocalPosition}"));

            GetRandomCirclesStopValue(out _randomCirclesStopValue, out _randomStopValue);

            for (int i = 0; i < _randomCirclesStopValue; i++)
            {
                if (_transformRect.localPosition.y <= _rowMinLocalPosition)
                {
                    _transformRect.localPosition = new Vector2(_transformRect.localPosition.x, _rowMaxLocalPosition);
                }

                _transformRect.localPosition = new Vector2(_transformRect.localPosition.x, _transformRect.localPosition.y - 35f);
                yield return new WaitForSeconds(_timeInternal);
            }

            for (int i = 0; i < _randomStopValue; i++)
            {
                if (_transformRect.localPosition.y <= _rowMinLocalPosition)
                {
                    _transformRect.localPosition = new Vector2(_transformRect.localPosition.x, _rowMaxLocalPosition);
                }

                _transformRect.localPosition = new Vector2(_transformRect.localPosition.x, _transformRect.localPosition.y - 14f);
                yield return new WaitForSeconds(_timeInternal);
            }

            _stoppedSlot = Main.CardPoolController.RowPool.Where(w => w.transform.localPosition.y == -_transformRect.localPosition.y).ToArray()[0];

            _rowStopped = true;
        }
    }
}