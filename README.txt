README

2025-02-19

10:40:20 Victor -  Started to create a new ASP.NET Core MVC project 
10:45:34 Victor - added a controller named HelloWorldController 
10:46:41 Victor - changed Controllers/HelloWorldController.cs code 
10:52:11 Victor - changed Welcome Method 
10:54:31 Victor - Webapp tested, and everything was ok
10:55:24 Victor - Index method was replaced by a new code to calls the controller's View method.
10:57:11 Victor - New Folder named HelloWorld was added to Views folder
10:59:52 Victor - Razor View was added

11:00:02 Victor - a new code for Index.cshtml  was typed specifing that the method should use a view template file to render a response to the browser.
11:05:45 Victor - a new folder named img in wwwroot was created and an logo image was inserted
11:15:18 Victor - we tried to insert a log, but we didn't have success.so let's leave it for later
11:17:32 Victor - we changed the title, footer, and menu link in the layout file
11:25:09 Victor - A new class named Truck.cs was created
11:66:10 Victor - the new class Models/truck.cs was coded, the DataType attribute was specified for the Year of the truck
11:42:22 Victor - we used the scaffolding tool to produce Create, Read, Update, and Delete (CRUD) pages for the truck model.
11:55:31 victor - An initial migration,the EF Core Migrations feature was used to create the database.
11:58:01 Victor - the commands Add-Migration InitialCreate and Update-Database were shot from the Tools menu, select NuGet Package Manager > Package Manager Console, terminal.

12:01:19 Akhil -  the webapp was tested and everything was running in the correct way.
12:10:45 Akhil - Started implementing security features for data protection in ASP.NET Core.
12:15:23 Akhil - Configured authentication and authorization by adding the [Authorize] attribute to controllers and actions.
12:20:33 Akhil - Created a new role-based authorization policy in Startup.cs.
12:25:11 Akhil - Applied authorization policies to different parts of the application, restricting access to specific roles.
12:30:55 Akhil - Modified views to display or hide content based on the user's authentication and authorization status.
12:40:09 Akhil - Added a database migration to include identity-related tables using `dotnet ef migrations add IdentityMigration` and `dotnet ef database update`.
12:50:12 Akhil - Tested authentication and authorization by creating user accounts and assigning roles in the application.

13:00:32 Victor - Cloning the repository from GitHub using Visual Studio.
13:05:30 Victor - Opened Visual Studio, selected "Clone a repository" from the start menu.
13:10:07 Victor - Entered the GitHub repository URL: `https://github.com/victorbegnini2025/SteelHorseTrucks`
13:15:53 Victor - Selected a local path for cloning the repository and clicked "Clone."
13:20:50 Victor - Verified that all project files were successfully cloned and opened the solution in Visual Studio.

13:30:32 Vishal - Committing and pushing changes to the remote repository.
13:35:28 Vishal - Made necessary modifications to the project and verified all updates.
13:40:45 Vishal - Opened Team Explorer, selected "Changes," entered a commit message.
13:45:23 Vishal -  Committed the changes locally.
13:50:09 Vishal - Clicked "Sync" in Team Explorer to push the committed changes to the remote repository on GitHub.

13:55:65 Victor - Verified that the changes were successfully reflected in the remote repository.

14:00:12 Victor -  The web application was tested again, and all new features, including authentication and authorization, were working correctly.

2025-02-20


11:06:34 Victor - e conducted a code review.
11:10:09 Victor - The image and the homepage text were added.
11:15:24 Victor - README file was updated.
11:26:41 Victor - A new update was made to GitHub, and a new push was performed.

2025-03-05

00:34:12 Akhil - README file updated with the latest changes and progress.

login:delta@deltateam.com
password:Abc123456!

02:36:16 Vishal - Updated the Controller file.

2025-03-09

10:15:22 Victor - Created a testing environment to validate new features before deployment.
10:45:37 Akhil - Set up a production environment to ensure a stable and secure release.
11:20:12 Vishal - Configured CI/CD pipelines for automated deployment using GitHub Actions.
12:00:45 Victor - Conducted initial testing in the testing environment, identifying minor issues to be fixed.

2025-03-12

09:30:18 Akhil - Addressed identified issues and optimized database queries for better performance.
10:15:45 Vishal - Enhanced logging capabilities to improve debugging and error tracking.
11:40:09 Victor - Successfully deployed the web application to the production environment.
12:10:32 Victor - Verified that all functionalities were working as expected in the live system.
12:45:10 Vishal - Performed security assessments to ensure data protection in the production environment.

2025-03-17

08:30:55 Victor - Finalized the user documentation for onboarding and administration.
09:15:20 Akhil - Performed load testing to evaluate system performance under stress conditions.
10:10:42 Vishal - Updated components for a user-friendly experience.
11:00:27 Victor - The website was officially launched and made publicly available at https://steelhorsetrucks.azurewebsites.net/.
11:30:15 Akhil - Monitored system performance post-deployment and confirmed stability.


