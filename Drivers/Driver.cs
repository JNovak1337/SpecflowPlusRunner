using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject4.Drivers
{
    public class SeleniumDriver
    {
        private readonly ScenarioContext _scenarioContext;

        public SeleniumDriver(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        public IWebDriver Setup()
        {
            //Hardcoded ChromeOption
            //IWebDriver webDriver = new ChromeDriver();

            IWebDriver webDriver = new ChromeDriver(@"C:\Users\jnovak\source\repos\SpecFlowProject4\ChromeDriver");

            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://google.com");

            //Set the driver
            _scenarioContext.Set(webDriver, "WebDriver");
            webDriver.Manage().Window.Maximize();

            return webDriver;
        }
    }
}
