.NET
- We create "Types"
- There are only "kinds" of types in .NET
	- References
		- Live on the *heap*
		- Created with Classes (and records)
		- 
	- Values
		- Numbers (int, double, single, float, decimal, etc)
		- DateTime
		- You can create new values by creating a Struct
		- These live on the *stack*.



can't do stuff like `var fe = foreach;`

but in javascript, a function can be assigned to a variable


*Classes* define the two things an object can have:
- Data (state)
	- "Class level variables", "Fields"
		- Almost always encapsulated as "private"
- Behavior (methods, properties, constructors)
	- Usually public things that allow the user of an instance of that type to interact with the state