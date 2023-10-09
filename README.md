# _Eau Claire's Salon_

#### By _Joey Palchak_

#### _A C# / ASP.NET Core MVC application using Entity Framework Core and MySQL._

## Technologies Used

* C#
* .NET 6
* ASP.NET Core MVC
* Entity Framework Core
* MySQL
* MySQL Workbench

## Description

This is a simple website for a fictional hair salon, where a user can add Stylists to the site's database, as well as add Clients for a specific Stylist at the Salon. Users can view a list of all available Stylists, as well as view a list of Clients for a specific Stylist, or for the Salon as a whole.

You can find a diagram representing the project's schema below:

<div style="text-align: center">
  <img src="https://github.com/jfpalchak/HairSalon.Solution/blob/assets/salon-schema.png" />
</div>

## Setup/Installation Requirements

#### Install Tools
This project assumes you have MySQL Server and MySQL Workbench installed on your system. _If you do not have these tools installed_, follow along with the installation steps for the the necessary tools introduced in the series of lessons found here on [LearnHowToProgram](https://full-time.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

#### Set Up the Database
To set up a new database to run with this application, follow the instructions in this [LearnHowToProgram Lesson](https://full-time.learnhowtoprogram.com/c-and-net/database-basics/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench). You'll need to import the `joey_palchak.sql` file located at the top level of this repository to create a replicate database in MySQL Workbench with the name `joey_palchak`.

#### Install and Run the Project

Assuming you've completed the required steps above:

1. Copy the **[URL](https://github.com/jfpalchak/HairSalon.Solution.git)** provided for this repository.
2. Open Terminal.
3. Change your working directory to where you want the cloned directory.
4. In your terminal, type `git clone` and use the copied URL from Step 1. Or, copy the following git command:
```bash
$ git clone https://github.com/jfpalchak/HairSalon.Solution.git
```
5. Open your terminal and navigate to this project's production directory called `HairSalon`.
6. Within the production directory of the project, create a file called `appsettings.json` and add the following code to it:
   ```json
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=joey_palchak;uid=[USERNAME];pwd=[PASSWORD];"
      }
    }
   ```
7. Next, make sure to update the connection string with your own system's values for `[USERNAME]` and `[PASSWORD]`! Don't forget to replace the brackets `[]` as well.
8. In the command line, run the following command to compile and run the web application in development mode with a watcher:
   
```bash
$ dotnet watch run
```
> Optionally, you can run `dotnet build` to compile this web app without running it.

9. Open your browser to https://localhost:5001 to navigate and use the web application. 
> If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS.


## Known Bugs

* If any bugs are discovered, please contact the author.

## License

MIT License

Copyright (c) _10/06/2023_ _Joey Palchak_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.