﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
using Reqnroll;
namespace ReqnrollProjectTAProgram.Features
{
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Calculator Feature")]
    [NUnit.Framework.FixtureLifeCycleAttribute(NUnit.Framework.LifeCycle.InstancePerTestCase)]
    [NUnit.Framework.CategoryAttribute("regression")]
    [NUnit.Framework.CategoryAttribute("bvt")]
    public partial class CalculatorFeatureFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "regression",
                "bvt"};
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new global::System.Globalization.CultureInfo("en-US"), "Features", "Calculator Feature", "Simple calculator for calculating two numbers", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "Calculator.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public static async global::System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public static async global::System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async global::System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            try
            {
                if (((testRunner.FeatureContext != null) 
                            && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
                {
                    await testRunner.OnFeatureEndAsync();
                }
            }
            finally
            {
                if (((testRunner.FeatureContext != null) 
                            && testRunner.FeatureContext.BeforeFeatureHookFailed))
                {
                    throw new global::Reqnroll.ReqnrollException("Scenario skipped because of previous before feature hook error");
                }
                if ((testRunner.FeatureContext == null))
                {
                    await testRunner.OnFeatureStartAsync(featureInfo);
                }
            }
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async global::System.Threading.Tasks.Task TestTearDownAsync()
        {
            if ((testRunner == null))
            {
                return;
            }
            try
            {
                await testRunner.OnScenarioEndAsync();
            }
            finally
            {
                global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
                testRunner = null;
            }
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async global::System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async global::System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add two numbers")]
        [NUnit.Framework.CategoryAttribute("addition")]
        public async global::System.Threading.Tasks.Task AddTwoNumbers()
        {
            string[] tagsOfScenario = new string[] {
                    "addition"};
            global::System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new global::System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Add two numbers", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 9
 await testRunner.GivenAsync("the first number is 50", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 10
 await testRunner.AndAsync("the second number is 70", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 11
 await testRunner.WhenAsync("the two numbers are added", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 12
 await testRunner.ThenAsync("the result should be 120", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Substract two numbers")]
        [NUnit.Framework.CategoryAttribute("subtraction")]
        public async global::System.Threading.Tasks.Task SubstractTwoNumbers()
        {
            string[] tagsOfScenario = new string[] {
                    "subtraction"};
            global::System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new global::System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Substract two numbers", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 16
 await testRunner.GivenAsync("the first number is 50", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 17
 await testRunner.AndAsync("the second number is 30", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 18
 await testRunner.WhenAsync("the two numbers are subtracted", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 19
 await testRunner.ThenAsync("the result should be 20", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Multiply two numbers")]
        [NUnit.Framework.CategoryAttribute("multiplication")]
        public async global::System.Threading.Tasks.Task MultiplyTwoNumbers()
        {
            string[] tagsOfScenario = new string[] {
                    "multiplication"};
            global::System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new global::System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Multiply two numbers", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 22
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 23
 await testRunner.GivenAsync("the first number is 40", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 24
 await testRunner.AndAsync("the second number is 70", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 25
 await testRunner.WhenAsync("the two numbers are multiplied", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 26
 await testRunner.ThenAsync("the result should be 2800", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Divide two numbers")]
        [NUnit.Framework.CategoryAttribute("division")]
        public async global::System.Threading.Tasks.Task DivideTwoNumbers()
        {
            string[] tagsOfScenario = new string[] {
                    "division"};
            global::System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new global::System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Divide two numbers", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 29
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 30
 await testRunner.GivenAsync("the first number is 50", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 31
 await testRunner.AndAsync("the second number is 2", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 32
 await testRunner.WhenAsync("the two numbers are divided", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 33
 await testRunner.ThenAsync("the result should be 25", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
