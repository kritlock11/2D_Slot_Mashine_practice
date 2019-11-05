using System.Collections.Generic;
using UnityEngine;

namespace Slot_Mashine_2D_test
{
    public class Main : MonoBehaviour
    {
        [HideInInspector] public CardInfoUi CardPrefab;

        public GameController GameControl { get; private set; }
        public UiController UiController { get; private set; }
        public CardPoolController CardPoolController { get; private set; }
        public CardsListManager CardsListManager { get; private set; }
        

        public readonly List<IOnStart> Inites = new List<IOnStart>();
        public readonly List<IOnUpdate> Updates = new List<IOnUpdate>();

        private void Awake()
        {
            CardPrefab = Resources.Load<CardInfoUi>("Prefabs/CardPrefab");

            CardsListManager = new CardsListManager();

            CardPoolController = new CardPoolController();
            Inites.Add(CardPoolController);

            GameControl = new GameController();
            Inites.Add(GameControl);
            Updates.Add(GameControl);

            UiController = new UiController();
            Inites.Add(UiController);
        }

        private void Start()
        {
            for (int i = 0; i < Inites.Count; i++)
            {
                Inites[i].OnStart();
            }
        }
    }
}

