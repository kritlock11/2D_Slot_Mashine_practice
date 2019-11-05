using UnityEngine;

namespace Slot_Mashine_2D_test
{
    [System.Serializable]
    [CreateAssetMenu(menuName = "Cards", fileName = "NewCard")]

    public class CardIcon : ScriptableObject
    {
        public int ID;
        public string Name;
        public Sprite Logo;
    }
}
