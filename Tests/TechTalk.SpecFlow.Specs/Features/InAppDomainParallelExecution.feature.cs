﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TechTalk.SpecFlow.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("In-AppDomain Parallel Execution")]
    public partial class In_AppDomainParallelExecutionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "InAppDomainParallelExecution.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "In-AppDomain Parallel Execution", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
 testRunner.Given("there is a SpecFlow project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.And("the project is configured to use the NUnit provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 6
    testRunner.And("the following binding class", "[assembly: NUnit.Framework.Parallelizable(NUnit.Framework.ParallelScope.Fixtures)" +
                    "]", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And("the following step definition", @"public static int startIndex = 0;

[When(@""I do something"")]
public void WhenIDoSomething()
{
   var currentStartIndex = System.Threading.Interlocked.Increment(ref startIndex);
   Console.WriteLine(""Start index: {0}"", currentStartIndex);
   System.Threading.Thread.Sleep(200);
   var afterStartIndex = startIndex;
   if (afterStartIndex == currentStartIndex)
       Console.WriteLine(""Was not parallel"");
   else
       Console.WriteLine(""Was parallel"");
}", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.Given("there is a feature file in the project as", "Feature: Feature 1\nScenario Outline: Simple Scenario Outline\n     When I do somet" +
                    "hing\n\n    Examples:\n      | Count |\r\n      | 1     |\n      | 2     |\n      | 3  " +
                    "   |\n      | 4     |\n      | 5     |", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 41
 testRunner.Given("there is a feature file in the project as", "Feature: Feature 2\nScenario Outline: Simple Scenario Outline\n     When I do somet" +
                    "hing\n\n    Examples:\n      | Count |\r\n      | 1     |\n      | 2     |\n      | 3  " +
                    "   |\n      | 4     |\n      | 5     |", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Precondition: Tests run parallel with NUnit v3")]
        public virtual void PreconditionTestsRunParallelWithNUnitV3()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Precondition: Tests run parallel with NUnit v3", ((string[])(null)));
#line 56
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 57
    testRunner.When("I execute the tests with NUnit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
    testRunner.Then("the execution log should contain text \'Was parallel\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Tests should be processed parallel without failure")]
        public virtual void TestsShouldBeProcessedParallelWithoutFailure()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Tests should be processed parallel without failure", ((string[])(null)));
#line 60
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 61
    testRunner.When("I execute the tests with NUnit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
    testRunner.Then("the execution log should contain text \'Was parallel\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Total",
                        "Succeeded"});
            table1.AddRow(new string[] {
                        "10",
                        "10"});
#line 63
 testRunner.And("the execution summary should contain", ((string)(null)), table1, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void BeforeAfterTestRunHookShouldOnlyBeExecutedOnce(string @event, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Before/After TestRun hook should only be executed once", exampleTags);
#line 67
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 68
    testRunner.Given(string.Format("a hook \'HookFor{0}\' for \'{0}\'", @event), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 69
    testRunner.When("I execute the tests with NUnit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
    testRunner.Then("the execution log should contain text \'Was parallel\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 71
    testRunner.And(string.Format("the hook \'HookFor{0}\' is executed once", @event), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Before/After TestRun hook should only be executed once")]
        public virtual void BeforeAfterTestRunHookShouldOnlyBeExecutedOnce_BeforeTestRun()
        {
            this.BeforeAfterTestRunHookShouldOnlyBeExecutedOnce("BeforeTestRun", ((string[])(null)));
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Before/After TestRun hook should only be executed once")]
        public virtual void BeforeAfterTestRunHookShouldOnlyBeExecutedOnce_AfterTestRun()
        {
            this.BeforeAfterTestRunHookShouldOnlyBeExecutedOnce("AfterTestRun", ((string[])(null)));
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TraceListener should be called synchronously")]
        public virtual void TraceListenerShouldBeCalledSynchronously()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TraceListener should be called synchronously", ((string[])(null)));
#line 79
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
#line 80
    testRunner.Given("the following binding class", @"public class NonThreadSafeTraceListener : TechTalk.SpecFlow.Tracing.ITraceListener
{
    public int startIndex = 0;

    public void WriteTestOutput(string message)
    {
        var currentStartIndex = System.Threading.Interlocked.Increment(ref startIndex);
        System.Diagnostics.Debug.WriteLine(""NonThreadSafeTraceListener: {0}"", message);
        string filePath = Path.Combine(Path.GetTempPath(), ""NonThreadSafeTraceListener.log"");
        System.IO.File.AppendAllText(filePath, ""NonThreadSafeTraceListener: "" + message + Environment.NewLine);
        System.Threading.Thread.Sleep(100);
        var afterStartIndex = startIndex;
        if (afterStartIndex != currentStartIndex)
            throw new Exception(""Listener was called in parallel"");
    }

    public void WriteToolOutput(string message)
    {
        WriteTestOutput(""-> "" + message);
    }
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 104
 testRunner.Given("there is a feature file in the project as", "Feature: Feature 5\nScenario Outline: Simple Scenario Outline\n     When I do somet" +
                    "hing\n\n    Examples:\n      | Count |\r\n      | 1     |\n      | 2     |\n      | 3  " +
                    "   |\n      | 4     |\n      | 5     |", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 118
 testRunner.Given("there is a feature file in the project as", "Feature: Feature 3\nScenario Outline: Simple Scenario Outline\n     When I do somet" +
                    "hing\n\n    Examples:\n      | Count |\r\n      | 1     |\n      | 2     |\n      | 3  " +
                    "   |\n      | 4     |\n      | 5     |", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 132
 testRunner.Given("there is a feature file in the project as", "Feature: Feature 4\nScenario Outline: Simple Scenario Outline\n     When I do somet" +
                    "hing\n\n    Examples:\n      | Count |\r\n      | 1     |\n      | 2     |\n      | 3  " +
                    "   |\n      | 4     |\n      | 5     |", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 146
    testRunner.And("the type \'SpecFlow.TestProject.NonThreadSafeTraceListener, SpecFlow.TestProject\' " +
                    "is registered as \'TechTalk.SpecFlow.Tracing.ITraceListener\' in SpecFlow runtime " +
                    "configuration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 147
    testRunner.And("the log file \'NonThreadSafeTraceListener.log\' is empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
    testRunner.When("I execute the tests with NUnit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 149
    testRunner.Then("the execution log should contain text \'Was parallel\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 150
    testRunner.Then("the log file \'NonThreadSafeTraceListener.log\' should contain text \'NonThreadSafeT" +
                    "raceListener:\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 151
 testRunner.Then("the log file \'NonThreadSafeTraceListener.log\' should contain the text \'NonThreadS" +
                    "afeTraceListener:\' 50 times", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Total",
                        "Succeeded"});
            table2.AddRow(new string[] {
                        "25",
                        "25"});
#line 152
 testRunner.And("the execution summary should contain", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void CurrentContextCannotBeUsedInMulti_ThreadedExecution(string context, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Current context cannot be used in multi-threaded execution", exampleTags);
#line 157
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line hidden
#line 158
 testRunner.Given("there is a feature file in the project as", string.Format("Feature: Feature with {0}.Current\nScenario: Simple Scenario\n     When I use {0}.C" +
                        "urrent", context), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 164
 testRunner.And("the following step definition", string.Format("[When(@\"I use {0}.Current\")]\npublic void WhenIUseContextCurrent()\n{{\n   System.Th" +
                        "reading.Thread.Sleep(200);\n   Console.WriteLine({0}.Current);\r\n}}", context), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 173
    testRunner.When("I execute the tests with NUnit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 174
    testRunner.Then("the execution log should contain text \'Was parallel\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Failed"});
            table3.AddRow(new string[] {
                        "1"});
#line 175
 testRunner.And("the execution summary should contain", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Current context cannot be used in multi-threaded execution")]
        public virtual void CurrentContextCannotBeUsedInMulti_ThreadedExecution_ScenarioContext()
        {
            this.CurrentContextCannotBeUsedInMulti_ThreadedExecution("ScenarioContext", ((string[])(null)));
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Current context cannot be used in multi-threaded execution")]
        public virtual void CurrentContextCannotBeUsedInMulti_ThreadedExecution_FeatureContext()
        {
            this.CurrentContextCannotBeUsedInMulti_ThreadedExecution("FeatureContext", ((string[])(null)));
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Current context cannot be used in multi-threaded execution")]
        public virtual void CurrentContextCannotBeUsedInMulti_ThreadedExecution_ScenarioStepContext()
        {
            this.CurrentContextCannotBeUsedInMulti_ThreadedExecution("ScenarioStepContext", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion
