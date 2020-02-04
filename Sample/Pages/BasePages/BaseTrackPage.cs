using OpenQA.Selenium;
using Sample.Helpers;


namespace Sample.Pages
{
    public class BaseTrackPage : BasePage
    {
        protected By EmailEntry = By.CssSelector(".Input-sc-1lqd5p4-0.lbayiE");

        protected By SubmitBtn = By.CssSelector(".Button-sc-1i1p2xt-0.SearchButton-sc-1krkte-0.gMGVsE");
        protected By Alert = By.CssSelector(".ErrorLabel-sc-1cl8x16-0.kmzTJh.e-l");
    }
}

