using System.Collections.Generic;
using UnityEngine;

namespace Slot_Mashine_2D_test
{
    public class CardPoolController : BaseController, IOnStart
    {
        public int CardsInRowPoolSize { get; private set; }
        public List<Row> Row { get; private set; } = new List<Row>();
        public List<CardInfoUi> RowPool { get; private set; } = new List<CardInfoUi>();

        public void OnStart()
        {
            CardsInRowPoolSize = Main.CardsListManager.AllCards.Count;

            var rowCount = Object.FindObjectsOfType<Row>();
            for (int i = 0; i < rowCount.Length; i++)
            {
                Row.Add(rowCount[i]);
            }

            for (int k = 0; k < Row.Count; k++)
            {
                for (int i = 0; i < CardsInRowPoolSize; i++)
                {
                    var go = Object.Instantiate(Main.CardPrefab, Row[k].transform);
                    var card = Main.CardsListManager.AllCards[i];

                    go.ShowCardInfo(card);
                    RowPool.Add(go);
                }
            }
        }
    }
}
