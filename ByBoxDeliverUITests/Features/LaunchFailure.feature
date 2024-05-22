Feature: LaunchFailure

ByBox Deliver - check-in error for unable to reach server
Scenario: Unable to connect to the server error page should be displayed when the internal error status repsonse 
   Given  As a user launch the bybox deliver
	Then Error message page is diaplayed with "Unable to connect to the server"
