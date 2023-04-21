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
 -------------------------------------------------------------------------------------------------------------------


 2023-04-13
 0210 PM

ADDED REFERENCES TO >> RajsBooks.DataAccess >> for models and utility
Added new area to area folder calld Customer   Area>> CUSTOMER
Changed the routes in Startup.cs file like the one outlined in the ScaffoldingReadme.text.... pattern: "{area=Customer} Write in line number 66 startup.cs
IN CONTOLLRTS >> HOMEcontrollers>  added   in line number 12 brefore punlic class

Newlty added Customer area to area folder INSIDE Customer deleted Models and Data foler AND CONTROLLER >> HOMECONTROLLER.CS copied nad pasted inside CUSTOMER>> Controller and deleted the 
original one.

Edited NameSpace In  View >> HomeHomeController.cs  ""namespace RajsBooksStore.Area.CustomerControllers""

In VIEW > HOME moved Home to Customer>view>. PASTED AS Home.. and deleted original one

Time to do CLEAN, RE BUITD AND BUILTD

Application running well time to commit on github..

0310PM
Copied _ViewStart.cjshtml to CUSTOMER>> VIEW and Modified "    Layout = "~/Views/Shared/_Layout.cshtml";
Copied _ViewStart.cjshtml to CUSTOMER>> VIEW and Modified "    Layout = "~/Views/Shared/_Layout.cshtml";
" 
Run app is wporking'

Added new Area In Areas >> Named it Admin and Inside Admin deleted Data And Models folder and paster proper View Files form outside View Folder _ViewStart.cshtml and _Vire Imports.cshtml
0330PM

BUILD THE PROJECT (PART 2.1 Creat the DB)
0340 PM
TIME to committ on Github class ends soon..

BUild Clean Rebuild in Rebuild i got 2 Successful anfd 2 up- to- date, tried to found solution form google but not got much..
IN Appsetting.json modified DATABASE added name after database ;Database=RajsBooksStore

Created the migration BY TOOLS>. NUget PACKAGE>. PACKEGE CONSOLE AND Ren the "add-migration AddDefaultIdentityMigration", ints niot worked and tried selected DATAACCESS FOLDER FOR MIGRATION
AND ren the code to console again and it's worked                          
                                                     Nre migration file name entry is "20230413230122_AddDefaultIdentityMigration"

         0630PM

Updated database from PM console, Reviewed updated database in SQL Server Object Explore. VIEW>SQL>SERVER Explore, checked database was there.
RUn the Application All is working 
Ciommited On GITHUB As well.. 

0720PM
Added new class called Category to the ViewModels>> CATEGORY and writed code which is provided      AND ADDED MIGRATION to the RAJSBOOKS.MODELS via PM console, the new migration was empty "20230413232532_AddCategoryToDb.cs"
IN DATAACCESS >. DATA added "        public DbSet<Category> Categories { get; set; } " TO ApplicationDbContext.cs file

RERUN THIS MIGRATION IN  PM console
Migration vis PM IS " add-migration AddCategoryToDb"
Showing the dublication cause i had already done the migration 
for thath in PM console >> Remove-migration and than again need to do " add-migration AddCategoryToDb" so that is resolve the error that was occuring

             
Clean, Build, Rebuild application is running well.. 
time to commit on github..

            0738PM
              2023-04-13
              BUILD THE PROJECT (PART 2.2 Repository)

  ADDED NEW folder called "REPOSITORY" IN SIDE  RajsBooks.Dataaccess, inside REPOSITORY created IRepository folder..for the interface
  .. added new class item to IRepository named it IRepository.cs,
  write code as provided saved it.., IN THAT FILE MODIFUIED.. list of categories, Add objects and removed objects..

  0755PM
  Implimented the class repository and created new class clalled REPOSITORY.CS AND added to Repository folder..
  Modified thwe code tand construcors and dependency injevction (DI)
  fROM ASSIGNMENT 2 PROVIDED FILES IN CONTENT WRITED THE REPOSITORY.CS FILE 

       0830 PM
Created individual repos for Repository 1. CotegoryRepository.cs and ICategoryRepository.cs
modified categoryRepository ad provided  , Modified IcategoryRepository.
Build, Rebuild app runing well.

