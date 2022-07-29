#Eau Claire's Salon
#### By _**Alex McKnight**_

#### _This app creates a backend database for a hair salon that keeps track of stylist and client information_

## Technologies Used

* C#
* .NET
* Microsoft EntityFrameworkCore
* Razor
* ASP.NET MVC
* MySQL Workbench

## Description

_This app creates and integrates a backend database with a customer facing application. It is designed for the user to be able to add stylists and then assign clients to stylists._

## Setup/Installation Requirements

* In order to use this application you must have MySQL Workbench installed. Depending on your machine please follow setup instructions listed [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
* Clone this repository to your local machine
* In MySql Workbench, click the Administration tab, and then select Data Import/Restore.
* In the Data Import Window, select Import from self-contained file, and using the file browser option, navigate to this project's root directory and select alex_mcknight.sql
* Once selected, select New in the Default Schema to be Imported To, and name the schema "salon".
* Next, select the Import Progress tab and select Start Import.
* In the project's root directory, you will next need to create an appsettings.json file with the following information where YOURPASSWORDHERE is the password used to connect to MySQL: ```{
  "ConnectionStrings":{
    "DefaultConnection":"Server=localhost;Port=3306;database=salon;uid=root; pwd=[YOURPASSWORDHERE];"
  }
}```
* Once saved, type ```cd Salon``` in your command line to navigate to the main project folder.
* To install the project's dependencies, in the command line type ```dotnet restore```
* Once in the Project folder, type ```dotnet run``` in the command line to run the program.

## Known Bugs

* None at this time


## License

MIT License

Copyright (c) [2022] [Alex McKnight]