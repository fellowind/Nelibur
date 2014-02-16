﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowTests.Features.JsonService
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class DeleteActionsFeature : Xunit.IUseFixture<DeleteActionsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DeleteActions.feature"
#line hidden
        
        public DeleteActionsFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Delete actions", "In order to delete an object instance accordingly with CRUD and message based par" +
                    "adigm\r\nAs a developer\r\nI want to use Delete action", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(DeleteActionsFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Delete actions")]
        [Xunit.TraitAttribute("Description", "Delete data without response")]
        public virtual void DeleteDataWithoutResponse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete data without response", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("the Json service was started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Quantity",
                        "ProductId"});
            table1.AddRow(new string[] {
                        "3",
                        "5",
                        "5B1706AC-F33C-43B5-8ACF-BAEB2E73BB95"});
#line 8
 testRunner.And("I sent data thru Post action", ((string)(null)), table1, "And ");
#line 11
 testRunner.When("I send delete request by Id \'3\' thru Delete action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("the Json service was stopped", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Delete actions")]
        [Xunit.TraitAttribute("Description", "DeleteAsync data without response")]
        public virtual void DeleteAsyncDataWithoutResponse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DeleteAsync data without response", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("the Json service was started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Quantity",
                        "ProductId"});
            table2.AddRow(new string[] {
                        "4",
                        "5",
                        "5B1706AC-F33C-43B5-8ACF-BAEB2E73BB95"});
#line 16
 testRunner.And("I sent data thru Post action", ((string)(null)), table2, "And ");
#line 19
 testRunner.When("I send delete request by Id \'4\' thru DeleteAsync action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("the Json service was stopped", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Delete actions")]
        [Xunit.TraitAttribute("Description", "Delete data with response")]
        public virtual void DeleteDataWithResponse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete data with response", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
 testRunner.Given("the Json service was started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Quantity",
                        "ProductId"});
            table3.AddRow(new string[] {
                        "5",
                        "5",
                        "5B1706AC-F33C-43B5-8ACF-BAEB2E73BB95"});
#line 24
 testRunner.And("I sent data thru Post action", ((string)(null)), table3, "And ");
#line 27
 testRunner.When("I send delete request by Id \'5\' thru Delete with response action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.And("response equals \'true\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.Then("the Json service was stopped", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Delete actions")]
        [Xunit.TraitAttribute("Description", "DeleteAsync data with response")]
        public virtual void DeleteAsyncDataWithResponse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DeleteAsync data with response", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.Given("the Json service was started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Quantity",
                        "ProductId"});
            table4.AddRow(new string[] {
                        "6",
                        "5",
                        "5B1706AC-F33C-43B5-8ACF-BAEB2E73BB95"});
#line 33
 testRunner.And("I sent data thru Post action", ((string)(null)), table4, "And ");
#line 36
 testRunner.When("I send delete request by Id \'6\' thru DeleteAsync with response action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.And("response equals \'true\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.Then("the Json service was stopped", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                DeleteActionsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                DeleteActionsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
