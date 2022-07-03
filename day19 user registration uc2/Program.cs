// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;
public class lastname
{

    // Function to validate the userlastname
    public static bool isValidlastname(String name)
    {

        // Regex to check valid userlastname.
        String regex = "^[A-Za-z]\\w{5,29}$";

        // Compile the ReGex
        pattern p = Pattern.compile(regex);

        // If the username is empty
        // return false
        if (name == null)
        {
            return false;
        }

        // Pattern class contains matcher() method
        // to find matching between given userlastname
        // and regular expression.
        matches m = p.matches(name);

        // Return if the userlastname
        // matched the ReGex
        return m.matches();
    }

    // Driver Code
    public static void main(String[] args)
    {


        String Str = "Honey";
        Console.WriteLine("username(Str)");

        String Str = "hey";
        Console.WriteLine("isValidlastname(Str)");


    }

}