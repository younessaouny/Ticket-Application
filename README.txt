TicketsApp


Description:

TicketsApp is a ticket management application built with .NET for the backend and Angular for the frontend. It allows users to create, track, and manage support tickets.

Prerequisites:

Before running the application, make sure you have the following installed:

.NET SDK (version 7.0 or higher)
Node.js (version 16 or higher)
Angular CLI (optional but recommended)
LocalDB

Installation:

Update the appsettings.json file to modify the path to your local database file. Find the DbConnection section and update the AttachDbFilename path to point to the location of your .mdf file. For example:


"DbConnection": "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\your\\new\\path\\TicketDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"

Important!: Ensure the path matches the actual location of the database file on your machine.
