using OpenQA.Selenium;
using SpecFlowProject4.Drivers;
using System;
using System.IO;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowProject4.Steps
{
    [Binding]
    public sealed class StepDefinition
    {

        IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;

        public StepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"Google homepage searchbard on this environment")]
        public void GivenGoogleHomepageSearchbardOnThisEnvironment(Table table)
        {

            //Local
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            driver.Url = "https://google.com";

        }

        [Given(@"Left click on searchbar")]
        public void GivenLeftClickOnSearchbar()
        {
            driver.FindElement(By.Id("L2AGLb")).Click();
            driver.FindElement(By.Name("q")).Click();
        }

        [Then(@"Add some text you want to search for")]
        public void ThenAddSomeTextYouWantToSearchFor()
        {
            driver.FindElement(By.Name("q")).SendKeys("How to cook spaghetti");
        }

        [Then(@"The searchbar should start giving you tips")]
        public void ThenTheSearchbarShouldStartGivingYouTips()
        {
            Thread.Sleep(1000);
        }

        [Then(@"Click on enter")]
        public void ThenClickOnEnter()
        {
            driver.FindElement(By.XPath("//body/div[1]/div[3]/form[1]/div[1]/div[1]/div[2]/div[2]/div[2]/ul[1]/li[1]/div[1]/div[2]/div[1]")).Click();
        }

        [Then(@"You are able to see results of the search")]
        public void ThenYouAreAbleToSeeResultsOfTheSearch()
        {
            Thread.Sleep(1000);
        }

        [Then(@"Left click on images text")]
        public void LeftClickOnImagesText()
        {
            driver.FindElement(By.LinkText("Images")).Click();
        }

        [Then(@"Left click on videos text")]
        public void LeftClickOnVideosText()
        {
            driver.FindElement(By.LinkText("Videos")).Click();
        }

        [Then(@"Left click on books text")]
        public void LeftClickOnBooksText()
        {
            driver.FindElement(By.LinkText("Books")).Click();
        }

        [Then(@"Left click on failed text")]
        public void LeftClickOnFailedText()
        {
            driver.FindElement(By.LinkText("$$$$$$")).Click();
        }
    }
}

