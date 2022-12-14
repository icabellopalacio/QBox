// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace QBox.Gherkin.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class QBoxRequestADemoFeature : object, Xunit.IClassFixture<QBoxRequestADemoFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "QBoxRequestADemo.feature"
#line hidden
        
        public QBoxRequestADemoFeature(QBoxRequestADemoFeature.FixtureData fixtureData, QBox_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Gherkin/Features", "QBoxRequestADemo", "\tAs a visitor to the QBox web site, \r\n\tI want to request a demo from a salesperso" +
                    "n, \r\n\tso that they can show me more about how QBox works, and I can find out whe" +
                    "ther it’s relevant for me.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Request a QBox Demo with well configuration")]
        [Xunit.TraitAttribute("FeatureTitle", "QBoxRequestADemo")]
        [Xunit.TraitAttribute("Description", "Request a QBox Demo with well configuration")]
        [Xunit.TraitAttribute("Category", "Functional")]
        public virtual void RequestAQBoxDemoWithWellConfiguration()
        {
            string[] tagsOfScenario = new string[] {
                    "Functional"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Request a QBox Demo with well configuration", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
 testRunner.Given("the Qbox Demo request form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
 testRunner.And("all the needed fields are well informed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.When("Complete Captcha", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.And("Submit button is clicked on", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.Then("the salesperson see a new lead in their CRM tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 13
 testRunner.And("the visitor receive a confirmation that the demo is received", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Request a QBox Demo with a non coporate email")]
        [Xunit.TraitAttribute("FeatureTitle", "QBoxRequestADemo")]
        [Xunit.TraitAttribute("Description", "Request a QBox Demo with a non coporate email")]
        [Xunit.TraitAttribute("Category", "Functional")]
        [Xunit.InlineDataAttribute("QBox@gmail.com", new string[0])]
        [Xunit.InlineDataAttribute("QBox@hotmai.com", new string[0])]
        public virtual void RequestAQBoxDemoWithANonCoporateEmail(string nonCorporateEmail, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Functional"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("NonCorporateEmail", nonCorporateEmail);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Request a QBox Demo with a non coporate email", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 16
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 17
 testRunner.Given("the Qbox Demo request form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 18
 testRunner.And(string.Format("a non corporate Email: {0}", nonCorporateEmail), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And("the rest of the needed fields well informed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.When("Complete Captcha", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.And("Submit button is clicked on", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.Then("an error message is displayed just below the email field.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Request a QBox Demo without some empty required fields")]
        [Xunit.TraitAttribute("FeatureTitle", "QBoxRequestADemo")]
        [Xunit.TraitAttribute("Description", "Request a QBox Demo without some empty required fields")]
        [Xunit.TraitAttribute("Category", "Functional")]
        [Xunit.InlineDataAttribute("Empty", "NonEmpty", "NonEmpty", "NonEmpty", "NonEmpty", new string[0])]
        [Xunit.InlineDataAttribute("NonEmpty", "Empty", "NonEmpty", "NonEmpty", "NonEmpty", new string[0])]
        [Xunit.InlineDataAttribute("NonEmpty", "NonEmpty", "Empty", "NonEmpty", "NonEmpty", new string[0])]
        [Xunit.InlineDataAttribute("NonEmpty", "NonEmpty", "NonEmpty", "Empty", "NonEmpty", new string[0])]
        [Xunit.InlineDataAttribute("NonEmpty", "NonEmpty", "NonEmpty", "NonEmpty", "Empty", new string[0])]
        public virtual void RequestAQBoxDemoWithoutSomeEmptyRequiredFields(string email, string firstName, string secondName, string jobTitle, string industry, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Functional"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Email", email);
            argumentsOfScenario.Add("FirstName", firstName);
            argumentsOfScenario.Add("SecondName", secondName);
            argumentsOfScenario.Add("JobTitle", jobTitle);
            argumentsOfScenario.Add("Industry", industry);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Request a QBox Demo without some empty required fields", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 29
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 30
 testRunner.Given("the Qbox Demo request form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 31
 testRunner.And(string.Format("some empty required fields : {0}, {1}, {2}, {3}, {4}", email, firstName, secondName, jobTitle, industry), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.When("Complete Captcha", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.And("Submit button is clicked on", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.Then("a error message is displayed just below the empty required field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Request a QBox Demo testing the max-lenght of the text fields")]
        [Xunit.TraitAttribute("FeatureTitle", "QBoxRequestADemo")]
        [Xunit.TraitAttribute("Description", "Request a QBox Demo testing the max-lenght of the text fields")]
        [Xunit.TraitAttribute("Category", "NonFunctional")]
        [Xunit.InlineDataAttribute("CompanyEmail", new string[0])]
        [Xunit.InlineDataAttribute("FirstName", new string[0])]
        [Xunit.InlineDataAttribute("LastName", new string[0])]
        [Xunit.InlineDataAttribute("JobTitle", new string[0])]
        [Xunit.InlineDataAttribute("Industry", new string[0])]
        public virtual void RequestAQBoxDemoTestingTheMax_LenghtOfTheTextFields(string fieldMaxLenght, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "NonFunctional"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("FieldMaxLenght", fieldMaxLenght);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Request a QBox Demo testing the max-lenght of the text fields", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 44
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 45
 testRunner.Given("the Qbox Demo request form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 46
 testRunner.And(string.Format("a text with minimun number of characters to exceed the field maxlenght: {0}", fieldMaxLenght), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.When("Complete Captcha", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
 testRunner.And("Submit button is clicked on", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.Then("a error message is displayed just below the field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                QBoxRequestADemoFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                QBoxRequestADemoFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
