namespace Slot_Mashine_2D_test
{
    public class BaseController
    {
        protected readonly Main Main;
        protected readonly UiManager UiManager;

        protected BaseController()
        {
            UiManager = new UiManager();
            Main = ServiceLocator.GetService<Main>();
        }
    }
}
