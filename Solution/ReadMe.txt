# CS-Solution-Template

This is a full C# Solution Template With Service, Command Line and settings editor.

This solution is a quick start, you can delete parts you dont need, for instance the service. It uses a shared config file for the solution so the .Settings Project can work for all projects in the solution.
Also there are post build events that puts everything togheter.  This is where you should test your application.

More explanations to come. Feel free to ask questions.


#Getting started

- Download the zip and extract it in a folder
- Open RenameProject.ps1 and CHANGE THE VARIABLES VALUES TO FIT YOUR NEED --> AKA: Company Name, Project/product long Name, Short name (used for namespaces), Service displayname and description, year.
- Right click RenameProject.ps1, and select "Run with powershell"
- Delete RenameProject.ps1


- You will have to change Icons and look in the solution to keep what you need


#How to use the template solution: 

+ The business code logic needs to be writtent in the Core dll.

+ Then use the command line and service code to write the code to call business code from the dll.

+ After compiling: always use the /Build folder in the first level directory level to test the application.

+ To install the service
 - run a command prompt as administrator
 - navigate to service folder
 - run: YourAppServiceService --install / YourAppServiceService --uninstall


 
