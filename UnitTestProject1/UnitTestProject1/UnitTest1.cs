using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleProjectonCI
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver driver;
        [TestMethod]
        public void TestMethod1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("est");
            driver.FindElement(By.Name("btnK")).Click();
            driver.Close();
        }
        [TestMethod]
        public void TestMethod2()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("est");
            driver.FindElement(By.Name("btnK")).Click();
            driver.Close();
        }
        [TestMethod]
        public void TestMethod3()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("est");
            driver.FindElement(By.Name("btnK")).Click();
            driver.Close();
        }
        [TestMethod]
        public void TestMethod4()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("est");
            driver.FindElement(By.Name("btnK")).Click();
            driver.Close();
        }
        [TestMethod]
        public void TestMethod5()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("est");
            driver.FindElement(By.Name("btnK")).Click();
            driver.Close();
        }
        [TestMethod]
        public void TestMethod6()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("est");
            driver.FindElement(By.Name("btnK")).Click();
            driver.Close();
        }
        [TestCleanup()]
        public void MyTestCleanup()
        {
            driver.Quit();
        }

    }
}