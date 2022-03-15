# Eng104 Console Sort Manager Project

This code is designed to allow a user to sort a random array of integers

## Design Requirements

The flow of using this system should be as follows:

* The user is presented with a number of sort algorithms to choose from `Console`
* Decision is given via the command line (using `Console.ReadLine()`)
* The program will then ask for the length of an array via the command line

> **The program should then output:**
> * The unsorted randomly generated array
> * The algorithm to be used
> * The sorted array after the algorithm has been executed
> * Time taken

The sorting algorithms uses should include:
* BubbleSort
* MergeSort
* .NET Library Sort Methods

The system should make use of the MVC (Model View Controller) pattern to seperate the IO (View) from the controller and model with the Factory Method pattern used to generate the requested model classes.
