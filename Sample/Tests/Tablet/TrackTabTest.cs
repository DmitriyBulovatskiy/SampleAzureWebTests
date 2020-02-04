using Sample.Pages.Tablet;
using Sample.Helpers;

namespace Sample.Tests.Tablet
{
    public class TrackTabTest : AppManager
    {
        public void TrackTest()
        {
            testName = "Track";

            SetupTest("Chrome", "Tablet");
            tests += 1;
            try
            {
                
                new MainTabPage()
                    .GoToNumber();

                new TrackTabPage()
                    .EnterNumber("00009876543456789")
                    .TapSubmit()
                    .CheckAlert();
            }
            catch { message += "Ошибка в тесте " + testName + ". "; }

            driver.Quit();
        }
    }
}
