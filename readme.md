# _Epicodus C# Word Counter_

#### Date: May 15th, 2020
#### By **Jason Macie**

## Description

This is a console application that will take in a word and a sentence. Once both inputs are entered, it will count the amount of words that are in the sentence and display it.

## Setup/Installation Requirements

This program requires .NET to be installed. It uses the MSTest tool to test possible string inputs.

1. Clone this repository
2. Change any tests in WordCounter.Tests/ModelTests/Count.cs
3. Navigate to the repo in command console. Then navigate to Leetspeak.Tests directory.
4. Run dotnet restore
5. Run dotnet test

## Specs

### Behaviors to Test:

1. Create an instance of the Counter class with an empty constructor.
2. Create a property of the Counter class. It will be a string to store the search word.<br/> Input: test<br/> Expected Output: Counter.searchTerm = "test"
3. Create a property of the Counter class. It will be a list of strings to store the words that will be searched through.<br/> Input:test sentence<br/> Expected Output: Counter.wordList = {"test", "sentence"}
4. Create a method that returns a message displaying the Counter class's properties.<br/> Input: test, test sentence<br/> Output: Your search word is: test and your sentence is: test sentence.
5. Create a method that compares searchTerm with the contents of wordList. If there are any matches, add to a counter. Return the counter to represent the number of matches in the sentence.<br/> Input: cat, I'm a cat person. A cat is the best.<br/> Output: 2
6. Test compare method to only return the number of exact matches.<br/>Input: dog, A dog is a dogMA<br/>Output: 1
7. Test compare method to no be case sensetive, and to ignore punctuations.<br/>Input: turtles, A Turtle's turtle is turtling when turtled.<br/>Output: 1

## Known Bugs

No known bugs as of 5/15/2020

## Technologies Used

.NET

### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Jason Macie_**