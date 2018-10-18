# Lab07-Collections

## Deck of Cards

This is a basic C# Console Application with a Card Class that creates an object with the properties of a playing ard (Suit and Value).

The Cards can then be added to a custom defined collection class Deck<T> and be enumerated to display the entire card collection in the Deck.

## Version

V1.0 - 10/17/2018 Basic Functionality w/ Testing Unit

## Requirements

Visual Studios 2017 or equivalent C# IDE

.NET Core 2.1 SDK

## Instructions

Clone this repo to local storage and open it up using Visual Studios 2017.

Open the Lab07Colletions.sln solution located in the Lab02-Unit-Testing folder.

Compile the Program.cs and run the application.

The console command will show a few demonstration showing the Add, Remove, and Returning all cards with a particular suit capabilities

## Additional Notes

The delete method only deletes the specific object in the collection, not if the properties of object matches.

## Testing

XUnit is included and tests the following:

Test the Set/Get properties of each card.

Test a card can be added to the collection

Test a card can be deleted from the collection.

Test that deleting a nonexistant card from the collection will do nothing.

## Result

![Console](Capture.PNG?raw=true "Output")
