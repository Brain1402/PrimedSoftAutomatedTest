using PrimedSoftAutomatedTest.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PrimedSoftAutomatedTest.StepDefinitions
{
    [Binding]
    public class PrimedsoftHomepage1StepDefinitions
    {
        PrimedsoftHomepage1Object _homePage = new PrimedsoftHomepage1Object();
        [Given(@"user navigate to primedsoft website ""([^""]*)""")]
        public void GivenUserNavigateToPrimedsoftWebsite(string url)
        {
            _homePage.Navigate(url);
        }

        [When(@"user clicks on Register")]
        public void WhenUserClicksOnRegister()
        {
            _homePage.ClickOnRegisterHeaderMenu();
        }


        [When(@"user clicks on Data analysis")]
        public void WhenUserClicksOnDataAnalysis()
        {
            _homePage.ClickOnDataAnalysis();   
        }


        [Then(@"I should see the page")]
        public void ThenIShouldSeeThePage()
        {
            _homePage.ThenIShouldSeeThePage();
        }

        [Then(@"I should be able to see the amount needed for the course")]
        public void ThenIShouldBeAbleToSeeTheAmountNeededForTheCourse()
        {
            _homePage.ThenIShouldSeeTheCourseAmount();
        }

        [Then(@"I click on the Amount Button")]
        public void ThenIClickOnTheAmountButton()
        {
            _homePage.IClickOnTheAmountButton();
        }

        [Then(@"I should be redirected to Register course")]
        public void ThenIShouldBeRedirectedToRegisterCourse()
        {
            _homePage.ThenIShouldBeRedirectedToRegisterCourse();
        }

        [When(@"user click on Course Description")]
        public void WhenUserClickOnCourseDescription()
        {
            _homePage.WhenUserClickOnCourseDescription();
        }

        [Then(@"I should see the Course Description")]
        public void ThenIShouldSeeTheCourseDescription()
        {
            _homePage.ThenIShouldSeeTheCourseDescription();
        }

        [When(@"user click on Course Outline")]
        public void WhenUserClickOnCourseOutline()
        {
            _homePage.WhenUserClickOnCourseOutline();
        }

        [Then(@"I should see the Course Outline")]
        public void ThenIShouldSeeTheCourseOutline()
        {
            _homePage.ThenIShouldSeeTheCourseOutline();
        }

    }
}
