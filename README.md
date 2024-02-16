# FundEasy

Test Coverage

The tests cover key functionalities of the Collector Portal within the FundEasy application, with a focus on the campaign creation and the login process, as they are fundamental actions a user would conduct.

Design Assumptions

Each test is designed to start with a fresh WebDriver instance that gets closed upon the conclusion of the test execution.
It is assumed that the locations of webpage elements identified by By.Id will not change.
Separate classes were created for each page to be tested, adhering to the Page Object Model pattern.
A principle of separation between web locators and methods that interact with these locators was applied to maintain minimal code coupling and ease future maintenance.

Setup Instructions

Visual Studio should be installed.
This repository needs to be cloned or downloaded.
The .sln solution should be opened in Visual Studio.
Addition of new tests simply requires the creating of a new .feature file and then writing new scenarios in Gherkin format. If these tests require new pages or classes, they can be created as needed.
