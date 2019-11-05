using System;
using UnityEngine;
using System.Collections.Generic;

namespace Slot_Mashine_2D_test
{
    public class GameController : BaseController, IOnStart, IOnUpdate
    {
        private List<Row> _row;

        private bool _resultsChecked;
        private bool _rowInAction;

        private int _prizeValue;
        private int _totalGoldValue;

        private int _keyValue;
        private int _treasureValue;
        private int _letterValue;
        private int _mapValue;
        private int _attackValue;
        private int _defenceValue;
        private int _totalMatches = 1;

        private int _bet = 1;
        private bool _BetGoUp = true;

        private int _sliderSpins = 50;
        private int _maxSliderSpins = 50;
        private int _spins = 100;

        public event Action OnKeyFind;
        public event Action OnMapFind;
        public event Action OnWinTextOn;
        public event Action OnBetChange;
        public event Action OnWinTextOff;
        public event Action OnLetterFind;
        public event Action OnAttackFind;
        public event Action OnDefenceFind;
        public event Action OnSpinsChange;
        public event Action OnWinHighlight;
        public event Action OnTreasureFind;
        public event Action OnSliderSpinsChange;

        public int KeyValue { get => _keyValue; private set => _keyValue = value; }
        public int MapValue { get => _mapValue; private set => _mapValue = value; }
        public int PrizeValue { get => _prizeValue; private set => _prizeValue = value; }
        public int LetterValue { get => _letterValue; private set => _letterValue = value; }
        public int AttackValue { get => _attackValue; private set => _attackValue = value; }
        public int DefenceValue { get => _defenceValue; private set => _defenceValue = value; }
        public int TotalMatches { get => _totalMatches; private set => _totalMatches = value; }
        public int TreasureValue { get => _treasureValue; private set => _treasureValue = value; }
        public int TotalGoldValue { get => _totalGoldValue; private set => _totalGoldValue = value; }
        public int MaxSliderSpins { get => _maxSliderSpins; private set => _maxSliderSpins = value; }
        public int Spins
        {
            get => _spins;
            private set
            {
                _spins = Mathf.Clamp(value, 0, 99999);
                OnSpinsChange?.Invoke();
            }
        }

        public int Bet
        {
            get => _bet;
            private set
            {
                _bet = Mathf.Clamp(value, 1, 15);
                OnBetChange?.Invoke();
            }
        }

        public int SliderSpins
        {
            get => _sliderSpins;
            private set
            {
                _sliderSpins = Mathf.Clamp(value, 0, 50);
                OnSliderSpinsChange?.Invoke();
            }
        }

        public void OnStart()
        {
            _row = Main.CardPoolController.Row;
            _sliderSpins = _maxSliderSpins;
            var buttonsUiManager = ServiceLocator.GetService<ButtonsUiManager>();

            buttonsUiManager.BetButtonPressed += BetUpOrDown;
            buttonsUiManager.SpinButtonPressed += SpinsGetDown;
            buttonsUiManager.SpinButtonPressed += RowInAction;
        }

        public void OnUpdate()
        {
            if (_row[0].RowStopped && _row[1].RowStopped && _row[2].RowStopped)
            {
                if (!_resultsChecked)
                {
                    CheckResults();
                    GetTotalValue();
                    OnWinTextOn?.Invoke();
                }
            }
            else if (!_rowInAction)
            {
                OnWinTextOff?.Invoke();
                _resultsChecked = false;
                _rowInAction = true;
            }

            #region ForDebuging
            //if (_row[0].RowStopped && _row[1].RowStopped && _row[2].RowStopped) //автоспам
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        _row[i].StartRoating();
            //    }
            //}
            #endregion
        }

        private void BetUpOrDown()
        {
            if (_BetGoUp && Bet < 15)
            {
                Bet++;
            }
            else if (!_BetGoUp && Bet < 15 && Bet > 1)
            {
                Bet--;
            }
            else if (Bet >= 15)
            {
                _BetGoUp = false;
                Bet--;
            }
            else if (_BetGoUp && Bet >= 1)
            {
                Bet++;
            }
            else if (Bet == 1)
            {
                _BetGoUp = true;
                Bet++;
            }
        }

        private void SpinsGetDown()
        {
            if (Spins > 0 && Spins >= Bet)
            {
                Spins -= Bet;
            }

            else if (Spins > 0 && Spins <= Bet)
            {
                var r = Bet - Spins;
                Spins = 0;

                if (SliderSpins >= r)
                {
                    SliderSpins -= r;
                }

            }

            else if (Spins == 0)
            {
                if (SliderSpins >= Bet)
                {
                    SliderSpins -= Bet;
                }
            }
        }

        private void CheckResults()
        {
            if (_row[0].StoppedSlot == null || _row[1].StoppedSlot == null || _row[2].StoppedSlot == null)
            {
                _resultsChecked = true;
                return;
            }

            if (_row[0].StoppedSlot.ID == _row[1].StoppedSlot.ID && _row[0].StoppedSlot.ID == _row[2].StoppedSlot.ID)
            {
                OnWinHighlight?.Invoke();
                switch (_row[0].StoppedSlot.ID)
                {
                    case 1:
                        _prizeValue = 200 * Bet;
                        _totalMatches++;
                        break;
                    case 2:
                        _prizeValue = 300 * Bet;
                        _totalMatches++;
                        break;
                    case 3:
                        _prizeValue = 400 * Bet;
                        SpinsGetUp(50 * Bet);
                        _totalMatches++;
                        break;
                    case 4:
                        _prizeValue = 500 * Bet;
                        _treasureValue++;
                        _totalMatches++;
                        OnTreasureFind?.Invoke();
                        break;
                    case 5:
                        _prizeValue = 600 * Bet;
                        _attackValue++;
                        _totalMatches++;
                        OnAttackFind?.Invoke();
                        break;
                    case 6:
                        _prizeValue = 700 * Bet;
                        _defenceValue++;
                        _totalMatches++;
                        OnDefenceFind?.Invoke();
                        break;
                    case 7:
                        _prizeValue = 800 * Bet;
                        _keyValue++;
                        _totalMatches++;
                        OnKeyFind?.Invoke();
                        break;
                    case 8:
                        _prizeValue = 900 * Bet;
                        _mapValue++;
                        _totalMatches++;
                        OnMapFind?.Invoke();
                        break;
                    case 9:
                        _prizeValue = 1000 * Bet;
                        _letterValue++;
                        _totalMatches++;
                        OnLetterFind?.Invoke();
                        break;

                    default:
                        _prizeValue = 0;
                        break;
                }
            }

            else
            {
                _prizeValue = 10 * Bet;
            }

            _resultsChecked = true;
        }

        public void SpinsGetUp(int spinBonus)
        {
            if (SliderSpins < MaxSliderSpins)
            {
                var r = MaxSliderSpins - SliderSpins;
                if (spinBonus > r)
                {
                    SliderSpins = MaxSliderSpins;
                    Spins += (spinBonus - r);
                }
            }
            else
            {
                Spins += spinBonus;
            }
        }

        private void RowInAction() => _rowInAction = false;

        private void GetTotalValue() => _totalGoldValue += _prizeValue;
    }
}
