﻿using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace DemoWebApp.Tests
{
    public class LoanApplicationTests
    {
        [Fact]
        public void StartApplication()
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("http://localhost:40077/");

                IWebElement applicationButton = driver.FindElement(By.Id("startApplication"));

                applicationButton.Click();

                Assert.Equal("Start Loan Application - Loan Application", driver.Title);
            }
        }

        [Fact]
        public void SubmitApplication()
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("http://localhost:40077/Home/StartLoanApplication");

                IWebElement firstNameInput = driver.FindElement(By.Id("FirstName"));
                firstNameInput.SendKeys("Sarah");

                driver.FindElement(By.Id("LastName")).SendKeys("Smith");


                driver.FindElement(By.Id("Loan")).Click();


                driver.FindElement(By.Name("TermsAcceptance")).Click();
            }
        }

    }
}
