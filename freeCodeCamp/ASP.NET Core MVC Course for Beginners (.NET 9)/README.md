# ASP.NET Core MVC Course for Beginners (.NET 9)

This folder contains the code to learn ASP.NET Core MVC and Entity Framework Core in .NET 9 from scratch, along with a step-by-step tutorial from the ASP.NET Core MVC Course for Beginners (.NET 9) on [freeCodeCamp’s YouTube Channel](https://www.youtube.com/watch?v=RWXKysImabs).

![](https://cdn.hashnode.com/res/hashnode/image/upload/v1727804056078/cb9e584f-9942-4169-a68b-3379bb803692.png)

- Duration: 6/10/2025 - 8/10/2025 
- Video Duration: 2 hour 12 minutes

---

## What I Learned

- What is MVC?<br>
M = Models - A class represent the data of the app.<br>
V = Views - A component to display the user interface of the app.<br>
C = Controllers - A class that handle browser requests ```(localhost:PORT/Controller/Action)```, retrieve model data, and call view templates.<br> 

	### Model
	- represent information or data of the application operate on.<br>
	- handle logic processing data.<br>

	Example:
	```
	public class Book
	{
		public int Id { get; set; }

		[StringLength(100)]
		public string Title { get; set; }
		
		public string Author { get; set; }
	}
	```

	### View
	- part of the application that display the data to the users

	### Controller
	- manage user input and interactions determining which model types to work with and which view to render.

- MVC in Action<br>
	
	### Model
	
	Items.cs
	```
	public class Item 
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
	}
	```

	ItemsController.cs
	```
	using Microsoft.AspNetCore.Mvc;
	using MyApp.Models; 

	public class ItemsController: Controller
	{
		public IActionResult Overview()
		{
			var item = new Item() { name = "keyboard" }; // creates the item
			return View(item); // render the view
		}
	}
	```

	Overview.cshtml
	```
	@model MyApp.Models.Item
	@ {}
	<p>This is the name of the item @Model.Name</p>
	```

- What is IActionResult?<br>
	An interface defines a contract for all the different kind of result that action can return.

