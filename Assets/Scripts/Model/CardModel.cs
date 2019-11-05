using UnityEngine;

namespace Slot_Mashine_2D_test
{
    public struct CardModel
    {
        private int _id;
        private string _name;
        private Sprite _logo;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public Sprite Logo { get => _logo; set => _logo = value; }

        public CardModel(int id, string name, string logoPath)
        {
            _id = id;
            _name = name;
            _logo = Resources.Load<Sprite>(logoPath);
        }
    }
}
