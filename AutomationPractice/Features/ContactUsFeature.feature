﻿Feature: ContactUsFeature
		In order to contact customer service
		i want to fill in the form
		And submit the form


@Contact
Scenario: User can contact customer service
	Given user opens contact us page
	And fills in all required fields with 'Webmaster' heading and 'QA Test' message
	When user submits the form
	Then message 'Your message has been successfully sent to our team.' is presented to the user
