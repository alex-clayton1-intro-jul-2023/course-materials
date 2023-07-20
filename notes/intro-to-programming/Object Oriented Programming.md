- Procedural Programming
	- Decisions, loops, variables
	- Need to keep everything in your mind
	- Can't represent software anymore as a series of empirical steps
- SAABRE - Flight Reservation and Tracking
	- Largest software at the time. It was impossible to express in one script.
	- Just gets too big and impossible to know everything happening at once.


- Data (State)
- Code that works on that data (behavior)

- OOP
	- Want to create capsule of related data and behavior
	- When possible, relate data and state together in a capsule
	- If you have some data, and you want to do something with it, that data should know how to do it.
		- if you have a string, the string should know how to convert it to upper case.
	- Want to create *types* like classes. This will be able to represent stuff like
- *Cohesion*
	- Making sure that the behaviors of a type are related to the data of that type.
	- e.g. a string in .NET knows how to do a lot of string stuff.


x.Bark();
x.RollOver();
int.Parse("123")
var someNumber = "123";
var x = someNumber.ToInteger();


[[dotnet]]
