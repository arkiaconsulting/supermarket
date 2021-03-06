﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace supermarket.acceptance
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class BrowsingProductsFeature : Xunit.IClassFixture<BrowsingProductsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "BrowsingProducts.feature"
#line hidden
        
        public BrowsingProductsFeature(BrowsingProductsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "BrowsingProducts", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioTearDown()
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
        
        public virtual void FeatureBackground()
        {
#line 3
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "id",
                        "userName",
                        "preferred"});
            table1.AddRow(new string[] {
                        "abc",
                        "Louis",
                        "false"});
            table1.AddRow(new string[] {
                        "def",
                        "John",
                        "true"});
#line 4
 testRunner.Given("The following users exist:", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "id",
                        "name",
                        "category",
                        "price"});
            table2.AddRow(new string[] {
                        "abc",
                        "Western Digital 150 Go",
                        "Hard Disks",
                        "100"});
            table2.AddRow(new string[] {
                        "def",
                        "Seagate 150 Go",
                        "Hard Disks",
                        "150"});
            table2.AddRow(new string[] {
                        "ghi",
                        "Lacie 1 To",
                        "Hard Disks",
                        "200"});
#line 8
 testRunner.Given("The following products exist:", ((string)(null)), table2, "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Browsing a product category")]
        [Xunit.TraitAttribute("FeatureTitle", "BrowsingProducts")]
        [Xunit.TraitAttribute("Description", "Browsing a product category")]
        public virtual void BrowsingAProductCategory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Browsing a product category", null, ((string[])(null)));
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 16
testRunner.Given("I\'m authenticated as Louis", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
testRunner.When("I choose the Hard Disks category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "id",
                        "name",
                        "price"});
            table3.AddRow(new string[] {
                        "abc",
                        "Western Digital 150 Go",
                        "100"});
            table3.AddRow(new string[] {
                        "def",
                        "Seagate 150 Go",
                        "150"});
            table3.AddRow(new string[] {
                        "ghi",
                        "Lacie 1 To",
                        "200"});
#line 18
testRunner.Then("I can see a list of all the products", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Display right prices")]
        [Xunit.TraitAttribute("FeatureTitle", "BrowsingProducts")]
        [Xunit.TraitAttribute("Description", "Display right prices")]
        public virtual void DisplayRightPrices()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Display right prices", null, ((string[])(null)));
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 26
testRunner.Given("I\'m authenticated as John", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
testRunner.When("I choose the Hard Disks category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "id",
                        "name",
                        "price"});
            table4.AddRow(new string[] {
                        "abc",
                        "Western Digital 150 Go",
                        "90"});
            table4.AddRow(new string[] {
                        "def",
                        "Seagate 150 Go",
                        "135"});
            table4.AddRow(new string[] {
                        "ghi",
                        "Lacie 1 To",
                        "180"});
#line 28
testRunner.Then("I can see a list of all the products", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                BrowsingProductsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                BrowsingProductsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
