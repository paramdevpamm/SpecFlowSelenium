Feature: BGC
	Simple test scenarios

@bgcInterview
Scenario: Open the new browser and validate page title
	Given The link https://www.saucedemo.com/ is provided
	Then The page title should be Swag Labs

@bgcInterview
Scenario: Verify that a correct error message shows up when an inactive user tries to log in
	Given The link https://www.saucedemo.com/ is provided
	And User logs in using userName as locked_out_user and password as secret_sauce
	Then An Error message is displayed as Epic sadface: Sorry, this user has been locked out.

@bgcInterview
Scenario: Verify that the correct inventory items show up on the main page
	Given The link https://www.saucedemo.com/ is provided
	And User logs in using userName as performance_glitch_user and password as secret_sauce
	Then User is logged in successfully and PRODUCTS heading is displayed
	And Validate the URL of the page is https://www.saucedemo.com/inventory.html
	And Validate that there are 6 items displayed
	And All the items are present on the page as 'Backpack, Bolt T-Shirt, Onesie, Bike Light, Fleece Jacket, T-Shirt red'

@bgcInterview
Scenario: Verify that each item can be added to the cart
	Given The link https://www.saucedemo.com/ is provided
	And User logs in using userName as performance_glitch_user and password as secret_sauce
	Then User is logged in successfully and PRODUCTS heading is displayed
	And Validate the URL of the page is https://www.saucedemo.com/inventory.html
	And Validate that there are 6 items displayed
	When User click on Add cart for all items as 'Backpack, Bolt T-Shirt, Onesie, Bike Light, Fleece Jacket, T-Shirt red'
	And User clicks on Cart to view items in the cart
	Then All the items are present on the page as 'Backpack, Bolt T-Shirt, Onesie, Bike Light, Fleece Jacket, T-Shirt red'