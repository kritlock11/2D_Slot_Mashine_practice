using System.Collections.Generic;

namespace Slot_Mashine_2D_test
{
    public class CardsListManager
    {
        public List<CardModel> AllCards { get; private set; } = new List<CardModel>()
        {
            new CardModel(1, "Steal", "Icons/Cards/PickPocket"),
            new CardModel(2, "Coin", "Icons/Cards/Coin"),
            new CardModel(3, "Mana", "Icons/Cards/Mana"),
            new CardModel(4, "Treasure", "Icons/Cards/Valajar"),
            new CardModel(5, "Attack", "Icons/Cards/ShadowStrikes"),
            new CardModel(2, "Coin", "Icons/Cards/Coin"),
            new CardModel(6, "Shield", "Icons/Cards/Defend"),
            new CardModel(4, "Treasure", "Icons/Cards/Valajar"),
            new CardModel(7, "Key", "Icons/Cards/Key"),
            new CardModel(8, "Map", "Icons/Cards/Map"),
            new CardModel(9, "Letter", "Icons/Cards/Letter"),
            new CardModel(1, "Steal", "Icons/Cards/PickPocket"),
            new CardModel(2, "Coin", "Icons/Cards/Coin"),
            new CardModel(3, "Mana", "Icons/Cards/Mana")
        };
    }
}
