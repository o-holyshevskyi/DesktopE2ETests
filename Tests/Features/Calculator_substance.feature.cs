﻿// ------------------------------------------------------------------------------
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
namespace Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ValidateBasicOperationsLikeSubstanceTwoNumbersFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private static string[] featureTags = new string[] {
                "Calculator",
                "Substance"};
        
#line 1 "Calculator_substance.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Validate basic operations like substance two numbers", "Calculator: Simple Tests for Windows Calculator", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Validate basic operations like substance two numbers")))
            {
                global::Tests.Features.ValidateBasicOperationsLikeSubstanceTwoNumbersFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SubstanceTwoNumbers(string number1, string operator1, string number2, string operator2, string result, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("number1", number1);
            argumentsOfScenario.Add("operator1", operator1);
            argumentsOfScenario.Add("number2", number2);
            argumentsOfScenario.Add("operator2", operator2);
            argumentsOfScenario.Add("result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Substance two numbers", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
 testRunner.Given("Calculator starts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.When(string.Format("User selects number {0}", number1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.And(string.Format("User press operator {0}", operator1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And(string.Format("User selects number {0}", number2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And(string.Format("User press operator {0}", operator2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.Then(string.Format("Result should be {0}", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Substance two numbers: 9")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate basic operations like substance two numbers")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Calculator")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Substance")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExampleSet0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "9")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number1", "9")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator1", "-")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number2", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator2", "=")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "8")]
        public void SubstanceTwoNumbers_ExampleSet0_9()
        {
#line 6
this.SubstanceTwoNumbers("9", "-", "1", "=", "8", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Substance two numbers: 8")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate basic operations like substance two numbers")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Calculator")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Substance")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExampleSet0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "8")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number1", "8")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator1", "-")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number2", "2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator2", "=")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "6")]
        public void SubstanceTwoNumbers_ExampleSet0_8()
        {
#line 6
this.SubstanceTwoNumbers("8", "-", "2", "=", "6", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Substance two numbers: 7")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate basic operations like substance two numbers")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Calculator")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Substance")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExampleSet0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "7")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number1", "7")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator1", "-")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number2", "3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator2", "=")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "4")]
        public void SubstanceTwoNumbers_ExampleSet0_7()
        {
#line 6
this.SubstanceTwoNumbers("7", "-", "3", "=", "4", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Substance two numbers: 6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate basic operations like substance two numbers")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Calculator")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Substance")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExampleSet0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number1", "6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator1", "-")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number2", "4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator2", "=")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "2")]
        public void SubstanceTwoNumbers_ExampleSet0_6()
        {
#line 6
this.SubstanceTwoNumbers("6", "-", "4", "=", "2", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Substance two numbers: 5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate basic operations like substance two numbers")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Calculator")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Substance")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExampleSet0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number1", "5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator1", "-")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number2", "5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator2", "=")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "0")]
        public void SubstanceTwoNumbers_ExampleSet0_5()
        {
#line 6
this.SubstanceTwoNumbers("5", "-", "5", "=", "0", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Substance two numbers: 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate basic operations like substance two numbers")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Calculator")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Substance")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExampleSet0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number1", "4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator1", "-")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number2", "6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator2", "=")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "-2")]
        public void SubstanceTwoNumbers_ExampleSet0_4()
        {
#line 6
this.SubstanceTwoNumbers("4", "-", "6", "=", "-2", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Substance two numbers: 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate basic operations like substance two numbers")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Calculator")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Substance")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExampleSet0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number1", "3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator1", "-")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number2", "7")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator2", "=")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "-4")]
        public void SubstanceTwoNumbers_ExampleSet0_3()
        {
#line 6
this.SubstanceTwoNumbers("3", "-", "7", "=", "-4", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Substance two numbers: 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate basic operations like substance two numbers")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Calculator")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Substance")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExampleSet0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number1", "2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator1", "-")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number2", "8")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator2", "=")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "-6")]
        public void SubstanceTwoNumbers_ExampleSet0_2()
        {
#line 6
this.SubstanceTwoNumbers("2", "-", "8", "=", "-6", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Substance two numbers: 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate basic operations like substance two numbers")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Calculator")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Substance")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExampleSet0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number1", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator1", "-")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number2", "9")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator2", "=")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "-8")]
        public void SubstanceTwoNumbers_ExampleSet0_1()
        {
#line 6
this.SubstanceTwoNumbers("1", "-", "9", "=", "-8", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Substance two numbers: 9")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate basic operations like substance two numbers")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Calculator")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Substance")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExampleSet1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "9")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number1", "9")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator1", "-")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:number2", "5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operator2", "=")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:result", "4")]
        public void SubstanceTwoNumbers_ExampleSet1_9()
        {
#line 6
this.SubstanceTwoNumbers("9", "-", "5", "=", "4", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
