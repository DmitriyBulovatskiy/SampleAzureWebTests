
using OpenQA.Selenium;


namespace Sample.Helpers
{
    public class BasePage : AppManager
    {
        protected void CheckElement(By element)
        {
            driver.FindElement(element);
            message += "Тест" + testName +" завершился успешно. ";
            compliteTests += 1;
        }

        protected void Tap(By element)
        {
            driver.FindElement(element).Click();
        }

        protected void Enter(By element, string text)
        {
            driver.FindElement(element).SendKeys(text);
        }
    }
}

