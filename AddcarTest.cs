// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class AddcarTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void addcar() {
    driver.Navigate().GoToUrl("https://qauto.forstudy.space/panel/garage");
    driver.Manage().Window.Size = new System.Drawing.Size(1050, 840);
    driver.FindElement(By.CssSelector(".btn-primary")).Click();
    driver.FindElement(By.Id("addCarBrand")).Click();
    driver.FindElement(By.Id("addCarModel")).Click();
    {
      var dropdown = driver.FindElement(By.Id("addCarModel"));
      dropdown.FindElement(By.XPath("//option[. = 'R8']")).Click();
    }
    driver.FindElement(By.Id("addCarMileage")).Click();
    driver.FindElement(By.Id("addCarMileage")).SendKeys("11");
    driver.FindElement(By.CssSelector(".modal-footer > .btn-primary")).Click();
  }
}
