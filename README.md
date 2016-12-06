# Test User Service

This service demos the camel case potential issue with model validation errors

## To Test/Run Locally

  * I've added two basic tests to show the potential issue.
  * See Startup.cs for the AddJsonFormatters line in question.
  * Run the unit tests and TestGetInvalid will fail since it's excepting the default formatter to be camel.
  * Uncomment out AddJsonFormatters and run the tests again and TestGetInvalid will pass since the model errors are now camel case.
  * However, with TestGetValid it doesn't matter if AddJsonFormatters is active or not since the default formatter is camel.
