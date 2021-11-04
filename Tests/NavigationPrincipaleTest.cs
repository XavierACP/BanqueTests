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
public class NavigationPrincipaleTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  
  [SetUp]
  public void SetUp() {
    //driver = new FirefoxDriver();
    //driver = new ChromeDriver();
    // js = (IJavaScriptExecutor)driver;
    // vars = new Dictionary<string, object>();
  }
  
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  
  [Test]
  public void navigationPrincipaleChrome(){
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
    navigationPrincipale();
  }

  [Test]
  public void navigationPrincipaleFirefox(){
    driver = new FirefoxDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
    navigationPrincipale();
  }

  //[Test]
  private void navigationPrincipale() {
    // Test name: Navigation Principale
    // Step # | name | target | value
    // 1 | open | / | 
    driver.Navigate().GoToUrl("http://192.168.18.104/");
    // 2 | setWindowSize | 1280x1024 | 
    driver.Manage().Window.Size = new System.Drawing.Size(1280, 1024);
    // 3 | assertText | css=h2 | Bienvenue sur votre Banque en ligne !!!
    Assert.That(driver.FindElement(By.CssSelector("h2")).Text, Is.EqualTo("Bienvenue sur votre Banque en ligne !!!"));
    // 4 | click | linkText=Accès client | 
    driver.FindElement(By.LinkText("Accès client")).Click();
    // 5 | assertText | css=h3 | Identification Client
    Assert.That(driver.FindElement(By.CssSelector("h3")).Text, Is.EqualTo("Identification Client"));
    // 6 | assertElementPresent | id=authIdentifiant | 
    var elements = driver.FindElements(By.Id("authIdentifiant"));
    Assert.True(elements.Count > 0);
    // 7 | assertElementPresent | id=authMotdepasse | 
    elements = driver.FindElements(By.Id("authMotdepasse"));
    Assert.True(elements.Count > 0);
    // 8 | assertElementPresent | css=.btn | 
    elements = driver.FindElements(By.CssSelector(".btn"));
    Assert.True(elements.Count > 0);
    // 9 | click | linkText=Nous Contacter | 
    driver.FindElement(By.LinkText("Nous Contacter")).Click();
    // 10 | assertText | css=h3 | Nous contacter
    Assert.That(driver.FindElement(By.CssSelector("h3")).Text, Is.EqualTo("Nous contacter"));
    // 11 | close |  | 
    driver.Close();
  }
}
