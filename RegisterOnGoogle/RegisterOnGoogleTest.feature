Feature: GmailRegistration
		 In order to have a gmail account 
		 As a user
		 I want to be able to create a gmail account


Scenario: Successful Register with valid account
	  Given a user is on Google page 
	  And the user navigate to account creation site
	 When the User enter credentials
	| Firstname  | secondname | username| password | confpassword| birthdaym|birthdayd| birthdayy| gender| phone| emailadd|
	|pebbles |sheki | 445rer12345 | 9056qw0www |9056qw0www |July |27 |1994 |female |7333563222 |saee@hotmail.com |
	 And The user clicks on the nextstep button
	  And The user click on the scroll button that appears on Privacy and Terms message
  	  And The user click on the scroll button that appears on Privacy and Terms message
	  And The user clicks on the I agree button
 	  And The welcome page appears
	  And The user clicks on the continue button
	  Then a Valid registered account appears with account email 

Scenario Outline: Register with Invalid Account
 	 Given a user is on Google page 
	  And the user navigate to account creation site
	 When the User enter credentials <firstname>, <secondname> and <username>
	 And the user click on create password box
	Then the user should see an error message telling the user (Please use only letters (a-z), numbers, and periods) 	   
Examples: 
	| firstname | secondname | username    |
	| Shawn     | Bravo      | bolatony12_ |

Scenario: Successful Login and Logout with Valid Credentials
	  Given a user is on Google page 
	  And the user click on the sign in button	
	  And the user enter a valid username bolatony1234
	  And the user click on the next button		
	  And the user enter a valid password 7890wwww
	  When the user click on the next button	
	  And the user click on the gmail button on the welcome page 
	  And the user click on the google account button
	  When the user click on the sign out button
	  Then the user should be logout successfully
	 