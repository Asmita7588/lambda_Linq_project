using System.Collections.Generic;
using LambdaLinqProject;

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



    }
}