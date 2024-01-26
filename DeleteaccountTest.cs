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
public class DeleteaccountTest {
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
  public void deleteaccount() {
    driver.Navigate().GoToUrl("https://qauto.forstudy.space/panel/garage");
    driver.Manage().Window.Size = new System.Drawing.Size(1050, 840);
    driver.FindElement(By.Id("userNavDropdown")).Click();
    driver.FindElement(By.CssSelector(".sidebar_btn-group > .btn:nth-child(2)")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".sidebar_btn-group > .btn:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.Id("emailChangeEmail")).SendKeys("hhhh@i.ua");
    driver.FindElement(By.Id("emailChangePassword")).SendKeys("Nataly.m01");
    driver.FindElement(By.CssSelector(".btn-danger-bg")).Click();
    driver.FindElement(By.CssSelector(".btn-danger")).Click();
  }
}
