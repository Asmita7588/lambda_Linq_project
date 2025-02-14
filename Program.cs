using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using LambdaLinqProject;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        //find even num from list
        FindEvenFromList findEven = new FindEvenFromList();
        findEven.FindEven();

        //find String strats with a
        FindStringStartsWithA stringStartsWithA = new FindStringStartsWithA();
        stringStartsWithA.FindString();

        //Sort List Of IntergesIN Desc
        SortListOfInt sortListOfInt = new SortListOfInt();
        sortListOfInt.SortListOfIntergersInDesc();

        //CheckList of int 
        CheckListOfInt checkListOfInt = new CheckListOfInt();
        checkListOfInt.CheckListOfIntergers();

        //check more that 5 char in list of str
        CheckNo0fChar checkNo0FChar = new CheckNo0fChar();
        checkNo0FChar.CheckNo0fCharInList();

        //checkDistinct numbers
        RetrieveDistinctInts retrieveDistinctInts = new RetrieveDistinctInts();
        retrieveDistinctInts.FindDistinctListOfInts();

        //find sum of Odd
        CalculateSumOfNum num = new CalculateSumOfNum();
        num.FindSumOfNum();

        //Find the maximum number in a list of integers.
        num.FindMaxNum();

        // Create a list of squares of integers from an existing list.
        num.CreateSquareList();

        //Filter a list of strings to only include those ending with ".com".
        FindStringStartsWithA findStringStartsWithA = new FindStringStartsWithA();
        findStringStartsWithA.FilterListOfStr();

        //Intermidiate

        //Group a list of strings by their first letter.

        GroupStringsByFirstLetter firstLetter = new GroupStringsByFirstLetter();
        firstLetter.GroupWordsByFirstLetter();

        //Find the top 3 highest numbers in a list of integers
        TopThreeHighestNum topThreeHighestNum = new TopThreeHighestNum();
        topThreeHighestNum.TopThreeHighest();


        //Retrieve all employees with a salary greater than $50,000 from an employee list.

        EmployeeList employee = new EmployeeList();
        employee.CheckEmployeeSalary();

        //Check if all elements in a list of integers are positive.
        CheckPositiveList list = new CheckPositiveList();
        list.CheckPositiveInts();

        //first number in a list that is divisible by 3 and 5
        list.FindFirstNumDivisible();

        //Combine two lists of integers into one list without duplicates.
        list.CombineTwoListWithoutDuplicate();


        //Extract names of students who scored more than 80 in a subject from a list of student objects.
        GetStudentScore getStudent = new GetStudentScore();
        getStudent.FindScore();

        //Find the longest string in a list of strings.
        FindStringStartsWithA findStringStart = new FindStringStartsWithA();
        findStringStart.FindLongestStringInList();

        //Retrieve the names of products that are out of stock from a product list.

        ProductDetails productDetails = new ProductDetails();
        productDetails.OutOfStockProduct();

        //Calculate the average of a list of floating-point numbers.
        TopThreeHighestNum topThreeHighest = new TopThreeHighestNum();
        topThreeHighest.FindAverage();

    }
}