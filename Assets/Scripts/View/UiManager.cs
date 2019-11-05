using UnityEngine;

namespace Slot_Mashine_2D_test
{
    public class UiManager
    {

        private LvlUiText _lvlUiText;
        public LvlUiText LvlUiText
        {
            get
            {
                if (!_lvlUiText)
                    _lvlUiText = Object.FindObjectOfType<LvlUiText>();
                return _lvlUiText;
            }
        }

        private WinUiText _winUiText;
        public WinUiText WinUiText
        {
            get
            {
                if (!_winUiText)
                    _winUiText = Object.FindObjectOfType<WinUiText>();
                return _winUiText;
            }
        }

        private TotalGoldUiText _totalGoldUiText;
        public TotalGoldUiText TotalGoldUiText
        {
            get
            {
                if (!_totalGoldUiText)
                    _totalGoldUiText = Object.FindObjectOfType<TotalGoldUiText>();
                return _totalGoldUiText;
            }
        }

        private TotalGoldUiImg _totalGoldUiImg;
        public TotalGoldUiImg TotalGoldUiImg
        {
            get
            {
                if (!_totalGoldUiImg)
                    _totalGoldUiImg = Object.FindObjectOfType<TotalGoldUiImg>();
                return _totalGoldUiImg;
            }
        }

        private AttackUiImg _attackUiImg;
        public AttackUiImg AttackUiImg
        {
            get
            {
                if (!_attackUiImg)
                    _attackUiImg = Object.FindObjectOfType<AttackUiImg>();
                return _attackUiImg;
            }
        }

        private AttackUiText _attackUiText;
        public AttackUiText AttackUiText
        {
            get
            {
                if (!_attackUiText)
                    _attackUiText = Object.FindObjectOfType<AttackUiText>();
                return _attackUiText;
            }
        }

        private DefenceUiImg _defenceUiImg;
        public DefenceUiImg DefenceUiImg
        {
            get
            {
                if (!_defenceUiImg)
                    _defenceUiImg = Object.FindObjectOfType<DefenceUiImg>();
                return _defenceUiImg;
            }
        }

        private DefenceUiText _defenceUiText;
        public DefenceUiText DefenceUiText
        {
            get
            {
                if (!_defenceUiText)
                    _defenceUiText = Object.FindObjectOfType<DefenceUiText>();
                return _defenceUiText;
            }
        }

        private KeyUiImg _keyUiImg;
        public KeyUiImg KeyUiImg
        {
            get
            {
                if (!_keyUiImg)
                    _keyUiImg = Object.FindObjectOfType<KeyUiImg>();
                return _keyUiImg;
            }
        }

        private KeyUiText _keyUiText;
        public KeyUiText KeyUiText
        {
            get
            {
                if (!_keyUiText)
                    _keyUiText = Object.FindObjectOfType<KeyUiText>();
                return _keyUiText;
            }
        }

        private LetterUiImg _letterUiImg;
        public LetterUiImg LetterUiImg
        {
            get
            {
                if (!_letterUiImg)
                    _letterUiImg = Object.FindObjectOfType<LetterUiImg>();
                return _letterUiImg;
            }
        }

        private LetterUiText _letterUiText;
        public LetterUiText LetterUiText
        {
            get
            {
                if (!_letterUiText)
                    _letterUiText = Object.FindObjectOfType<LetterUiText>();
                return _letterUiText;
            }
        }

        private MapUiImg _mapUiImg;
        public MapUiImg MapUiImg
        {
            get
            {
                if (!_mapUiImg)
                    _mapUiImg = Object.FindObjectOfType<MapUiImg>();
                return _mapUiImg;
            }
        }

        private MapUiText _mapUiText;
        public MapUiText MapUiText
        {
            get
            {
                if (!_mapUiText)
                    _mapUiText = Object.FindObjectOfType<MapUiText>();
                return _mapUiText;
            }
        }

        private TreasureUiImg _treasureUiImg;
        public TreasureUiImg TreasureUiImg
        {
            get
            {
                if (!_treasureUiImg)
                    _treasureUiImg = Object.FindObjectOfType<TreasureUiImg>();
                return _treasureUiImg;
            }
        }

        private TreasureUiText _treasureUiText;
        public TreasureUiText TreasureUiText
        {
            get
            {
                if (!_treasureUiText)
                    _treasureUiText = Object.FindObjectOfType<TreasureUiText>();
                return _treasureUiText;
            }
        }

        private BetUiText _betUiText;
        public BetUiText BetUiText
        {
            get
            {
                if (!_betUiText)
                    _betUiText = Object.FindObjectOfType<BetUiText>();
                return _betUiText;
            }
        }

        private SpinButtonUiText _spinButtonUiText;
        public SpinButtonUiText SpinButtonUiText
        {
            get
            {
                if (!_spinButtonUiText)
                    _spinButtonUiText = Object.FindObjectOfType<SpinButtonUiText>();
                return _spinButtonUiText;
            }
        }

        private SpinsSliderUiText _spinsSliderUiText;
        public SpinsSliderUiText SpinsSliderUiText
        {
            get
            {
                if (!_spinsSliderUiText)
                    _spinsSliderUiText = Object.FindObjectOfType<SpinsSliderUiText>();
                return _spinsSliderUiText;
            }
        }

        private SpinsUiText _spinsUiText;
        public SpinsUiText SpinsUiText
        {
            get
            {
                if (!_spinsUiText)
                    _spinsUiText = Object.FindObjectOfType<SpinsUiText>();
                return _spinsUiText;
            }
        }

        private SpinsSliderUi _spinsSliderUi;
        public SpinsSliderUi SpinsSliderUi
        {
            get
            {
                if (!_spinsSliderUi)
                    _spinsSliderUi = Object.FindObjectOfType<SpinsSliderUi>();
                return _spinsSliderUi;
            }
        }

        private WinHighLightUiImg _winHighLightUiImg;
        public WinHighLightUiImg WinHighLightUiImg
        {
            get
            {
                if (!_winHighLightUiImg)
                    _winHighLightUiImg = Object.FindObjectOfType<WinHighLightUiImg>();
                return _winHighLightUiImg;
            }
        }
    }
}

