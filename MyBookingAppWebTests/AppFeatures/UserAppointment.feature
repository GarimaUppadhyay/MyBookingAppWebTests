Feature: UserAppointment

Scenario Outline: Login User and Validate successful booking
	Given User navigates to Login screen
	And User enters <email> and <password> and clicks Login
	Then User Should successfully navigates to booking page
	Then User clicks on new appointment button & enter new App Details with <title> <date> <time> and Click save
	And Validate Appointment details should be visible after saving with success <message>
	
Examples:
	| email           | password |  title           | date       | time    | message            |
	| TestId@test.com | Test123  | Sprint Planning | 02-08-2024 | 11:00am | Appointment Saved! |