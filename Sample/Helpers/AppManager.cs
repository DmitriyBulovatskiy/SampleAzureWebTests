using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.IO.Compression;
using System.IO;

namespace Sample.Helpers
{
    
    public class AppManager
    {

        static public IWebDriver driver;
        private string appURL = "https://www.pochta.ru";
        static MailAddress from = new MailAddress("AdresOtkuda", "Azure");
        static MailAddress to = new MailAddress("AdresKuda");
        static public MailMessage m = new MailMessage(from, to);
        static public string message = "";
        public string currentBrowser = "";
        public string currentSize = "";
        static public string testName = "";
        static public int tests = 0;
        static public double compliteTests = 0;
       


        public void SetupTest(string browser, string size)
        {
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    currentBrowser = "Chrome";
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    currentBrowser = "Firefox";
                    break;
                default:
                    driver = new ChromeDriver();
                    currentBrowser = "Chrome";
                    break;
            }

            switch (size)
            {
                case "Desktop":
                    driver.Manage().Window.Size = new Size(1920, 1080);
                    currentSize = "Desktop";
                    break;
                case "Tablet":
                    driver.Manage().Window.Size = new Size(800, 800);
                    currentSize = "Tablet";
                    break;
                case "Mobile":
                    driver.Manage().Window.Size = new Size(300, 600);
                    currentSize = "Mobile";
                    break;
                default:
                    driver.Manage().Window.Size = new Size(1920, 1080);
                    currentSize = "Desktop";
                    break;
            }
            driver.Navigate().GoToUrl(appURL + "/");
            message += "<br>Браузер - " + currentBrowser + ". Разрешение - " + currentSize + ".";
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
        }


            public void SendMail()
        {
            if(tests/compliteTests>=0.75)
            {
                m.Body += "<h2 style = 'font-style:italic'>" +
                    "<span style = 'font-size:20px'>" +
                    "Тест Run Завершился" +
                    "<span style= 'color:#27ae60'> " +
                    "успешно " +
                    "</span> процент пройденных тестов " +
                    "<span style = 'color:#27ae60'> " +
                    ""+ tests/compliteTests*100 + "" +
                    " %</span>" +
                    "</span>" +
                    "</h2>" +
                    "<p>" +
                    "<span style = 'font-size:20px'> " +
                    "Тестов запущено "+ tests +".<br>" +
                    "Тестов выполнено " + compliteTests + "." +
                    "</span>" +
                    "</p >";
            }
            else
            {
                m.Body += "<h2 style = 'font-style:italic'>" +
                    "<span style = 'font-size:20px'> " +
                    "Тест Run Завершился" +
                    "<span style = 'color:#c0392b'> " +
                    "неудачно " +
                    "</span> &nbsp;" +
                    " процент пройденных тестов " +
                    "<span style = 'color:#c0392b'> "+ tests / compliteTests*100 + " %</span> </span></h2><p><span style = 'font-size:20px'> " +
                    "Тестов запущено " + tests + ".<br/>" +
                    "Тестов выполнено " + compliteTests + ".</span>" +
                    "</p>";
            }
            
            m.Body += message;
            m.Subject = "";
            m.IsBodyHtml = true;
            ZipFile.CreateFromDirectory(Directory.GetCurrentDirectory() + "/Results", Directory.GetCurrentDirectory() + "/Results.zip");
            m.Attachments.Add(new Attachment(Directory.GetCurrentDirectory() + "/Results.zip"));
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("Login", "Password");
            smtp.EnableSsl = true;
            smtp.Send(m);

        }

        public void TakeScreenshot(string name)
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            string path = Directory.GetCurrentDirectory() + "/Results/" + currentBrowser + "_" + currentSize + "/" + testName;
            Directory.CreateDirectory(path);
            path = path + "/" + name + ".png";
            ss.SaveAsFile(path);
        }

    }
}
