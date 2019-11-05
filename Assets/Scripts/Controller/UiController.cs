namespace Slot_Mashine_2D_test
{
    public class UiController : BaseController, IOnStart
    {
        public void OnStart()
        {
            Main.GameControl.OnWinTextOn += WinTextOn;
            Main.GameControl.OnWinTextOff += WinTextOff;
            Main.GameControl.OnBetChange += BetChangeText;
            Main.GameControl.OnWinHighlight += HighlightOn;
            Main.GameControl.OnKeyFind += KeyFindCountText;
            Main.GameControl.OnMapFind += MapFindCountText;
            Main.GameControl.OnSpinsChange += SpinsChangeText;
            Main.GameControl.OnLetterFind += LetterFindCountText;
            Main.GameControl.OnAttackFind += AttackFindCountText;
            Main.GameControl.OnDefenceFind += DefenceFindCountText;
            Main.GameControl.OnTreasureFind += TreasureFindCountText;
            Main.GameControl.OnSliderSpinsChange += SliderSpinsChangeText;

            ServiceLocator.GetService<ButtonsUiManager>().SpinButtonPressed += HighlightOff;


            UiManager.WinUiText.Text = "";
            UiManager.KeyUiText.Text = "";
            UiManager.MapUiText.Text = "";
            UiManager.AttackUiText.Text = "";
            UiManager.LetterUiText.Text = "";
            UiManager.DefenceUiText.Text = "";
            UiManager.TreasureUiText.Text = "";
            UiManager.TotalGoldUiText.Text = "";
            UiManager.BetUiText.Text = $"BET X{ Main.GameControl.Bet}";
            UiManager.SpinsUiText.Text = $"+{ Main.GameControl.Spins} spins";
            UiManager.LvlUiText.Text = $"lvl { Main.GameControl.TotalMatches}";
            UiManager.SpinsSliderUi.SliderMaxValue = Main.GameControl.MaxSliderSpins;
            UiManager.SpinsSliderUi.SliderValue = Main.GameControl.SliderSpins;
            UiManager.SpinsSliderUiText.Text = $"{ Main.GameControl.SliderSpins} / { Main.GameControl.MaxSliderSpins}";
        }

        private void WinTextOn()
        {
            UiManager.WinUiText.SetActive(true);
            UiManager.WinUiText.Text = Main.GameControl.PrizeValue.ToString();
            UiManager.TotalGoldUiText.Text = Main.GameControl.TotalGoldValue.ToString();
        }

        private void WinTextOff()
        {
            UiManager.WinUiText.SetActive(false);
        }

        private void HighlightOff()
        {
            UiManager.WinHighLightUiImg.SetActive(false);
        }

        private void HighlightOn()
        {
            UiManager.WinHighLightUiImg.SetActive(true);
        }

        private void BetChangeText()
        {
            UiManager.BetUiText.Text = $"BET X{ Main.GameControl.Bet}";
        }

        private void SpinsChangeText()
        {
            UiManager.SpinsUiText.Text = $"+{ Main.GameControl.Spins} spins";
        }

        private void SliderSpinsChangeText()
        {
            UiManager.SpinsSliderUiText.Text = $"{ Main.GameControl.SliderSpins} / { Main.GameControl.MaxSliderSpins}";
            UiManager.SpinsSliderUi.SliderValue = Main.GameControl.SliderSpins;
        }

        private void KeyFindCountText()
        {
            UiManager.KeyUiText.Text = Main.GameControl.KeyValue.ToString();
            UiManager.LvlUiText.Text = $"lvl { Main.GameControl.TotalMatches}";
        }

        private void TreasureFindCountText()
        {
            UiManager.TreasureUiText.Text = Main.GameControl.TreasureValue.ToString();
            UiManager.LvlUiText.Text = $"lvl { Main.GameControl.TotalMatches}";
        }

        private void LetterFindCountText()
        {
            UiManager.LetterUiText.Text = Main.GameControl.LetterValue.ToString();
            UiManager.LvlUiText.Text = $"lvl { Main.GameControl.TotalMatches}";
        }

        private void MapFindCountText()
        {
            UiManager.MapUiText.Text = Main.GameControl.MapValue.ToString();
            UiManager.LvlUiText.Text = $"lvl { Main.GameControl.TotalMatches}";
        }

        private void AttackFindCountText()
        {
            UiManager.AttackUiText.Text = Main.GameControl.AttackValue.ToString();
            UiManager.LvlUiText.Text = $"lvl { Main.GameControl.TotalMatches}";
        }

        private void DefenceFindCountText()
        {
            UiManager.DefenceUiText.Text = Main.GameControl.DefenceValue.ToString();
            UiManager.LvlUiText.Text = $"lvl { Main.GameControl.TotalMatches}";
        }

        public void UnSubscribe()
        {
            Main.GameControl.OnWinTextOn -= WinTextOn;
            Main.GameControl.OnWinTextOff -= WinTextOff;
            Main.GameControl.OnKeyFind -= KeyFindCountText;
            Main.GameControl.OnTreasureFind -= TreasureFindCountText;
            Main.GameControl.OnLetterFind -= LetterFindCountText;
            Main.GameControl.OnMapFind -= MapFindCountText;
            Main.GameControl.OnAttackFind -= AttackFindCountText;
            Main.GameControl.OnDefenceFind -= DefenceFindCountText;
            Main.GameControl.OnBetChange -= BetChangeText;
            Main.GameControl.OnSpinsChange -= SpinsChangeText;
            Main.GameControl.OnSliderSpinsChange -= SliderSpinsChangeText;
            Main.GameControl.OnWinHighlight -= HighlightOn;

            ServiceLocator.GetService<ButtonsUiManager>().SpinButtonPressed -= HighlightOff;
        }
    }
}
