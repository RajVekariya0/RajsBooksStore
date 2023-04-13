2023-03-02
1505
STARTED aSSIGNMENT 2 IN CLASS ON THE LAB COMPUTER

Set Up the ASP.NET MVC m/ Core 3.1 (out - of - support)

HTTPS enabled, individual account authenitication ....on Razor... !!

In STartup.cs file in line number 33 removed options for default identity :: 
(options => options.SignIn.RequireConfirmedAccount = true )

Reviewed the Areas folder, Controller, Model, View....
AND..
1507 -- 

Tested the app... ran it good .. tested links 
Action Items:
-Modify the nevigation
-Update the copyroght.. from "static" to "Dynamic"

0321 pm
modified the default welcome messege.. tested
review the rout pattern in startup.cs file

0322pm
clone the repository to github and not selcted private

2023-03-03

0314 pm

Confirmed the repo is done and now i want to test it....
Created README.md file on github and pull the request from VISUAL STUDIO so i can see it on my solution explore as well....

hy there
2023-03-09

0203 pm
Working on bootsrape 
In WWWROOT - CSS folder changed bootsrap.css too bootsrape_bk.css for backup purpose
added bootstrape.min.css from boothwatch.com

added code to  bootstrape.min.css (selected theme :- Quartz
A glassmorphic layer)
0230pm

RUN THE APPLICATION ALL IS WORKING.. TEHEME HAS BEEN APPLIED
0307 PM
In  VIEWS/SHARED/layout.chhtml.... added bew nav bar regarding my theme selection and changes old nav portion by changing code..
and keep needed nav properties...!!
trying to run the code if it is working or not..

all good ..!!!
DROPDOWN IS NOT WORKING... TRYING TO FIGURE IT OUT..
changed default navbar to "application name" rajs book store..

Figure that out by suffuring on google...
                        <li class="nav-item dropdown">
                         <a class="nav-link dropdown-toggle" id="navbarDrodownMenuLink">
                         This class needs to be added on Layout.chhtml_ for DROPDOWN..  LINE NUMBER "28, 30"
Lets see is it working or not...
everything is working.. well .!!

TIme to commit on github..
0340PM

PART - 2

It is strange that i had commented on 2023-03-23 lecture time and also coimmited to the git hub, and it is not visible on readme.

so let's start 
2023-03-30
2.03 PM

added Three new projects (.NET Core class library) to the application: which is RajsBookStore.DataAccess, 2 RajsBookStore.Models,    3 RajsBookStore.Utility

Copied "DATA" folder from the original space and pasted on the new created project RajsBookStore.DataAccess

02.32 PM

ModifED the namespace to ApplicationDbContext.cs
FROM tools >> Nuget Package manager >> manage nugat package for solution >> search for Core.relational and Core.Sqlserver >> selected the proper install version 3.1.32 and installed it.

Deleted the migrations folder

Installed Identity.EntityFramework Core NuGet
ModifED the namespace to ApplicationDbContext.cs file too namespace RajsBookStore.DataAccess.Data

Deleted all calss1.cs file from new created classes.
last step is building the project.

0251 PM


RUN THE PPLICATION AND GOT ERROR 
Error	CS0234	The type or namespace name 'Data' does not exist in the namespace 'RajsBookStore' (are you missing an assembly reference?)	RajsBookStore	C:\Users\W0802730\Source\Repos\RajVekariya0\RajsBookStore\Startup.cs	10	Active

commited on github

0300 PM
Moved models folder into RajsBookStore.Models
and develed the original once.
CHnaged namespace in Models>> ErrorViewModels.cs 

Modify Views > Shared >Error.cshtml
added project references .DataAccess and .Models changed name of Models and made it Viewmodels. 

removed using statement
modified Startup.cs file deleted line number 10 wich was""using RajsBookStore.Data;""

Clean, rebuild and build the application is runnig well..
time to commit on git hub

0338 PM
rEMOVED ALL EROORS REVIEW APPLICATION IS WELL RUNNING

0347 PM
Added cladd Sd.cs to the Utility Project 

Added project reference to the main project 
Added references to the DataAccess Project of Models and Utility











