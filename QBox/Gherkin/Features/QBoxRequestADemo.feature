Feature: QBoxRequestADemo
	As a visitor to the QBox web site, 
	I want to request a demo from a salesperson, 
	so that they can show me more about how QBox works, and I can find out whether it’s relevant for me.

@Functional
Scenario: Request a QBox Demo with well configuration
	Given the Qbox Demo request form
	And all the needed fields are well informed
	When Complete Captcha 
	And Submit button is clicked on 
	Then the salesperson see a new lead in their CRM tool
	And the visitor receive a confirmation that the demo is received

@Functional
Scenario: Request a QBox Demo with a non coporate email
	Given the Qbox Demo request form
	And a non corporate Email: <NonCorporateEmail>
	And the rest of the needed fields well informed
	When Complete Captcha 
	And Submit button is clicked on 
	Then an error message is displayed just below the email field.
	Examples: 
	| NonCorporateEmail |
	| QBox@gmail.com    |
	| QBox@hotmai.com   |

@Functional
Scenario: Request a QBox Demo without some empty required fields
	Given the Qbox Demo request form 
	And some empty required fields : <Email>, <FirstName>, <SecondName>, <JobTitle>, <Industry>
	When Complete Captcha 
	And Submit button is clicked on 
	Then a error message is displayed just below the empty required field
	Examples: 
	| Email    | FirstName | SecondName | JobTitle | Industry |
	| Empty    | NonEmpty  | NonEmpty   | NonEmpty | NonEmpty |
	| NonEmpty | Empty     | NonEmpty   | NonEmpty | NonEmpty |
	| NonEmpty | NonEmpty  | Empty      | NonEmpty | NonEmpty |
	| NonEmpty | NonEmpty  | NonEmpty   | Empty    | NonEmpty |
	| NonEmpty | NonEmpty  | NonEmpty   | NonEmpty | Empty    |

@NonFunctional
Scenario: Request a QBox Demo testing the max-lenght of the text fields
	Given the Qbox Demo request form 
	And a text with minimun number of characters to exceed the field maxlenght: <FieldMaxLenght>
	When Complete Captcha 
	And Submit button is clicked on 
	Then a error message is displayed just below the field
	Examples: 
	| FieldMaxLenght |
	| CompanyEmail   |
	| FirstName      |
	| LastName       |
	| JobTitle       |
	| Industry       |




	
	

