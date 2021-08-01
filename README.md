# Epicodus Friday Project | Eau Claire's Salon

##### Table of Contents
1. [Description](#description)
2. [Naming Conventions](#naming-conventions)
3. [Objectives](#objectives)
   - [Previous Objectives](#previous-objectives)
   - [Further Exploration Objectives](#further-exploration-objectives)
4. [Setting Up The Project](#setting-up-the-project)
   - [Setting Up The Database](#setting-up-the-database)
   - [Setting Up The Application](#setting-up-the-application)

## Description


- **Author**: Allister Moon Kays
- **Copyright**: MIT License

This is my eleventh independent project for the Epicodus bootcamp program. The goal is to create a C# Asp.Net web application with the following functionality:

You've been referred by Pierre to his friend Claire who is the owner of a hair salon called Eau Claire's Salon. She has contracted you out to create an MVC web application to help her manage her employees (stylists) and their clients. Claire should be able to add a list of stylists working at the salon, and for each stylist, add clients who see that stylist. The stylists have specific specialties, so each client can only see (belong to) a single stylist.

User Stories
- As the salon owner, I need to be able to see a list of all stylists.
- As the salon owner, I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist.
- As the salon owner, I need to add new stylists to our system when they are hired.
- As the salon owner, I need to be able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added.

## Naming Conventions
Use your first name and last name to name your database in the following way:
- Production Database: `first_last`

Use the following name for your directory:
- Main Project Folder: `HairSalon`

Exported Database:  
When you're finished, export the .sql file holding the information from your production database.

Please commit this file with your project in the top level of your solution folder. Again, use your first and last name as the file name following the pattern below:
- Production Database: `first_last.sql`

If you name your database, project folder, or `.sql` file incorrectly your project will be sent back to you immediately without being graded.

## Objectives
- Do the database table and column names follow both the specific requirements for this project and general .NET naming conventions?
- Are the instructions for re-creating your database thorough and clear?
- Is there a one-to-many relationship set up correctly in the database?
- Is CREATE functionality included for one class and is CREATE and VIEW functionality included for the other class?
- Is Entity used for communication with the database?
- Have all of the standards from previous weeks been met? (See below)
- Does the project demonstrate understanding of this week's concepts? If prompted, are you able to discuss your code with an instructor using correct terminology?
- Is the project in a polished, portfolio-quality state?
- Was required functionality in place by the deadline?
- Build files and sensitive information (such as appsettings.json) is included in .gitignore file and is not to be tracked by Git, and instructions are given to the user on how to recreate the appsettings.json file.

### Previous Objectives
- Project uses two or more controllers.
- GET and POST requests/responses are used successfully.
- MVC routes follow RESTful conventions.
- Logic is easy to understand.
- Code and Git documentation follows best practices (descriptive variables names, proper indentation and spacing, separation between front and back-end logic, detailed commit messages in the correct tense, and a well-formatted README).

### Further Exploration
- Include a form where employees may search for a stylist by name. Display a list of all results.
- Include a form where employees may also search for a client by name. Display a list of all results.
- Add a feature for adding an appointment to a client.
- Add a feature for adding an appointment to a stylist. Add a check to make sure the stylist does not have any conflicting appointments.
- Add a feature for keeping track of how much each stylist was paid for each appointment.
- Add styling to your page.

## Setting Up The Project
You are expected to have the following installed on your computer:

- A working bash terminal
- An instance of MySQL 8 or Docker
- .Net 5.0 or greater (https://dotnet.microsoft.com/download)

Before you can begin either set of setup instructions, you must do the following:
1. Download the files or clone the repository to your computer.

### Setting Up The Database
This assumes either an instance of MySQL 8 is installed, or you have Docker available on your computer

#### Using Docker
If you have Docker, then the set up will be quick and easy!

1. Ensure the Docker daemon is currently running on your computer
2. Close any instances of MySQL running
  - Or, change the ports used when running docker for this project. However, you'll be responsible for updating the DB configuration in that case.
3. Open a terminal instance in the root of this project
4. Run `docker compose up` to start the database. It will be created with correct default info and automatically update the internal database from the `allister_kays.sql` file.

#### Manual Database Setup

1. Ensure MySQL is installed and currently running
2. Open a terminal instance in the root of this project
3. Run `bash scripts/initialize-db.sh`
  - This will create the necessary database with assumed default information, this is:
  - Username is `root`. If you wish to change this, append `-u your-user-name` to the command
  - Password is `epicodus`. If you wish to change this, append `-p your-password` to the command
    - alternatively for no password, append the `-P` flag to the command
  - DB Name is `allister_kays`. If you wish to change this, append `-d database_name` to the command. The database does not need to exist, and any existing data be wiped out when the command runs.
  - An example would be `bash scripts/initialize-db.sh -u otherroot -p mypassword -d mydatabase`.
4. Alternatively, you can set the database up manually. You'll be responsible for creating the database, and then you can use the `allister_kays.sql` file as a source for filling in the table information.

### Setting Up The Application

1. The one thing you'll need to do before starting the project is setting up the `appsettings.json` file.
2. Open a terminal window
3. Run `bash scripts/create-appsettings.sh`
  - This will create the necessary `appsettings.json` file with assumed default information, this is:
  - Username is `root`. If you wish to change this, append `-u your-user-name` to the command
  - Password is `epicodus`. If you wish to change this, append `-p your-password` to the command
    - alternatively for no password, append the `-P` flag to the command
  - DB Name is `allister_kays`. If you wish to change this, append `-d database_name` to the command. The database does not need to exist, and any existing data be wiped out when the command runs.
  - An example would be `bash scripts/initialize-db.sh -u otherroot -p mypassword -d mydatabase`.
4. Alternatively, you can fill in the `appsettings.json` file yourself. You can copy the `appsettings.example.json` and rename it, then fill in the values.
5. Now you are ready to run the app
  - To run the application, use `dotnet run` while in the `HairSalon` directory.
  - Then, open your browser and load the dev server address to see the app. The default address will be `http://localhost:5000`.