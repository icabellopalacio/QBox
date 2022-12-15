using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QBox.Utils;

namespace QBox.Dependecies;
public class QBoxDependencies: QBoxUtils
{
  
    private IWebDriver? _webDriver { get; set; }

    public string? ApplicationBaseURL { get; private set; }

    public QBoxDependencies() {
        ApplicationBaseURL = DEFAULT_APPLICATION_URL;
    }
    public QBoxDependencies WithApplicationBaseURL(string applicationBaseURL) {
        ApplicationBaseURL = applicationBaseURL;
        return this;
    }

    public IWebDriver? GetWebDriver() {
        if (_webDriver is null) {
            CreateWebDriver();
        }
        return _webDriver;
    }
    private void CreateWebDriver() {
        var chromeOptions = new ChromeOptions();
        _webDriver = new ChromeDriver(chromeDriverDirectory: Path.Combine(Directory.GetCurrentDirectory(), "Utils\\WebDrivers"),
                                options: chromeOptions);
    }

    public void CloseWebDriver() {
        _webDriver!.Dispose();
    }

}
