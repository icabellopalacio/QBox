using Boa.Constrictor.Screenplay;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static QBox.Domain.QBoxDemo;

namespace QBox.Utils;

public abstract class QBoxUtils {

    protected const string DEFAULT_APPLICATION_URL = "https://volume-cognisense-webapp-wwwuat.azurewebsites.net/";
    protected const string QBOX_DEPENDECIES = "QBoxDependencies";
    protected const string DEFAULT_EMAIL = "IvanCP@QBox.xom";
    protected const string DEFAULT_FIRST_NAME = "Ivan";
    protected const string DEFAULT_LAST_NAME = "Cabello";
    protected const string DEFAULT_JOB_TITLE = "Job";
    protected const string DEFAULT_INDUSTRY = "Industry";
    protected const string MAXLENGHT_VALUE = "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789";
    protected const string FIELD_EMAIL = "CompanyEmail";
    protected const string FIELD_FIRST_NAME = "FirstName";
    protected const string FIELD_LAST_NAME = "LastName";
    protected const string FIELD_JOB_TITlE = "JobTitle";
    protected const string FIELD_INDUSTRY = "Industry";


    protected IWebElement GetElementByXPath(IWebDriver? webDriver, string elementXpath) {
        WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        return wait.Until(d => d.FindElement(By.XPath(elementXpath)));
    }
    protected IWebElement GetElementById(IWebDriver? webDriver, string elementXpath)
    {
        WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        return wait.Until(d => d.FindElement(By.Id(elementXpath)));
    }
}
