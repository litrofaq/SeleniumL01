using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumL01;

public class FirstSeleniumTests
{
    private ChromeDriver _chromeDriver;
    
    [SetUp]
    public void SetUp()
    {
        var options = new ChromeOptions();
        options.AddArgument("start-maximized");
        _chromeDriver = new ChromeDriver(options);
    }
    
    [Test]
    public void Test1()
    {
        
    }
    
    [TearDown]
    public void TearDown()
    {
        _chromeDriver.Quit();
    }
}