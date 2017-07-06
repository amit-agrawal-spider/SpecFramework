﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFramework.ProjectLibs.Tests.TestCases.UI.FeatureFiles
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("MarkLMSAttendanceWithAttendanceTray", SourceFile="ProjectLibs\\Tests\\TestCases\\UI\\FeatureFiles\\AttendanceTray.feature", SourceLine=0)]
    public partial class MarkLMSAttendanceWithAttendanceTrayFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AttendanceTray.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MarkLMSAttendanceWithAttendanceTray", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
        
        public virtual void VerifyTheAttendanceGetsMarkedAsExpectedWhenUserIsInOfficeForTheDayOfficeOffice(string firstHalfOption, string secondHalfOption, string firstHalfExpected, string secondHalfExpected, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "cefapp"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify the attendance gets marked as expected when user is in office for the day(" +
                    "office,office)", @__tags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("Tray App opens up and user logs in with his wipfli credenditals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.When(string.Format("the user marks the attendance as first half {0} and second half {1}", firstHalfOption, secondHalfOption), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.Then(string.Format("his attendance should get marked/saved as {0} and {1}", firstHalfExpected, secondHalfExpected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the attendance gets marked as expected when user is in office for the day(" +
            "office,office), Variant 0", new string[] {
                "cefapp"}, SourceLine=10)]
        public virtual void VerifyTheAttendanceGetsMarkedAsExpectedWhenUserIsInOfficeForTheDayOfficeOffice_Variant0()
        {
            this.VerifyTheAttendanceGetsMarkedAsExpectedWhenUserIsInOfficeForTheDayOfficeOffice("firstHalfInOffice", "secondHalfInOffice", "attendanceForUser.FirstHalf==1", "attendanceForUser.SecondHalf==1", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the attendance gets marked as expected when user is in office for the day(" +
            "office,office), Variant 1", new string[] {
                "cefapp"}, SourceLine=10)]
        public virtual void VerifyTheAttendanceGetsMarkedAsExpectedWhenUserIsInOfficeForTheDayOfficeOffice_Variant1()
        {
            this.VerifyTheAttendanceGetsMarkedAsExpectedWhenUserIsInOfficeForTheDayOfficeOffice("", "", "attendanceForUser.FirstHalf==1", "attendanceForUser.SecondHalf==1", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the attendance gets marked as expected when user is in office for the day(" +
            "office,office), Variant 2", new string[] {
                "cefapp"}, SourceLine=10)]
        public virtual void VerifyTheAttendanceGetsMarkedAsExpectedWhenUserIsInOfficeForTheDayOfficeOffice_Variant2()
        {
            this.VerifyTheAttendanceGetsMarkedAsExpectedWhenUserIsInOfficeForTheDayOfficeOffice("firstHalfInOffice", "", "attendanceForUser.FirstHalf==1", "attendanceForUser.SecondHalf==1", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the attendance gets marked as expected when user is in office for the day(" +
            "office,office), Variant 3", new string[] {
                "cefapp"}, SourceLine=10)]
        public virtual void VerifyTheAttendanceGetsMarkedAsExpectedWhenUserIsInOfficeForTheDayOfficeOffice_Variant3()
        {
            this.VerifyTheAttendanceGetsMarkedAsExpectedWhenUserIsInOfficeForTheDayOfficeOffice("", "secondHalfInOffice", "attendanceForUser.FirstHalf==1", "attendanceForUser.SecondHalf==1", ((string[])(null)));
#line hidden
        }
        
        public virtual void VerifyTheAttendanceGetsMarkedAsExpectedWhenUserSelectsAnyOfWFHInOfficeOfficialTravelOptionsForTheFirstHalfAnd2NdHalf(string firstHalfOption, string secondHalfOption, string comments, string recipients, string firstHalfExpected, string secondHalfExpected, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify the attendance gets marked as expected when user selects any of \'WFH/InOff" +
                    "ice/Official Travel\' options for the first half and 2nd half", exampleTags);
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given("Tray App opens up and user logs in with his wipfli credenditals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.When(string.Format("User marks the attendance as first half {0} and second half {1} and adds the comm" +
                        "ents {2} and recipients {3}", firstHalfOption, secondHalfOption, comments, recipients), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then(string.Format("his attendance should get marked/saved as {0} and {1}", firstHalfExpected, secondHalfExpected), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the attendance gets marked as expected when user selects any of \'WFH/InOff" +
            "ice/Official Travel\' options for the first half and 2nd half, Variant 0", SourceLine=23)]
        public virtual void VerifyTheAttendanceGetsMarkedAsExpectedWhenUserSelectsAnyOfWFHInOfficeOfficialTravelOptionsForTheFirstHalfAnd2NdHalf_Variant0()
        {
            this.VerifyTheAttendanceGetsMarkedAsExpectedWhenUserSelectsAnyOfWFHInOfficeOfficialTravelOptionsForTheFirstHalfAnd2NdHalf("firstHalfInOffice", "secondHalfWfh", "Not Well", "Uday Jampala <ujampala@spiderlogic.com>", "attendanceForUser.FirstHalf==1", "attendanceForUser.SecondHalf==2", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the attendance gets marked as expected when user selects any of \'WFH/InOff" +
            "ice/Official Travel\' options for the first half and 2nd half, Variant 1", SourceLine=23)]
        public virtual void VerifyTheAttendanceGetsMarkedAsExpectedWhenUserSelectsAnyOfWFHInOfficeOfficialTravelOptionsForTheFirstHalfAnd2NdHalf_Variant1()
        {
            this.VerifyTheAttendanceGetsMarkedAsExpectedWhenUserSelectsAnyOfWFHInOfficeOfficialTravelOptionsForTheFirstHalfAnd2NdHalf("firstHalfWfh", "secondHalfInOffice", "Courier expected", "Uday Jampala <ujampala@spiderlogic.com>", "attendanceForUser.FirstHalf==2", "attendanceForUser.SecondHalf==1", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the attendance gets marked as expected when user selects any of \'WFH/InOff" +
            "ice/Official Travel\' options for the first half and 2nd half, Variant 2", SourceLine=23)]
        public virtual void VerifyTheAttendanceGetsMarkedAsExpectedWhenUserSelectsAnyOfWFHInOfficeOfficialTravelOptionsForTheFirstHalfAnd2NdHalf_Variant2()
        {
            this.VerifyTheAttendanceGetsMarkedAsExpectedWhenUserSelectsAnyOfWFHInOfficeOfficialTravelOptionsForTheFirstHalfAnd2NdHalf("firstHalfWfh", "secondHalfWfh", "baby sitting", "Uday Jampala <ujampala@spiderlogic.com>", "attendanceForUser.FirstHalf==2", "attendanceForUser.SecondHalf==2", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the attendance gets marked as expected when user selects any of \'WFH/InOff" +
            "ice/Official Travel\' options for the first half and 2nd half, Variant 3", SourceLine=23)]
        public virtual void VerifyTheAttendanceGetsMarkedAsExpectedWhenUserSelectsAnyOfWFHInOfficeOfficialTravelOptionsForTheFirstHalfAnd2NdHalf_Variant3()
        {
            this.VerifyTheAttendanceGetsMarkedAsExpectedWhenUserSelectsAnyOfWFHInOfficeOfficialTravelOptionsForTheFirstHalfAnd2NdHalf("firstHalfOfficial", "secondHalfInOffice", "Banglore Travel", "Uday Jampala <ujampala@spiderlogic.com>", "attendanceForUser.FirstHalf==3", "attendanceForUser.SecondHalf==1", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the attendance gets marked as expected when user selects any of \'WFH/InOff" +
            "ice/Official Travel\' options for the first half and 2nd half, Variant 4", SourceLine=23)]
        public virtual void VerifyTheAttendanceGetsMarkedAsExpectedWhenUserSelectsAnyOfWFHInOfficeOfficialTravelOptionsForTheFirstHalfAnd2NdHalf_Variant4()
        {
            this.VerifyTheAttendanceGetsMarkedAsExpectedWhenUserSelectsAnyOfWFHInOfficeOfficialTravelOptionsForTheFirstHalfAnd2NdHalf("firstHalfInOffice", "secondHalfOfficial", "Flying to Blore", "Uday Jampala <ujampala@spiderlogic.com>", "attendanceForUser.FirstHalf==1", "attendanceForUser.SecondHalf==3", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the attendance gets marked as expected when user selects any of \'WFH/InOff" +
            "ice/Official Travel\' options for the first half and 2nd half, Variant 5", SourceLine=23)]
        public virtual void VerifyTheAttendanceGetsMarkedAsExpectedWhenUserSelectsAnyOfWFHInOfficeOfficialTravelOptionsForTheFirstHalfAnd2NdHalf_Variant5()
        {
            this.VerifyTheAttendanceGetsMarkedAsExpectedWhenUserSelectsAnyOfWFHInOfficeOfficialTravelOptionsForTheFirstHalfAnd2NdHalf("firstHalfOfficial", "secondHalfOfficial", "US Travel", "Uday Jampala <ujampala@spiderlogic.com>", "attendanceForUser.FirstHalf==3", "attendanceForUser.SecondHalf==3", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the attendance gets marked as expected when user selects any of \'WFH/InOff" +
            "ice/Official Travel\' options for the first half and 2nd half, Variant 6", SourceLine=23)]
        public virtual void VerifyTheAttendanceGetsMarkedAsExpectedWhenUserSelectsAnyOfWFHInOfficeOfficialTravelOptionsForTheFirstHalfAnd2NdHalf_Variant6()
        {
            this.VerifyTheAttendanceGetsMarkedAsExpectedWhenUserSelectsAnyOfWFHInOfficeOfficialTravelOptionsForTheFirstHalfAnd2NdHalf("firstHalfOfficial", "secondHalfWfh", "Out of station", "Uday Jampala <ujampala@spiderlogic.com>", "attendanceForUser.FirstHalf==3", "attendanceForUser.SecondHalf==2", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the attendance gets marked as expected when user selects any of \'WFH/InOff" +
            "ice/Official Travel\' options for the first half and 2nd half, Variant 7", SourceLine=23)]
        public virtual void VerifyTheAttendanceGetsMarkedAsExpectedWhenUserSelectsAnyOfWFHInOfficeOfficialTravelOptionsForTheFirstHalfAnd2NdHalf_Variant7()
        {
            this.VerifyTheAttendanceGetsMarkedAsExpectedWhenUserSelectsAnyOfWFHInOfficeOfficialTravelOptionsForTheFirstHalfAnd2NdHalf("firstHalfWfh", "secondHalfOfficial", "Attending Conf", "Uday Jampala <ujampala@spiderlogic.com>", "attendanceForUser.FirstHalf==2", "attendanceForUser.SecondHalf==3", ((string[])(null)));
#line hidden
        }
        
        public virtual void VerifyTheAttendanceGetsMarkedAsExpectedWhenUserIsOnLeaveForADayOrHalf(string firstHalfOption, string secondHalfOption, string comments, string recipients, string firstHalfExpected, string secondHalfExpected, string leaveCount, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify the attendance gets marked as expected when user is on leave for a day or " +
                    "half", exampleTags);
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
 testRunner.Given("the Tray App opens up and user logs in with his wipfli credenditals to mark leave" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
 testRunner.When(string.Format("User marks the attendance as first half {0} and second half {1} and adds the comm" +
                        "ents {2} and recipients {3}", firstHalfOption, secondHalfOption, comments, recipients), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then(string.Format("users attendance should get marked/saved as {0} and {1} and leave balance should " +
                        "be calculated based on leave count {2}", firstHalfExpected, secondHalfExpected, leaveCount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify the attendance gets marked as expected when user is on leave for a day or " +
            "half, firstHalfLeave", SourceLine=40)]
        public virtual void VerifyTheAttendanceGetsMarkedAsExpectedWhenUserIsOnLeaveForADayOrHalf_FirstHalfLeave()
        {
            this.VerifyTheAttendanceGetsMarkedAsExpectedWhenUserIsOnLeaveForADayOrHalf("firstHalfLeave", "secondHalfLeave", "Day Off", "Uday Jampala <ujampala@spiderlogic.com>", "attendanceForUser.FirstHalf==4", "attendanceForUser.SecondHalf==4", "1", ((string[])(null)));
#line hidden
        }
        
        public virtual void VerifyCancelLeave(string firstHalfOption, string secondHalfOption, string firstHalfExpected, string secondHalfExpected, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify cancel leave", exampleTags);
#line 43
this.ScenarioSetup(scenarioInfo);
#line 44
 testRunner.Given("try", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
 testRunner.When("cancel leave", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.Then("gets canceled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify cancel leave, firstHalfInOffice", SourceLine=49)]
        public virtual void VerifyCancelLeave_FirstHalfInOffice()
        {
            this.VerifyCancelLeave("firstHalfInOffice", "secondHalfInOffice", "attendanceForUser.FirstHalf==1", "attendanceForUser.SecondHalf==1", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
