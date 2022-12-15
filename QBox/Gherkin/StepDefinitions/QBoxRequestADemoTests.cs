using Boa.Constrictor.Screenplay;
using QBox.Dependecies;
using QBox.Domain;
using QBox.Utils;

namespace QBox.Gherkin.StepDefinitions;

[Binding]
public class QBoxRequestADemoTests : QBoxUtils {

    private IActor? _qboxActor { get; set; }
    private QBoxDemo _qboxDemo { get; set; }

    private QBoxDependencies _qboxDependecies { get; set; }

    public QBoxRequestADemoTests(FeatureContext featureContext) {
        _qboxDependecies = (featureContext?.GetValueOrDefault(QBOX_DEPENDECIES)) as QBoxDependencies ?? new QBoxDependencies();
        _qboxActor = new Actor("QBoxActor");
        _qboxDemo = new QBoxDemo().WithWebDriver(_qboxDependecies.GetWebDriver())
                                  .WithObjectURL(_qboxDependecies!.ApplicationBaseURL ?? string.Empty);
    }

    [Given(@"the Qbox Demo request form")]
    public void GivenTheQboxDemoRequestForm() {
        _qboxActor!.Can(_qboxDemo.ExploreQBox());
        _qboxActor!.AttemptsTo(_qboxDemo.OpenSeeADemoPanel());
    }

    [When(@"Complete Captcha")]
    public void WhenCompleteCaptcha() {
        _qboxActor!.AttemptsTo(_qboxDemo.InformCaptcha());
    }

    [Given(@"a non corporate Email: (.*)")]
    public void GivenANonCorporateEmailQBoxGmail_Com(string NonCorporateEmail) {
        _qboxActor!.AttemptsTo(_qboxDemo.InformEmail(NonCorporateEmail));
    }

    [Given(@"the rest of the needed fields well informed")]
    public void GivenTheRestOfTheNeededFieldsWellInformed() {
        _qboxActor!.AttemptsTo(_qboxDemo.InformFirstName(DEFAULT_FIRST_NAME));
        _qboxActor!.AttemptsTo(_qboxDemo.InformLastName(DEFAULT_LAST_NAME));
        _qboxActor!.AttemptsTo(_qboxDemo.InformJobTitle(DEFAULT_JOB_TITLE));
        _qboxActor!.AttemptsTo(_qboxDemo.InformIndustry(DEFAULT_INDUSTRY));
    }

    [Given(@"a text with minimun number of characters to exceed the field maxlenght: (*)")]
    public void GivenATextWithMinimunNumberOfCharactersToExceedTheFieldMaxlenghtCompanyEmail(string fieldToEvaluate) {
        switch (fieldToEvaluate) {
            case FIELD_EMAIL:
                _qboxActor!.AttemptsTo(_qboxDemo.InformEmail(MAXLENGHT_VALUE));
                break;
            case FIELD_FIRST_NAME:
                _qboxActor!.AttemptsTo(_qboxDemo.InformFirstName(MAXLENGHT_VALUE));
                break;
            case FIELD_LAST_NAME:
                _qboxActor!.AttemptsTo(_qboxDemo.InformLastName(MAXLENGHT_VALUE));
                break;
            case FIELD_JOB_TITlE:
                _qboxActor!.AttemptsTo(_qboxDemo.InformJobTitle(MAXLENGHT_VALUE));
                break;
            case FIELD_INDUSTRY:
                _qboxActor!.AttemptsTo(_qboxDemo.InformIndustry(MAXLENGHT_VALUE));
                break;
        }        
    }
}
