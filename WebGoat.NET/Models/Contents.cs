using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WebGoatCore.Models
{
    public class Contents
    {
        private const string _regexPattern = @"[<>]";
        private string content;

    public Contents(string content)
        {
        IsContentValid(content);
        this.content = content;

        }

    public string GetContent()
        {
        return content;
        }

    private void IsContentValid(string content)
        {
        if (Regex.IsMatch(content, _regexPattern))
            {
                throw new ArgumentException("You cannot use krokodillenæb");   
            }      
        }
    
    }
}