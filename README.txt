README

2025-02-19

10:40:20 Started to create a new ASP.NET Core MVC project.
10:45:34 added a controller named HelloWorldController
10:46:41 changed Controllers/HelloWorldController.cs code
10:52:11 changed Welcome Method
10:54:31 Webapp tested, and everything was ok
10:55:24 Index method was replaced by a new code to calls the controller's View method.
10:57:11 New Folder named HelloWorld was added to Views folder
10:59:52 Razor View was added

11:00:02 a new code for Index.cshtml  was typed specifing that the method should use a view template file to render a response to the browser.
11:05:45 a new folder named img in wwwroot was created and an logo image was inserted
11:15:18 we tried to insert a log, but we didn't have success.so let's leave it for later
11:17:32 we changed the title, footer, and menu link in the layout file
11:25:09 A new class named Truck.cs was created
11:66:10 the new class Models/truck.cs was coded, the DataType attribute was specified for the Year of the truck
11:42:22 we used the scaffolding tool to produce Create, Read, Update, and Delete (CRUD) pages for the truck model.
11:55:31 An initial migration,the EF Core Migrations feature was used to create the database.
11:58:01 the commands Add-Migration InitialCreate and Update-Database were shot from the Tools menu, select NuGet Package Manager > Package Manager Console, terminal.

12:01:19 the webapp was tested and everything was running in the correct way.
12:10:45 Started implementing security features for data protection in ASP.NET Core.
12:15:23 Configured authentication and authorization by adding the [Authorize] attribute to controllers and actions.
12:20:33 Created a new role-based authorization policy in Startup.cs.
12:25:11 Applied authorization policies to different parts of the application, restricting access to specific roles.
12:30:55 Modified views to display or hide content based on the user's authentication and authorization status.
12:40:09 Added a database migration to include identity-related tables using `dotnet ef migrations add IdentityMigration` and `dotnet ef database update`.
12:50:12 Tested authentication and authorization by creating user accounts and assigning roles in the application.

13:00:32 Cloning the repository from GitHub using Visual Studio.
13:05:30 Opened Visual Studio, selected "Clone a repository" from the start menu.
13:10:07 Entered the GitHub repository URL: `https://github.com/victorbegnini2025/SteelHorseTrucks`
13:15:53 Selected a local path for cloning the repository and clicked "Clone."
13:20:50 Verified that all project files were successfully cloned and opened the solution in Visual Studio.

13:30:32 Committing and pushing changes to the remote repository.
13:35:28 Made necessary modifications to the project and verified all updates.
13:40:45 Opened Team Explorer, selected "Changes," entered a commit message.
13:45:23 Committed the changes locally.
13:50:09 Clicked "Sync" in Team Explorer to push the committed changes to the remote repository on GitHub.
13:55:65 Verified that the changes were successfully reflected in the remote repository.

14:00:12 The web application was tested again, and all new features, including authentication and authorization, were working correctly.

2025-02-20

11:06:34 e conducted a code review.
11:10:09 The image and the homepage text were added.
11:15:24 README file was updated.
11:26:41 A new update was made to GitHub, and a new push was performed.
