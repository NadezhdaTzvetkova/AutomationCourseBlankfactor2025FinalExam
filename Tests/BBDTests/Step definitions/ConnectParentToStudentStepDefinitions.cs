using System;
using AventStack.ExtentReports;
using BackEndAutomation.Rest.Calls;
using BackEndAutomation.Rest.DataManagement;
using NUnit.Framework;
using Reqnroll;
using RestSharp;

namespace BackEndAutomation
{
    [Binding]
    public class ConnectParentToStudentStepDefinitions
    {
        private readonly RestCalls _restCalls;
        private readonly ResponseDataExtractors _extractResponseData;
        private readonly ScenarioContext _scenarioContext;
        private readonly ExtentTest _test;

        public ConnectParentToStudentStepDefinitions(ScenarioContext scenarioContext, RestCalls restCalls, ResponseDataExtractors extractResponseData)
        {
            _scenarioContext = scenarioContext;
            _restCalls = restCalls;
            _extractResponseData = extractResponseData;
            _test = scenarioContext.Get<ExtentTest>(ContextKeys.ExtentTestKey);
        }
        [When("admin connect parent {string} to student with id: {string}.")]
        public void AdminConnectParentToStudent_(string parent_username, string student_id)
        {
            _test.Info($"Initiating request to link parent '{parent_username}' with student ID '{student_id}'.");
            string token = _scenarioContext.Get<string>(ContextKeys.UserTokenKey);
            RestResponse response = _restCalls.ConnectParentCall(parent_username, student_id, token);

            if (!response.IsSuccessful)
            {
                // Extract error message from the response, if available
                string errorMessage = _extractResponseData.Extractor(response.Content, JsonIdentifierKeys.DetailKey);

                // Log the error and fail the test
                _test.Fail($"Failed to connect parent '{parent_username}' to student ID '{student_id}'. Error: {errorMessage}");
                Console.WriteLine($"Error while linking parent. Parent: {parent_username}, Student ID: {student_id}. Error: {errorMessage}");
                Assert.Fail($"Failed to link parent '{parent_username}' to student ID '{student_id}'. Error: {errorMessage}");
            }

            string message = _extractResponseData.Extractor(response.Content, JsonIdentifierKeys.MessageKey);
            _scenarioContext.Add(ContextKeys.MessageKey, message);
            _scenarioContext.Add(ContextKeys.ParentUsernameKey, parent_username);
            _scenarioContext.Add(ContextKeys.StudentIdKey, student_id);

            Console.WriteLine(response.Content);
            _test.Pass($"API call successful: Parent '{parent_username}' has been linked to student ID '{student_id}'. Response message: \"{message}\".");
        }

        [Then("validate parent is connected to student {string}.")]
        public void ValidateParentIsConnected_(string expectedMessage)
        {
            string actualMessage = _scenarioContext.Get<string>(ContextKeys.MessageKey);
            string parent_username = _scenarioContext.Get<string>(ContextKeys.ParentUsernameKey);
            string student_id = _scenarioContext.Get<string>(ContextKeys.StudentIdKey);

            Utilities.UtilitiesMethods.AssertEqual(
                expectedMessage,
                actualMessage,
                 $"Validation failed: Expected message does not match after connecting parent '{parent_username}' to student ID '{student_id}'.",
                _scenarioContext);

            Console.WriteLine($"{expectedMessage}");
            _test.Pass($"Validation successful: Parent '{parent_username}' is now connected to student ID '{student_id}'.");
        }
    }
}