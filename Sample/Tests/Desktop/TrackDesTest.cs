using System;
using Sample.Pages.Desktop;
using Sample.Helpers;


namespace Sample.Tests.Desktop
{
    public class TrackDesTest : AppManager
    {
        
        public void TrackTest()
        {
            testName = "Track";
            
            SetupTest("Chrome", "Desktop");
            tests += 1;
            try
            {
                new MainDesPage()
                    .GoToNumber();

                new TrackDesPage()
                    .EnterNumber("00009876543456789")
                    .TapSubmit()
                    .CheckAlert();
            }
            catch { 
                message += "Ошибка в тесте " + testName + ". "; 
            }
            
            driver.Quit();
        }

    }
}
