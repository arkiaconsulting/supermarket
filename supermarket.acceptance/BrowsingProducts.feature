Feature: BrowsingProducts

Background: 
	Given The following users exist:
		| id  | userName | preferred |
		| abc | Louis    | false     |
		| def | John     | true      |
	Given The following products exist:
		| id  | name                   | category   | price |
		| abc | Western Digital 150 Go | Hard Disks | 100   |
		| def | Seagate 150 Go         | Hard Disks | 150   |
		| ghi | Lacie 1 To             | Hard Disks | 200   |

Scenario: Browsing a product category

Given I'm authenticated as Louis
When I choose the Hard Disks category
Then I can see a list of all the products
	| id  | name                   | price |
	| abc | Western Digital 150 Go | 100   |
	| def | Seagate 150 Go         | 150   |
	| ghi | Lacie 1 To             | 200   |

Scenario: Display right prices

Given I'm authenticated as John
When I choose the Hard Disks category
Then I can see a list of all the products
	| id  | name                   | price |
	| abc | Western Digital 150 Go | 90    |
	| def | Seagate 150 Go         | 135   |
	| ghi | Lacie 1 To             | 180   |