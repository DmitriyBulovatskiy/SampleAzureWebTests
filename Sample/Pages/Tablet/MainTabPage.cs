
namespace Sample.Pages.Tablet

{
    public class MainTabPage : BaseMainPage
    {
        

        public MainTabPage GoToNumber()
        {
            Tap(base.GoToTrack);
            TakeScreenshot("GoToTrack");
            return this;
        }

     
    }
}                                                                                                                                                                                 