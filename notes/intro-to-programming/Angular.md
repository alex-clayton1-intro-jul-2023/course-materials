
- Angular is the default to make it easy to transfer new developers to different projects. Good for making things run in a web browser.
	- Angular is very opinionated
	- The project structure, naming conventions, etc. are fairly consistent from one application to another.
	- React is good because everything is tweakable. A lot more customization.
	- Angular provides a fairly similar experience for every application.
		- Angular has UI library called CoreUI. Has a date-picker that has the same thing for across all the projects.

*To Create an Angular Application* #angular
- Angular Command Line Interface (Angular CLI) [Angular - CLI Overview and Command Reference](https://angular.io/cli)
	- Install it with:
		- `npm install --global @angular/cli@latest
		- `npm i -g @angular/cli@latest`
			- If you leave latest off, it assumes latest version. Otherwise can specify version after @
		- `ng new app --standalone --skip-git --skiptests`
			- Yes to routing
			- default css
		- Can always have a browser open that shows the current app
			- `ng serve -o`
				- the -o makes it open automatically for you
				- Must run in the folder with angular app

*Angular File Structure* #angular 
	- app.component.html has some stuff defined in there
		- Make sure to import components in here
	- Header.component.ts
		- Component file is structured  with
		- `export class HeaderComponent`
		- Before that component must be defined
			- Component must be imported from Angular
				- `import { Component } from "@angular/core";`
				- Define component as `standalone: true`

- Angular #angular 
	- NOT for creating websites or webpages
	- This is used for creating applications that download and build within a web browser
	- Written in Typescript #ts
		- Typescript compiles to JavaScript
		- TypeScript wants to address how JavaScript can change types for a variable.
		- Gets rid of lots of requirement for testing
	- Tool for creating User Interfaces
	- All file names MUST be undercase #qa

	- *Component*
		- A typescript class
		- A template
		- Both of these are compiled and sent to the browser
		- Don't put business logic in here ever.
		- Make these as dumb as possible.
	-  *A component has two jobs:*
		- Accurately project the application *state*
			- State: The value of all meaningful data NOW.
		- Provide affordances through which the user can interact with the application
			- A component 
		- Generate components by creating typescript class #ts
	- *Page*
		- Pages are things you route to
		- Components are other things


- Root
	- Most of stuff in root is config stuff
	- `Package.json` contains all dependencies, packages, etc.
		- contains` npm start`
			- `npm start` just calls` ng serve`
	-` package-lock.json` contains, when you build it for production, makes sure you use the EXACT same of packages that you had when you you developed it
	- `Angular.json` - configuration for angular files and how it works.
		- Little thing like all the selectors and if they will appear in a template or not.
		- prefix of "app" like in appnavigation and etc.
	- `.gitignore` will have stuff like node_modules.
		- It is not your code, there is no reason to track it. All of the dependencies will grab it.

- When running program, starts at main.ts
	- Imports` bootstrapApplication`from a location
		- Location always needs a path.
	- Imports `appComponent`
		- Typescript class for this.
		- It has metadata attached to it
			- This is the @Component ({ ...}) thing. It is the same as Attributes in C#
		- Selector called `'app-root'`


- `binding expression` use {{ }} To basically bind a variable name. It must be in the "export class ..." section of code
	- Must be the .html file for a .ts.
	- Can also do stuff like {{2+2}} and it will print 4.
	- also can do stuff like `{{title.toUpperCase()}}` and it will print the title but in upper case
	- Can also print lists a similar way
		- `friends = ['sean', 'david', 'lee']`
		- `{{friends}}` => "sean, david, lee"
		- `<li *ngFor="let friend of friends">{{friend}} </li>`
			- This prints a list of friends with the * out front
			-  `<button (click)="unFriend(friend)">Unfriend</button>`
				- This would remove the friend as long as the unFriend func is defined
		`unFriend(name: string) {
			`this.friends = this.friends.filter(n => n != name );
		 `}`
	-

- *template variable* starts with a # sign
- *HTMLInputElement* is the entire string. Can access its value with .value
- `ngif` and `ngfor` are how to do if/for in Angular
	- Also `ngClass` to add a class when conditional operator is fulfilled.
	- `${description}` <- reference to variable


- Create a new component with `ng g c components/todo-entry` or whatever name
- `ul>(li>span)*3` will expand this after hitting tab.
	- Unordered list, set of list items with a child that is a span. Give me 3 of them
- `models/index.ts`
	- Export tpye TodoListItemModel
		- Have a list of the data type in here, with an id/description/iscomplete
- `===` compares the type, not just the value. in JS, `1=="1"` returns true, but `1==="1"` is false
- `EventEmitter` is special thing where you can send value up to parent element.
	- Cab make it so when `(itemAdded)="doIt($event)"`


- Hierarchy of components
	- *TodosComponent* on top: Should own the list
		- *Add new item component*: Want to collect information and give it to parent component
		- *TodoListComponent* : Give it a list of stuff, then it displays it
			- `@Input(required = true) list: TodoListItemModel[] =[]`
				- `required = true` => will not work unless the list is passed in.

- Angular devtools
	- Can get for Edge on the Chrome store
	- [https://chrome.google.com/webstore/detail/angular-devtools/ienfalfjdbdpebioblfackkekamfmbnh](https://chrome.google.com/webstore/detail/angular-devtools/ienfalfjdbdpebioblfackkekamfmbnh "https://chrome.google.com/webstore/detail/angular-devtools/ienfalfjdbdpebioblfackkekamfmbnh")
	- 