using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PrimedSoftAutomatedTest.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimedSoftAutomatedTest.PageObject
{
    public class PrimedsoftHomepage1Object
    {
        public IWebDriver driver;

        public PrimedsoftHomepage1Object()
        {
            this.driver = BaseTest.driver;
        }

        private By registerHeaderMenu = By.XPath("//*[@id=\"menu-main-menu\"]/li[5]");
        private By dataAnalysis = By.XPath("//*[@id=\"post-534\"]/div/div/div/div/div[2]/div[3]/div[4]/a");
        private By durationperiod = By.XPath("//*[@id=\"post-852\"]/div/div/div/div[2]/div/div[1]/div[1]/div/h5");
        private By courseamount = By.XPath("//*[@id=\"post-852\"]/div/div/div/div[1]/div/div[3]/div/a");
        private By clickamount = By.XPath("//*[@id=\"post-852\"]/div/div/div/div[1]/div/div[3]/div/a");
        private By isredirected = By.XPath("//*[@id=\"post-1023\"]/div/div/div/div[1]/div[1]/div/div/div/h2");
        private By clickoncoursedescription = By.XPath("//*[@id=\"post-852\"]/div/div/div/div[2]/div/div[2]/div[2]/ul/li[1]/a");
        private By coursedescription = By.XPath("//*[@id=\"post-852\"]/div/div/div/div[2]/div/div[2]/div[2]/div/div[1]");
        private By clickoncourseoutline = By.XPath("//*[@id=\"post-852\"]/div/div/div/div[2]/div/div[2]/div[2]/ul/li[2]/a");
        private By courseoutline = By.XPath("//*[@id=\"post-852\"]/div/div/div/div[2]/div/div[2]/div[2]/div/div[2]");

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url); 
        }

        public void ClickOnRegisterHeaderMenu()
        {
            driver.FindElement(registerHeaderMenu).Click();
        }

        public void ClickOnDataAnalysis()
        {
            driver.FindElement(dataAnalysis).Click();
        }

        public void ThenIShouldSeeThePage()
        {
            Thread.Sleep(TimeSpan.FromSeconds(10));
            var web = driver.FindElement(courseamount);
            Assert.IsTrue(web.Displayed, "Course amount is not displayed.");
        }

        public void ThenIShouldSeeTheCourseAmount()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            var amountElement = driver.FindElement(courseamount);
            Assert.IsTrue(amountElement.Displayed, "Course amount is not displayed.");
        }

        public void IClickOnTheAmountButton()
        {
            driver.FindElement(clickamount).Click();
        }

        public void ThenIShouldBeRedirectedToRegisterCourse()
        {
            bool isRedirected = driver.Title.Contains("isredirected");
            string expectedUrl = "https://primedsoft.com/da-registration/";
            Assert.AreEqual(expectedUrl, driver.Url);
        }

        public void WhenUserClickOnCourseDescription()
        {
            driver.FindElement(clickoncoursedescription).Click();
        }

        public void ThenIShouldSeeTheCourseDescription()
        {
            Thread.Sleep(TimeSpan.FromSeconds(10));
            var element = driver.FindElement(coursedescription);
            Assert.IsTrue(element.Displayed, "Coursedescription is not displayed.");
        }

        public void WhenUserClickOnCourseOutline()
        {
            driver.FindElement(clickoncourseoutline).Click();
        }

        public void ThenIShouldSeeTheCourseOutline()
        {
            Thread.Sleep(TimeSpan.FromSeconds(10));
            var element = driver.FindElement(courseoutline);
            Assert.IsTrue(element.Displayed, "Courseoutline is not displayed.");
        }     
    }
}
