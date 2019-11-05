using UnityEngine;

namespace Slot_Mashine_2D_test
{
    public class UpdateController : MonoBehaviour
    {
        [HideInInspector] public Main Main;

        private void Awake()
        {
            Main = ServiceLocator.GetService<Main>();
        }

        private void Update()
        {
            for (var i = 0; i < Main.Updates.Count; i++)
            {
                Main.Updates[i].OnUpdate();
            }
        }
    }
}
