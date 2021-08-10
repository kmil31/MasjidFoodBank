# Data Tracking System for Mosque Foodbank

#Implementation
Recipients should be a class of its own, a ViewModel of some kind should be set up as a means to interact with the Database.

## Problem

Masjid Muadz Jabal Setiawangsa has a food bank program that provides food to the needy and hungry. Currently, they give away food to people on the noble assumption that people would only take it once a day. This is to ensure that food will go around to everyone equally. However, certain actors have found it in them to take more then a single package, potentially causing other people that might greatly need it to not receive the food.

## Solution

Create a desktop application that requires a food reciever to input their name and IC.
The application will check whether or not they have taken food today, and if they are eligible to recieve the food.

## Requirements

1) A GUI that displays the following forms :
 - Name
 - IC
 - Address

and a submit button.
 
 2) A database that stores the variables in the form, as well as the date and time of the form submission. The database should have the following fields:
 - Name
 - IC 
 - Address
 - Date of Receiving
 
3) A page that allows a user to input their name and IC, and it will display the record of all their food receivings, similar to a bank statement.


## Basic Program Flow

The application should prompt the user to enter the receiver's name and IC, as well as address. The person performing the data entry should ask for the applicants IC for the data. When the form is filled, and the submit button is pressed, the application would perform one of the following tasks :

1) Check the database for any record of the user. If a record does not exist, create a new record and the user is allowed to receive food.


2) If a record exists, and the last date of the food recipient is at least 1 day before, (no need to strictly 24 hours because thats stupid), display in the GUI that the recipient is allowed to receive food.

3) If a record exists, and the last date is not at least 1 day before the current date, reject the applicant.

For the page that displays records:
Input Name and IC, and display all the records in a single page. Try to integrate an export to pdf function first.


## Possible future integrations(optional)

IC scanner integration, instantly fill in the forms and date.

Exporting the records of the applicants into an excel sheet.
