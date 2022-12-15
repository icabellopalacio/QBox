using QBox.Dependecies;
using QBox.Utils;

namespace QBox.Gherkin
{
    [Binding]
    public sealed class QBoxHook : QBoxUtils {

        [BeforeScenario]
        public void BeforeScenarioWithTag(FeatureContext featureContext) {
            featureContext?.Set(new QBoxDependencies(), QBOX_DEPENDECIES);
        }

        [AfterScenario]
        public void AfterScenario(FeatureContext featureContext) {
            var qboxDependencies = (featureContext?.GetValueOrDefault(QBOX_DEPENDECIES)) as QBoxDependencies ?? new QBoxDependencies();
            qboxDependencies.CloseWebDriver();
        }
    }
}