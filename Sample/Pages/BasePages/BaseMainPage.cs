using OpenQA.Selenium;
using Sample.Helpers;


namespace Sample.Pages
{
    public class BaseMainPage : BasePage
    {
        
        protected By GoToTrack = By.CssSelector("a[href^='/tracking']");

    }
}
