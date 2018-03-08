helloWorld Application

Requirements:
1.	Write a ‘Hello World’ program. 
•	The program has 1 current business requirement – write “Hello World” to the console/screen. 
•	The program should have an API that is separated from the program logic to eventually support mobile applications, web applications, or console applications, or windows services. 
•	The program should support future enhancements for writing to a database, console application, etc. 
o	Use common design patterns (inheritance, e.g.) to account for these future concerns. 
o	Use configuration files or another industry-standard mechanism for determining where to write the information to. 
2.	Write unit tests to support the API.

Solution consists of:
1.	helloWorldAPI – Web API for the application
2.	helloWorldAPI.Tests – Unit tests for Web API
3.	helloWorldBLL – Business Logic 
4.	helloWorldBusinessObj – Business Objects for Web API
5.	helloWorldConsole – Console application that displays text received from the Web API
6.	helloWorldDAL – Data Access Layer 

To run the application:
1.	Build the solution in Visual Studio 2015.
2.	Set the helloWorldAPI project as the 'Startup Project'
3.	Run the helloWorldAPI project
4.	Open a cmd window
5.	Update the config file of the console app with the URL of the API if necessary 
6.	Run the helloWorldConsole executable in the cmd window (helloWorld\ConsoleApp\bin\Debug\ConsoleApp.exe)
