Creating an MVC Pattern Project in Visual Studio using ASP.NET Core MVC is straightforward. Follow these step-by-step instructions:

🛠 Step 1: Open Visual Studio
Open Visual Studio 2022 (or any latest version).
Click on "Create a new project".

🛠 Step 2: Choose Project Type
In the "Create a new project" window, search for "ASP.NET Core Web App (Model-View-Controller)".
Select it and click "Next".

🛠 Step 3: Configure Project
Project Name: Enter a name (e.g., GymManagementSystem).
Location: Choose a folder to save the project.
Solution Name: Keep it the same as the project name (or modify it if needed).
Click "Next".

🛠 Step 4: Choose .NET Version
Under Framework, select the latest .NET Core version (e.g., .NET 8.0).
Authentication Type: Choose "None" (for now).
Configure for HTTPS: ✅ Check this option.
Enable Docker Support: ❌ Uncheck (unless needed).
Use Controllers (MVC): ✅ Check this option.
Click "Create".

🛠 Step 5: Understanding the MVC Project Structure
After the project is created, Visual Studio generates an MVC project with the following folders:


/GymManagementSystem
│── Controllers/         <-- Handles user requests
│   ├── HomeController.cs
│
│── Models/              <-- Represents data and business logic
│   ├── Product.cs
│
│── Views/               <-- Contains UI files
│   ├── Home/
│   │   ├── Index.cshtml
│
│── wwwroot/             <-- Static files (CSS, JS, images)
│   ├── css/
│   ├── js/
│
│── appsettings.json     <-- Configuration file
│── Program.cs           <-- Entry point of the application
│── GymManagementSystem.csproj  <-- Project file

🛠 Step 6: Run the Project
Click on "IIS Express" or press Ctrl + F5 to run the project.
The default home page (Views/Home/Index.cshtml) will open in a browser.

🛠 Step 7: Add a New Model
Right-click on the "Models" folder → Add → Class.

Name it Product.cs and add the following code:


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

🛠 Step 8: Add a New Controller
Right-click on the "Controllers" folder → Add → Controller.

Select "MVC Controller - Empty".

Name it ProductController.cs.

Add the following code:


using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Dumbbells", Price = 5000 },
            new Product { Id = 2, Name = "Treadmill", Price = 30000 }
        };
        return View(products);
    }
}

🛠 Step 9: Add a View
Right-click on "Views" folder → Add → New Folder → Name it Product.

Right-click on "Views/Product" folder → Add → New Item.

Select "Razor View" and name it Index.cshtml.

Add the following code:


@model List<Product>

<h2>Product List</h2>
<table border="1">
    <tr>
        <th>ID</th>
        <th>Name</th>
        <th>Price</th>
    </tr>
    @foreach (var product in Model)
    {
        <tr>
            <td>@product.Id</td>
            <td>@product.Name</td>
            <td>@product.Price</td>
        </tr>
    }
</table>

🛠 Step 10: Configure Routing
Open Program.cs.

Ensure the default routing is set:


app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

🛠 Step 11: Run and Test
Run the project (Ctrl + F5).
Open https://localhost:port/Product in your browser.
You should see the Product List displayed.

🎯 Summary
✅ Created an ASP.NET Core MVC project in Visual Studio.
✅ Understood the MVC structure (Controllers, Models, Views).
✅ Added a Product Model.
✅ Created a ProductController to handle requests.
✅ Created an Index View to display products.
✅ Successfully ran the project.
