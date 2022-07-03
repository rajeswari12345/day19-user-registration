// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;
namespace FirstName
{


    // Function to validate the username
    public static bool isValidFirstName(String firstname)
    {

        // Regex to check valid firstname.
        String regex = "^[A-Za-z]\\w{5,29}$";

        // Compile the ReGex
        Pattern p = Pattern.compile(regex);

        // If the username is empty
        // return false
        if (name == null)
        {
            return false;
        }

        // Pattern class contains matcher() method
        // to find matching between given username
        // and regular expression.
        Matcher m = p.matcher(name);

        // Return if the username
        // matched the ReGex
        return m.matches();
    }

    // Driver Code
    public static void Main(String[] args)
    {

        // Test Case: 1
        String str = "honey";
        Console.WriteLine(isValidFirstName(str));

    }
}
}