Time to commit on github.
         0855PM

         -------------------------------------------------------------------------------------------------
            2023-04-22
            0206PM

            build the project (CATEGORY CRUD)

            Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0006	Metadata file 'C:\Users\W0802730\Source\Repos\RajVekariya0\RajsBooksStore\RajsBooks.DataAccess\bin\Debug\netcoreapp3.1\RajsBooks.DataAccess.dll' could not be found	RajsBooksStore	C:\Users\W0802730\Source\Repos\RajVekariya0\RajsBooksStore\RajsBooksStore\CSC	1	Active

Severity	Code	Description	Project	File	Line	Suppression State
Error	CS1503	Argument 1: cannot convert from 'RajsBooks.DataAccess.Repository.AppcationDbContext' to 'RajsBooksStore.DataAccess.Data.ApplicationDbContext'	RajsBooks.DataAccess	C:\Users\W0802730\Source\Repos\RajVekariya0\RajsBooksStore\RajsBooks.DataAccess\Repository\UnitOfWork.cs	16	Active


Severity	Code	Description	Project	File	Line	Suppression State
Warning	RAZORSDK1007	Reference assembly C:\Users\W0802730\Source\Repos\RajVekariya0\RajsBooksStore\RajsBooks.DataAccess\bin\Debug\netcoreapp3.1\RajsBooks.DataAccess.dll could not be found. This is typically caused by build errors in referenced projects.	RajsBooksStore	C:\Program Files\dotnet\sdk\5.0.411\Sdks\Microsoft.NET.Sdk.Razor\build\netstandard2.0\Microsoft.NET.Sdk.Razor.MvcApplicationPartsDiscovery.targets	54	


           (ERRRORS  --- i HAD CREATED 2 ApplicationDbContext file and deleted one of them plus had done spelling mistakes in UnitOfWork or DBContext  )
           Have solve the errors and continue working over..

           0335PM

 Added Razor View Index to the newly created Ctegory folder inside the View.
 In Index.cshtml added View.text code provided in assignment 2 folder.

            0606PM 
    Finally got the room empty and working again on rest work....
    Clean build rebuild everything is working 

    made mistake i had created new razor view inside the Acutal Viewe but i need to creat it indie ADMIN>> VIEWS>> CATEGORY SO I HAVE DONE IT AGAIN AND REPLACE THE OLD CODE.

    Layout.chhtml in line number 26 i had put "                            <a class="nav-link" asp-area="Admin" asp-controller="Category" asp-action="Index">Category</a> "
    and in line number 33 "                                <a class="dropdown-item" asp-area="Admin"  asp-controller="Category" asp-action="Index" >Category</a> "

    Reviewed the changes to the nevigation now i can see "Category" in my dropdown..
    Time to commit on github..
         0621 PM

         Created Category.js inside WWWRoots>> JS,, and pasted code thet provided in assignment 2 folder..
         In Index.cshtml added the @Section call to the category.js "@section Scripts{
                                                                                        <script src="~/js/category.js"></script> }"

             0647PM
    Created new category using Upsert ACtion, Added IAction result to the controller and added View Razor component ot the view>Category ("Upsert.cshtml") 
    pasted code from the provided folder.....

    Created partial view for the EDIT - BACK  INSIDE GENERAL VIEW >> SHARED >> "_CreateAndBackToListButton"
                                 and written code ass shown added asp action..

    Created another partial View Called _EditAndBackToList.cshtml and writed code as @model razor statement (AS CODE ADDITION)

    Modified Upsert.cshtml with the @model statement  >>> and asp-action to the Index.cshtml  for navigation to category to create new category 
    Modified Upsert.cshtml to the @title variable and @section call to the script to validate input on the clint side.

                    Comit on Github...
                      0712PM

    Removed "_db.SaveChanges();" from CategoryRepository.cs and added " return RedirectToAction(nameof(Index)); "  MATHORD

    Gattying error on IUnitOfWork.cs 
    
    "Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0102	The type 'IUnitOfWork' already contains a definition for 'Save'	RajsBooks.DataAccess	C:\Users\W0802730\Source\Repos\RajVekariya0\RajsBooksStore\RajsBooks.DataAccess\Repository\IRepository\IUnitOfWork.cs	17	Active
"
                                 





