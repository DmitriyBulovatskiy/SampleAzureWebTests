using Sample.Pages.Mobile;
using Sample.Helpers;

namespace Sample.Tests.Mobile
{
    public class TrackMobTest : AppManager
    {

        public void TrackTest()
        {
            testName = "Track";

            SetupTest("Chrome", "Mobile");
            tests += 1;
            try
            {
                new MainMobPage()
                    .GoToNumber();

                new TrackMobPage()
                    .EnterNumber("00009876543456789")
                    .TapSubmit()
                    .CheckAlert();
            }
            catch { message += "Ошибка в тесте " + testName + ". "; }
            driver.Quit();
        }
    }
}
