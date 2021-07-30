# Epicodus Friday Project | Eau Claire's Salon

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

## Further Exploration
- Include a form where employees may search for a stylist by name. Display a list of all results.
- Include a form where employees may also search for a client by name. Display a list of all results.
- Add a feature for adding an appointment to a client.
- Add a feature for adding an appointment to a stylist. Add a check to make sure the stylist does not have any conflicting appointments.
- Add a feature for keeping track of how much each stylist was paid for each appointment.
- Add styling to your page.