Feature: SearchingTest

    @ToDoApp
    Scenario: Testing google homepage searchbar
	Given Google homepage searchbard on this environment
	| Browser | BrowserVersion | Os     |
	| Chrome  | 95.0           | Windows 10 | 
	And Left click on searchbar
	Then Add some text you want to search for
	Then The searchbar should start giving you tips
	Then Click on enter
	Then You are able to see results of the search

	@ToDoApp
    Scenario: Testing google search pictures link
	Given Google homepage searchbard on this environment
	| Browser | BrowserVersion | Os     |
	| Chrome  | 95.0           | Windows 10 | 
	And Left click on searchbar
	Then Add some text you want to search for
	Then The searchbar should start giving you tips
	Then Click on enter
	Then You are able to see results of the search
	Then Left click on images text

	@ToDoApp
    Scenario: Testing google search videos link
	Given Google homepage searchbard on this environment
	| Browser | BrowserVersion | Os     |
	| Chrome  | 95.0           | Windows 10 | 
	And Left click on searchbar
	Then Add some text you want to search for
	Then The searchbar should start giving you tips
	Then Click on enter
	Then You are able to see results of the search
	Then Left click on videos text

	@ToDoApp
    Scenario: Testing google search books link
	Given Google homepage searchbard on this environment
	| Browser | BrowserVersion | Os     |
	| Chrome  | 95.0           | Windows 10 | 
	And Left click on searchbar
	Then Add some text you want to search for
	Then The searchbar should start giving you tips
	Then Click on enter
	Then You are able to see results of the search
	Then Left click on books text

	@ToDoApp
    Scenario: Testing failed google search 
	Given Google homepage searchbard on this environment
	| Browser | BrowserVersion | Os     |
	| Chrome  | 95.0           | Windows 10 | 
	And Left click on searchbar
	Then Add some text you want to search for
	Then The searchbar should start giving you tips
	Then Click on enter
	Then You are able to see results of the search
	Then Left click on failed text
