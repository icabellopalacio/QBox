using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using QBox.Domain.ScreenPlayPattern;
using QBox.Utils;
using FieldsIdentificators = System.Collections.Generic.Dictionary<QBox.Domain.QBoxDemo.TextFileds, string>;

namespace QBox.Domain;
public  class QBoxDemo: QBoxUtils {

    public enum TextFileds {
        CompanyEmail,
        FirstName,
        LastName,
        JobTitle,
        Industry
    }

    public IWebDriver? WebDriver { get; private set; }
    public string? ObjectURL { get; private set; }
    public FieldsIdentificators ListOfFieldsIdentificators { get; init; }
    private TextFileds _textFieldSelected { get; set; }

    public QBoxDemo() {
        ListOfFieldsIdentificators = new FieldsIdentificators() {
            { TextFileds.CompanyEmail, "email-demo"},
            { TextFileds.FirstName, "firstname-demo"},
            { TextFileds.LastName, "lastname-demo"},
            { TextFileds.JobTitle, "jobtitle-demo"},
            { TextFileds.Industry, "industry-demo"}
        };
    }
    public QBoxDemo WithWebDriver(IWebDriver? webDriver) {
        WebDriver = webDriver;
        return this;
    }
    public QBoxDemo WithObjectURL(string objectURL) {
        ObjectURL = objectURL;
        if (WebDriver is not null) {
            WebDriver.Url = objectURL;
        }
        return this;
    }

    #region Abilities

    public IAbility ExploreQBox() {
        return BrowseTheWeb.With(WebDriver);
    }

    #endregion

    #region Tasks 

    public ITask OpenSeeADemoPanel()
    {
        return new TaskItem().WithActionToInvokeLists(new List<Action>() {
            ClickOnSeeADemoButton
        });
    }
    private void ClickOnSeeADemoButton() {
        GetElementByXPath(WebDriver, "//*[@id=\"hero\"]/div/div[1]/ul/li").Click();
    }

    public ITask InformEmail(string? fieldValue) {
        _textFieldSelected = TextFileds.CompanyEmail;
        return new TaskItemWithParameters<string?>().WithParam(fieldValue)
                                                   .WithActionToInvoke(InformField);
    }
    public ITask InformFirstName(string? fieldValue) {
        _textFieldSelected = TextFileds.FirstName;
        return new TaskItemWithParameters<string?>().WithParam(fieldValue)
                                                   .WithActionToInvoke(InformField);
    }
    public ITask InformLastName(string? fieldValue) {
        _textFieldSelected = TextFileds.LastName;
        return new TaskItemWithParameters<string?>().WithParam(fieldValue)
                                                   .WithActionToInvoke(InformField);
    }
    public ITask InformJobTitle(string? fieldValue) {
        _textFieldSelected = TextFileds.JobTitle;
        return new TaskItemWithParameters<string?>().WithParam(fieldValue)
                                                   .WithActionToInvoke(InformField);
    }
    public ITask InformIndustry(string? fieldValue) {
        _textFieldSelected = TextFileds.Industry;
        return new TaskItemWithParameters<string?>().WithParam(fieldValue)
                                                   .WithActionToInvoke(InformField);
    }
    private void InformField(string? fieldValue) {
        if (!string.IsNullOrEmpty(fieldValue)) {
            GetElementById(WebDriver, ListOfFieldsIdentificators[_textFieldSelected]).SendKeys(fieldValue);
        }
    }

    public ITask InformCaptcha() {
        return new TaskItem().WithActionToInvokeLists(new List<Action>() {
            ClickCaptcha
        });
    }
    private void ClickCaptcha() {
        GetElementById(WebDriver, "btnSubmitDemo").Click();
    }
    

    #endregion

}
