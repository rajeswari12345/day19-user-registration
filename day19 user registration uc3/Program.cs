// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;
public class Validmail
{

    public static Regex _ regex =  new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
     Match match = regex.Match(email);


    public static bool IsValidEmailFormat(string emailInput)
    {
        return _regex.IsMatch(emailInput);
    }
}