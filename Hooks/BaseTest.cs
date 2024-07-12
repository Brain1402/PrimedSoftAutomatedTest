using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Reflection;
using TechTalk.SpecFlow;

namespace PrimedSoftAutomatedTest.Hooks
{
    [Binding]
    public sealed class BaseTest
    {
        public static IWebDriver driver;

        [BeforeScenario()]
        public void FirstBeforeScenario()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();

        }
            

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Quit(); 
        }
    }
}