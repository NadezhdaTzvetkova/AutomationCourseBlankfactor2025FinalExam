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
namespace BackEndAutomation.Tests.BBDTests.FeatureFiles
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Teacher")]
    public partial class TeacherFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Tests/BBDTests/Feature files", "Teacher", "  Teacher authentication and class management.", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "Teacher.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
            {
                await testRunner.OnFeatureEndAsync();
            }
            if ((testRunner.FeatureContext == null))
            {
                await testRunner.OnFeatureStartAsync(featureInfo);
            }
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        public virtual async System.Threading.Tasks.Task FeatureBackgroundAsync()
        {
#line 5
#line hidden
#line 6
 await testRunner.GivenAsync("user signs in with \"teacher11\" username and \"teacher11\" password.", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sign in and receive a token")]
        public async System.Threading.Tasks.Task SignInAndReceiveAToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Sign in and receive a token", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
#line 5
await this.FeatureBackgroundAsync();
#line hidden
#line 9
 await testRunner.ThenAsync("validate that the user is signed in.", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a class")]
        [NUnit.Framework.CategoryAttribute("Positive_flow")]
        [NUnit.Framework.TestCaseAttribute("Class C", "Math", "History", "Biologic", "Class created", null)]
        [NUnit.Framework.TestCaseAttribute("Class B", "Chemistry", "Physics", "Literature", "Class created", null)]
        public async System.Threading.Tasks.Task CreateAClass(string classname, string subject_1, string subject_2, string subject_3, string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Positive_flow"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("classname", classname);
            argumentsOfScenario.Add("subject_1", subject_1);
            argumentsOfScenario.Add("subject_2", subject_2);
            argumentsOfScenario.Add("subject_3", subject_3);
            argumentsOfScenario.Add("message", message);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Create a class", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 12
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 5
await this.FeatureBackgroundAsync();
#line hidden
#line 13
 await testRunner.WhenAsync(string.Format("teacher creates a class with \"{0}\" classname, \"{1}\" subject_1, \"{2}\" subject_2 an" +
                            "d \"{3}\" subject_3.", classname, subject_1, subject_2, subject_3), ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 14
 await testRunner.ThenAsync(string.Format("validate class is created \"{0}\".", message), ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add stuednt to class")]
        [NUnit.Framework.CategoryAttribute("Positive_flow")]
        [NUnit.Framework.TestCaseAttribute("Student6", "ecadac35-dd50-4120-b876-411ec0d51cd9", "Student added", null)]
        [NUnit.Framework.TestCaseAttribute("Student2", "2f2fa5e2-6c5e-4e58-80b4-bf469eff79e8", "Student added", null)]
        public async System.Threading.Tasks.Task AddStuedntToClass(string name, string class_Id, string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Positive_flow"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("name", name);
            argumentsOfScenario.Add("class_id", class_Id);
            argumentsOfScenario.Add("message", message);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Add stuednt to class", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
#line 5
await this.FeatureBackgroundAsync();
#line hidden
#line 23
 await testRunner.WhenAsync(string.Format("teacher add student with \"{0}\" name and \"{1}\" class id.", name, class_Id), ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 24
 await testRunner.ThenAsync(string.Format("validate that student is added \"{0}\".", message), ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add and update grade")]
        [NUnit.Framework.CategoryAttribute("Positive_flow")]
        public async System.Threading.Tasks.Task AddAndUpdateGrade()
        {
            string[] tagsOfScenario = new string[] {
                    "Positive_flow"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Add and update grade", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 32
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 5
await this.FeatureBackgroundAsync();
#line hidden
#line 33
 await testRunner.WhenAsync("teacher add grade: \"2\", to student: \"2164e5a5-8c01-40e4-9210-6f38476cdd2a\", in su" +
                        "bject: \"Biologic\".", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 34
 await testRunner.ThenAsync("validate that grade is added to student \"Grade added\".", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 35
 await testRunner.AndAsync("teacher update grade to \"5\".", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 36
 await testRunner.AndAsync("validate that grade is updated \"Grade updated\".", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
