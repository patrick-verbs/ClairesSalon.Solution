# "Claire's Salon"

#### _Database basics in .NET Core MVC_ | Patrick Lee

## Description

This project was made to demonstrate basic proficiency in working with MySQL databases in C# with the .NET Core MVC framework. The solution allows a business owner, "Claire," to add, view, edit, and delete both employees (hair stylists) and their respective lists of customers, in a many-clients-to-one-stylist relationship.

## Setup and Use

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash to set up and run the project
- MySQL 8.0.19, following [these instructions](https://web.archive.org/web/20210521163651/https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
  - MacOS:
    - [MySQL Community Server 8.0.19](https://dev.mysql.com/downloads/file/?id=484914)
    - [MySQL Workbench 8.0.19](https://dev.mysql.com/downloads/file/?id=484391)
  - Windows:
  - [MySQL Server & Workbench 8.0.19](https://downloads.mysql.com/archives/get/p/25/file/mysql-installer-web-community-8.0.19.0.msi)
- A web browser to view and interact with the project

### Installation

1. Clone the repository: `$ git clone https://github.com/patrick-verbs/ClairesSalon.Solution`
2. Navigate to the `ClairesSalon.Solution` directory on your computer
3. Open with your preferred text editor to view the code base
4. To setup the SQL database:
  - Create an `appsettings.json` file in the `ClairesSalon.Solution/HairSalon` directory
  - Copy the text box below and paste into the `appsettings.json` file, replacing `<password>` with your MySQL password:
  ```
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=patrick_lee;uid=root;pwd=<password>;"
    }
  }
  ```
  - __Option 1: Recreate the database structure using MySQL terminal commands__
    - Open your terminal and run the command: `mysql -uroot -p<mysql_password>` (replace `<mysql_password>` with your MySQL password) and select the enter key to launch MySQL server
    - Type the following commands to setup the database:
      1. `CREATE DATABASE patrick_lee;` to make a new database
      2. `USE patrick_lee;` to connect to the new database
      3. `CREATE TABLE {Stylists (StylistId INT NOT NULL AUTO_INCREMENT PRIMARY KEY, NameFirst VARCHAR(255), NameLast VARCHAR(255), Specialty VARCHAR(255), Phone VARCHAR(255), Email VARCHAR(255))};` to create a `{Stylists}` table
      4. `CREATE TABLE {Clients (ClientId INT NOT NULL AUTO_INCREMENT PRIMARY KEY, StylistId INT NOT NULL, NameFirst VARCHAR(255), NameLast VARCHAR(255), Phone VARCHAR(255), Email VARCHAR(255))};` to create another new table, `{Clients}`
  - __Option 2: Import the database structure using MySQL Workbench__
    - Open MySQL Workbench
    - On the "Welcome" page, double-click the MySQL instance in the __MySQL Connections__ section. You may be prompted to enter a password; if so, this will be `epicodus` or your custom password, just as in the earlier step
    - Click on the __Adminstration__ tab
      1. Click on _Data Import/Restore_
      2. In the Data Import window that appears, select _Import from Self-Contained File_
      3. Navigate the file selection to your cloned project location and choose the `.sql` file at `ClairesSalon.Solution/patrick_lee.sql`
      4. At the __Default Target Schema__ option, choose _New..._ and name the schema `hair_salon`
      5. Click the _Start Import_ button at the bottom-right; if you can't find it, you may need to maximize your MySQL Workbench window

5. To serve the local web app:
  - Navigate to `ClairesSalon.Solution/HairSalon}` in your command line
  - Run the command `dotnet restore` to restore the dependencies that are listed in `HairSalon.csproj`
  - Run the command `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
  - Run the command `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
  - Run the command `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`
  - Run the command `dotnet build` to build the project and its dependencies into a set of binaries
  - Finally, run the command `dotnet run` to run the project!
  - Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app
6. Visit the application via web browser at: `localhost:5000/`

## Known Bugs

_None identified_ :bug:

## Technologies Used

- This fantastic [.NET Core MVC + MySQL template](https://github.com/TorchAblaze/WeekThreeTemplate.Solution) by __[TorchAblaze](https://github.com/TorchAblaze)__
- MySQL Server 8.0.19 and MySQL Workbench 8.0.19
- C#
- [ASP.NET Core MVC framework](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-5.0) for building the web app
- HTML5 with Razor pages
- CSS3 with Bootstrap 4.5.0 framework
- .NET 5 SDK with MSTest
- VS Code

## <a name="License"></a>License
<details>
<summary><a href="https://opensource.org/licenses/MIT"><strong>MIT</strong></a></summary>
<pre>
MIT License
Copyright (c) 2021 Patrick Lee


Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:


The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.


THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
</pre>
</details>

Copyright © 2021 Patrick Lee
<br>

## Contact Information

Patrick Lee | patricklee1138[at]live[dot]com