using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using ProgrammierenLernen;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace TestProject1
{
    [TestFixture]
    public class UtilsTests
    {
        [Test]
        [TestCase("chrome")]
        [TestCase("firefox")]
        [TestCase("edge")]
        public void CompatibilityTest(string browser)
        {
            IWebDriver driver;

            if (browser == "chrome") driver = new ChromeDriver();
            else if (browser == "firefox") driver = new FirefoxDriver();
            else driver = new EdgeDriver();

            driver.Navigate().GoToUrl("https://example.com");
            Assert.IsTrue(driver.Title.Contains("Example"));

            driver.Quit();
        }
    }
}